Console.Write("Введите строки через запятую: ");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(',');

        string[] resultArray = FilterStrings(inputArray);

        Console.WriteLine("Результат:");
        foreach (string result in resultArray)
        {
            Console.WriteLine(result);
        }

        static string[] FilterStrings(string[] inputArray)
    {
        int resultCount = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (IsShortString(inputArray[i]))
            {
                resultCount++;
            }
        }
