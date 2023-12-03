// See https://aka.ms/new-console-template for more information


class Result
{
    public static void miniMaxSum(List<int> arr) {

        int sum = 0;
        int minNum = 0;
        int maxNum = 0;
        List<int> evenlist = new List<int>();
        List<int> oddList = new List<int>();
        for (int i = 0; i < arr.Count; i++)
        {
               sum += arr[i];
            if (arr[i] < minNum)
                minNum = arr[i];
            if (arr[i] > maxNum)
                maxNum = arr[i];
            if (arr[i] % 2 == 0)
                evenlist.Add(arr[i]);
            if (arr[i] % 2 != 0)
                oddList.Add(arr[i]);

        }
        int minSum = sum - maxNum;
        int maxSum = sum - minNum;

        Console.WriteLine(minSum + " " + maxSum);
        Console.WriteLine("Even numbers in List " + string.Join(",",evenlist));
        Console.WriteLine("Odd numbers in List " + string.Join(",", oddList));

    }
}
