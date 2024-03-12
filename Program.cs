int[] array = { 2, 4, 1, 6, 7 };
string[] words = { "car", "home", "result", "total", "variable", "vision" };

Methods.SortNumbers(array);
//Methods.FindWord(words, 'v');
//Methods.ReverseArray(array);
class Methods
{
    // TASK-1
    public static void SortNumbers(int[] array)
    {
        int[] tempArray = { };
        int minNum;
        for (int i = 0; i<array.Length; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i]>array[j])
                {
                    minNum = array[i];
                    array[i]=array[j];
                    array[j]=minNum;
                }
            }
            Array.Resize(ref tempArray, tempArray.Length+1);
            tempArray[tempArray.Length-1] = array[i];
        }
        foreach (int num in tempArray)
        {
            Console.WriteLine(num);

        }
    }

    // TASK-2
    public static void FindWord(string[] array, char ch)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                if (array[i][j] == ch)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }

    // TASK-3

    public static void ReverseArray(int[] array)
    {
        int[] tempNums = { };
        for (int i = array.Length-1; i >= 0; i--)
        {
            Array.Resize(ref tempNums, tempNums.Length+1);
            tempNums[tempNums.Length-1] = array[i];
        }
        foreach (int num in tempNums)
        {
            Console.WriteLine(num);
        }
    }
}
