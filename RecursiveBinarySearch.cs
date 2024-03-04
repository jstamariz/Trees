namespace Trees;

class RecursiveBinarySearch
{
    public static int? Search(int[] sortedArray, int target)
    {
        int middleIndex = (int)Math.Floor((decimal)(sortedArray.Length / 2));
        int middle = sortedArray[middleIndex];

        // displying the array
        Console.WriteLine(string.Join(",", sortedArray));

        if (middle == target)
        {
            return middle;
        };

        // there's only one and it's not what I'm looking for
        if (sortedArray.Length == 1)
        {
            return null;
        }

        if (middle > target)
        {
            return Search(sortedArray.Take(middleIndex).ToArray(), target);
        }
        // midde < target
        else
        {
            return Search(sortedArray.TakeLast(middleIndex).ToArray(), target);
        }
    }
}