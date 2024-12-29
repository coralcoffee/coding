package samplej.ex;
public class Sort {

    public static void main(String[] args) {
        int[] numbers = { 8, 3, 1, 7, 10, 5, 4, 2, 9, 6 };
        System.out.println("original nums");
        for (int i = 0; i < numbers.length; i++) {
            System.out.printf("%d ", numbers[i]);
        }
        System.out.println();


        Sort s = new Sort();

        System.out.println("selection sort");
        s.selectionSort(numbers);
        for (int i = 0; i < numbers.length; i++) {
            System.out.printf("%d ", numbers[i]);
        }
        System.out.println();

        System.out.println("bubble sort");
        numbers = new int[] { 8, 3, 1, 7, 10, 5, 4, 2, 9, 6 };
        s.bubbleSort(numbers);
        for (int i = 0; i < numbers.length; i++) {
            System.out.printf("%d ", numbers[i]);
        }
        System.out.println();

        System.out.println("insertion sort");
        numbers = new int[] { 8, 3, 1, 7, 10, 5, 4, 2, 9, 6 };
        s.insertionSort(numbers);
        for (int i = 0; i < numbers.length; i++) {
            System.out.printf("%d ", numbers[i]);
        }
        System.out.println();
    }

    private void selectionSort(int[] arr) {
        for (int i = 0; i < arr.length -1; i++) {
            int min = i;
            for (int j = min; j < arr.length; j++) {
                if (arr[j] < arr[min]) {
                    min = j;
                }
            }
            int t = arr[min];
            arr[min] = arr[i];
            arr[i] = t;
        }
    }

    private void bubbleSort(int[] arr) {
        for (int i = arr.length - 1; i > 0; i--) {
            for (int j = 0; j < i; j++) {
                if (arr[j] > arr[i]) {
                    int t = arr[j];
                    arr[j] = arr[i];
                    arr[i] = t;
                }
            }
        }
    }

    private void insertionSort(int[] arr) {
        for (int i = 1; i < arr.length; i++) {
            int base = arr[i];
            int index = i - 1;
            while (index >= 0 && arr[index] > base) {
                arr[index + 1] = arr[index];
                index--;
            }
            arr[index + 1] = base;
        }
    }
}
