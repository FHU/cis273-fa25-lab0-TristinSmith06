namespace MergeArrays;

public class Program
{
    public static void Main(string[] args)
    {
        int[] test = { 1, 6, 7, 10 };
        int[] test2 = { 2, 3, 11, 14 };
        
        foreach (var item in MergeSortedArrays(test, test2))
        {
            System.Console.WriteLine(item);
        }
    }

    // TODO 
    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        List<int> list1 = new List<int>(array1);
        List<int> list2 = new List<int>(array2);



        List<int> final = new List<int>();
        


        while (final.Count != array1.Length + array2.Length)
        {
            if (list1.Count != 0 && list2.Count != 0) // if both lists still have elements
            {

                if (list1[0] <= list2[0]) //add 1st element of list 1 if smaller than list 2 and delete from list 1
                {

                    System.Console.WriteLine($"{list1[0]} is less than {list2[0]}, adding {list1[0]}, to final");
                    final.Add(list1[0]);
                    list1.RemoveAt(0);
                    System.Console.WriteLine($"Sorted list currently is {final.Count}");
                }
                else if (list1[0] >= list2[0]) //add 1st element of list 2 if smaller than list 1 and delete from list 2
                {
                    System.Console.WriteLine($"{list2[0]} is less than {list1[0]}, adding {list2[0]}, to final");
                    final.Add(list2[0]);
                    list2.RemoveAt(0);
                    System.Console.WriteLine($"Sorted list currently is {final.Count}");
                }
            }
            else
            {
                if (list1.Count == 0) //one of the two arrays is empty, slap on the remaining array to final
                {
                    final.AddRange(list2);
                }
                else if (list2.Count == 0)
                {
                    final.AddRange(list1);
                }
            }


        }


        return final.ToArray();
    }

    // TODO 
    private static bool IsSorted(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1) //end reached
            {
                return true;
            }

            if (array[i] > array[i + 1]) //next element is smaller
            {
                return false;
            }
        }
        return true;
    }
}

