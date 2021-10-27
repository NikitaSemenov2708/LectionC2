void FillArray(int[] collection) // void - функция которая не возвращает, Функция заполнения FillArray аргументом массива collection
{
int Length = collection.Length; // collection.Length - длина массива collection
int index = 0;
while (index < Length)
    {
    collection[index] = new Random().Next(1, 10); // new Random().Next(1, 10) - Рандомное число от 1 до 10
    index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int Indexof(int[] collection, int find)
{
int count = collection.Length;
int index = 0;
int position = 0;
    while (index < count)
    {
         if(collection[index] == find)
         position = index;
         
    }
    index++;
    return position;
}

int[] array = new int[10];// new int[10] - Создай новый массив в котором будет 10 элементов, он будет наполнен нулями

FillArray(array);
array[2]=4;
array[5]=4;

PrintArray(array);
Console.WriteLine();

int pos = Indexof(array, 4);
Console.WriteLine(pos);