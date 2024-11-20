
Console.WriteLine("Question 2.2");
void WriteToFile(string setting)
{
    using (StreamWriter output = new StreamWriter("settings.txt", true))
    {
        output.Write(setting + ",");
    }
}

string[] ReadFromFile()
{
    StreamReader reader = new StreamReader("settings.txt");

    return reader.ReadToEnd().Split(",", StringSplitOptions.RemoveEmptyEntries);
}

WriteToFile("00000000");
WriteToFile("00000010");
WriteToFile("11111111");

string[] settings = ReadFromFile();

foreach (var item in settings)
{
    Console.WriteLine(item);
}