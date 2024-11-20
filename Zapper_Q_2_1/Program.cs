bool CheckSettings(string settings, int setting)
{
    if (settings[setting - 1].Equals('1'))
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Question 2.1");
Console.WriteLine(CheckSettings("00000000", 7));
Console.WriteLine(CheckSettings("00000010", 7));
Console.WriteLine(CheckSettings("11111111", 4));