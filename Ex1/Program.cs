int[] array = {1,2,3,4,5,6,7,8,9,10,4,11,12,13,14,15};

int size = array.Length;
int find = 4;

int index = 0;

while (index < size)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}