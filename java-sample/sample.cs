using System;
using System.IO;
using System.Threading.Tasks;
using Azure;
using Azure.Storage.Blobs;
using DocumentFormat.OpenXml.Packaging;

namespace AzureBlobSpreadsheetExample
{
    class Program
    {
        // Replace these constants with your actual values
        private const string BlobConnectionString = "Your_Azure_Blob_Storage_Connection_String";
        private const string ContainerName = "your-container-name";
        private const string BlobName = "your-spreadsheet.xlsx";

        static async Task Main(string[] args)
        {
            try
            {
                // Initialize the BlobServiceClient
                BlobServiceClient blobServiceClient = new BlobServiceClient(BlobConnectionString);

                // Get the container client
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(ContainerName);

                // Ensure the container exists
                await containerClient.CreateIfNotExistsAsync();

                // Get the blob client
                BlobClient blobClient = containerClient.GetBlobClient(BlobName);

                // Check if the blob exists
                bool blobExists = await blobClient.ExistsAsync();

                if (!blobExists)
                {
                    Console.WriteLine($"Blob '{BlobName}' does not exist in container '{ContainerName}'.");
                    
                    // Optionally, handle the absence of the blob
                    // For example, create a new spreadsheet and upload it
                    Console.WriteLine("Creating a new spreadsheet...");

                    using (MemoryStream newSpreadsheetStream = CreateNewSpreadsheet())
                    {
                        // Upload the new spreadsheet to Azure Blob Storage
                        await blobClient.UploadAsync(newSpreadsheetStream, overwrite: true);
                        Console.WriteLine($"New spreadsheet '{BlobName}' created and uploaded to container '{ContainerName}'.");
                    }

                    // Optionally, exit the application if no further action is needed
                    // return;
                }

                // Download the blob's content to a memory stream
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    await blobClient.DownloadToAsync(memoryStream);

                    // Reset the stream's position to the beginning
                    memoryStream.Position = 0;

                    // Open the SpreadsheetDocument from the stream
                    using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(memoryStream, false))
                    {
                        // Now you can manipulate the spreadsheet as needed
                        // For example, list sheet names
                        var workbookPart = spreadsheetDocument.WorkbookPart;
                        var sheets = workbookPart.Workbook.Sheets;

                        Console.WriteLine("Sheets in the spreadsheet:");
                        foreach (var sheet in sheets)
                        {
                            Console.WriteLine($"- {sheet.Name}");
                        }

                        // If you need to make changes, open in edit mode by setting the second parameter to true
                        // using (SpreadsheetDocument editableDoc = SpreadsheetDocument.Open(memoryStream, true))
                        // {
                        //     // Modify the document
                        // }
                    }
                }
            }
            catch (RequestFailedException ex) when (ex.Status == 404)
            {
                Console.WriteLine($"Error: Container '{ContainerName}' does not exist or is inaccessible.");
                // Handle specific Azure Blob Storage errors here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                // Handle other exceptions
            }
        }

        /// <summary>
        /// Creates a new empty spreadsheet and returns it as a MemoryStream.
        /// </summary>
        /// <returns>A MemoryStream containing the new spreadsheet.</returns>
        private static MemoryStream CreateNewSpreadsheet()
        {
            MemoryStream stream = new MemoryStream();

            // Create a new spreadsheet document
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(stream, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook))
            {
                // Add a WorkbookPart
                WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                workbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                // Add a WorksheetPart
                WorksheetPart worksheetPart = workbookPart.AddNewPart<DocumentFormat.OpenXml.Packaging.WorksheetPart>();
                worksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(
                    new DocumentFormat.OpenXml.Spreadsheet.SheetData());

                // Add Sheets to the Workbook
                DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new DocumentFormat.OpenXml.Spreadsheet.Sheets());

                // Append a new sheet and associate it with the workbook
                DocumentFormat.OpenXml.Spreadsheet.Sheet sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet()
                {
                    Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Sheet1"
                };
                sheets.Append(sheet);

                workbookPart.Workbook.Save();
            }

            // Reset the stream's position to the beginning before returning
            stream.Position = 0;
            return stream;
        }
    }
}
