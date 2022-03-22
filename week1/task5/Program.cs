// 5. Arrays

// Given an integer array as an input, if the length of the array is not even write the warning message, otherwise split the array in half and add both resulting arrays together and write the result.

int[] input = new[] { 1, 2, 5, 7, 2, 3, 5, 7 };
int[][] splitArray = Split(input);
int[] result = AddArray(splitArray);
WriteResult(result);

int[][] Split(int[] array)
{

    if (input.Length % 2 != 0)
    {
        System.Console.WriteLine(" Array length should not be singular ");
    }

    int[] firstArray = array.Take(array.Length / 2).ToArray();
    int[] secondArray = array.Skip(array.Length / 2).ToArray();
    return new int[][] { firstArray, secondArray };
}

int[] AddArray(int[][] jaggedArray)
{
    int[] firstArray = jaggedArray[0];
    int[] secondArray = jaggedArray[1];
    int[] result = new int[firstArray.Length];
    for (int i = 0; i < firstArray.Length; i++)
    {
        result[i] = firstArray[i] + secondArray[i];
    }
    return result;
}

void WriteResult(int[] result)
{
    Console.WriteLine("[{0}]", String.Join(", ", result));
}

