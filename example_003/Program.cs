int Max (int arg1, int arg2, int arg3)// Создали переменную Мах в
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {1,12,33,14,52,16,27,88,19};// Создание массива int[] array = { число1, число2, ....числоN }
array[0]=12;
Console.WriteLine(array[0]);

int result = Max(
Max(array[0], array[1], array[2]), 
Max(array[3], array[4], array[5]), 
Max(array[6], array[7], array[8])
);
Console.WriteLine(result);

