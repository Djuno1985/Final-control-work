Console.Write("Введите строки через запятую: ");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(',');

        string[] resultArray = FilterStrings(inputArray);

        Console.WriteLine("Результат:");
        foreach (string result in resultArray)
        {
            Console.WriteLine(result);
        }