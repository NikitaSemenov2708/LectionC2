int[] array = {1,12,33,19,52,16,27,88,19};

int n = array.Length;// определяет длину массива
int find = 19;

int index = 0;

while (index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}