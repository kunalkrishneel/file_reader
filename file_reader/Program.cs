// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

  string filePath = "data.txt";
        using (StreamReader reader = new StreamReader(filePath))
        {
            string content = await reader.ReadToEndAsync();
            Console.WriteLine(content);
        }