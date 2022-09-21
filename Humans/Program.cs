using System;

string[] names = GetLines();
Print(names);

/*string[] array = new string[1] { "" };
Console.WriteLine("{0},{1},{2},{3},{4}",array[1], array[2], array[3], array[4], array[5]);
*/
string[] GetLines()
{
    string text = File.ReadAllText("D://russian_surnames.csv");
    string[] names = text.Split('\n');
    return names;
}

void Print(string[] lines)
{
    for (int i = 1; i < lines.Length; i++)
    {
            string[] arrays = lines[i].Split(';');
        if (arrays.Length == 6)
            Console.WriteLine($"{arrays[1]}");
    }
}