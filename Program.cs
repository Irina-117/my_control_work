string[] str = new string[6] { "Hello", "my", "^-^", "21", "!&!", "world" };
string[] str2 = new string[str.Length];
void FillingSecondStr(string[] str, string[] str2)
{
    int k = 0;
    for (int i = 0; i < str.Length; i++)
    {

        if (str[i].Length <= 3)
        {
            str2[k] = str[i];
            k++;
        }
    }
}
void PrintStr(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        System.Console.Write($"{str[i]} ");
    }
    System.Console.WriteLine();
}

FillingSecondStr(str, str2);
PrintStr(str2);