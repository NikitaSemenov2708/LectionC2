int Max (int arg1, int arg2, int arg3)// Создали переменную Мах в
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 5;
int b1 = 7;
int c1 = 4;
int a2 = 8;
int b2 = 9;
int c2 = 1;
int a3 = 222;
int b3 = 6;
int c3 = 8;

int max1 = Max(a1, b1, c1);//int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);

Console.WriteLine(max);
