#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <stdbool.h>

#define MAXSIZE 100
#define N 10

// 定义顺序表结构体
typedef struct {
    int *data;
    int length;
    int capacity;
} SqList;

// 申明函数
SqList* InitList(int capacity);
void DestroyList(SqList *list);
bool Random(int *a, int n, int min, int max);
bool CreateList(SqList *list, const int a[], int n);
bool InsertList(SqList *list, int index, int value);
bool DeleteList(SqList *list, int index);
int SearchList(SqList *list, int value);
void PrintList(SqList *list);
bool IsEmptyList(SqList *list);
bool IsFullList(SqList *list);
int main(void)
{
    int a[N];
    int choice, index, value;
    SqList *list;
    list = InitList(MAXSIZE);
    // 生成随机数据
    Random(a, N, 1, 100)
    // 创建顺序表
    CreateList(list, a, N)
    do {
        printf("\n1. 显示顺序表\n");
        printf("2. 插入元素\n");
        printf("3. 删除元素\n");
        printf("4. 查找元素\n");
        printf("0. 退出\n");
        printf("请选择操作: ");
        scanf("%d", &choice);
        switch (choice) {
            case 0:
                DestroyList(list);
                break;
            case 1:
                PrintList(list);
                break;
            case 2:
                printf("请输入您想插入的位置:");
                scanf("%d", &index);
                printf("请输入您想插入的值:");
                scanf("%d", &value);
                if (InsertList(list, index, value)) {
                    printf("插入成功\n");
                    PrintList(list);
                } else {
                    printf("插入失败\n");
                }
                break;
            case 3:
                printf("请输入您想删除的位置:");
                scanf("%d", &index);
                if (DeleteList(list, index)) {
                    printf("删除成功\n");
                    PrintList(list);
                } else {
                    printf("删除失败\n");
                }
                break;
            case 4:
                printf("请输入要查找的值:");
                scanf("%d", &value);
                index = SearchList(list, value);
                if (index != -1) {
                    printf("找到元素,位置为: %d\n", index);
                } else {
                    printf("未找到该元素\n");
                }
                break;
        }
    } while (choice != 0);
    DestroyList(list);
    return 0;
}

// 初始化顺序表
SqList *InitList(int capacity) {
    SqList *list;
    list = malloc(sizeof(SqList));
    list->data = (int*)malloc(sizeof(int) * capacity);
    list->length = 0;
    list->capacity = capacity;
    return list;
}

// 销毁顺序表
void DestroyList(SqList *list) {
    if (list) {
        free(list->data);
        free(list);
    }
}

// 随机数生成器
bool Random(int *a, int n, int min, int max) {
    srand(time(NULL));
    if (!a || n <= 0 || min > max) {
        return false;
    }
    for (int i = 0; i < n; i++) {
        a[i] = rand() % (max - min) + min;
    }
    return true;
}

// 创建顺序表
bool CreateList(SqList *list, const int a[], int n) {
    if(!list || !a || n <= 0 || n > list->capacity) {
        return false;
    }
    for (int i = 0; i < n; i++) {
        list->data[i] = a[i];
    }
    list->length = n;
    return true;
}

// 插入元素
bool InsertList(SqList *list, int index, int value) {
    if (!list || index < 1 || index > list->length || list->length >= list->capacity) {
        return false;
    }
    int idx = index - 1;
    // 移动元素
    for (int i = list->length; i >= idx; i--) {
        list->data[i] = list->data[i - 1];
    }
    list->data[idx] = value;
    list->length++;
    return true;
}

//删除元素
bool DeleteList(SqList *list, int index) {
    if (!list || index < 1 || index > list->length) {
        return false;
    }
    int idx = index - 1;
    printf("被删除的数为%d\n", list->data[idx]);
    // 移动元素
    for (int i = idx; i < list->length; i++) {
        list->data[i] = list->data[i + 1];
    }
    list->length--;
    return true;
}

// 查找元素
int SearchList(SqList *list, int value) {
    if(!list) {
        return -1;
    }
    for (int i = 0; i < list->length; i++) {
        if (list->data[i] == value) {
            return i + 1;
        }
    }
    return  -1;
}

// 打印顺序表
void PrintList(SqList *list) {
    if (!list) {
        printf("Empty list\n");
    }
    if (list->length == 0) {
        printf("顺序表为空\n");
    }

    printf("顺序表元素: ");
    for (int i = 0; i < list->length; i++) {
        printf("%d ", list->data[i]);
    }
    printf("\n");
}

// 判断顺序表是否为空
bool IsEmptyList(SqList *list) {
    return (list->length == 0);
}

// 判断顺序表是否已满
bool IsFullList(SqList *list) {
    return (list->length >= list->capacity);
}