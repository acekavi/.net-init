// for (int i = 1; i <= 100; i++)
// {
//     string result = (i % 3, i % 5, i % 7) switch
//     {
//         (0, 0, _) => $"Number: {i} - FizzBuzz",
//         (0, _, _) => $"Number: {i} - Fizz",
//         (_, 0, _) => $"Number: {i} - Buzz",
//         (_, _, 0) => $"Number: {i} - Bang",
//         _ => $"Number: {i}"
//     };

//     Console.WriteLine(result);
// }

// int BinarySearch(int[] array, int target)
// {
//     int left = 0;
//     int right = array.Length - 1;

//     while (left <= right)
//     {
//         int middle = left + (right - left) / 2;

//         if (array[middle] == target)
//         {
//             return middle;
//         }

//         if (array[middle] < target)
//         {
//             left = middle + 1;
//         }
//         else
//         {
//             right = middle - 1;
//         }
//     }

//     return -1;
// }

// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// int target = 5;

// int index = BinarySearch(array, target);
// Console.WriteLine(index); // 4

void BubbleSort(int[] array)
{
    int n = array.Length;

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

int[] array = { 64, 34, 25, 12, 22, 11, 90 };
BubbleSort(array);
Console.WriteLine(string.Join(", ", array)); // 11, 12, 22, 25, 34, 64, 90