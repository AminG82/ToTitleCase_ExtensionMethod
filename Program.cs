// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//this will create an extension method to extend String!


string test ="hello world! this is a test string.";

Console.WriteLine(test.ToTitleCase());
public static class StringExtend
{
    public static string ToTitleCase(this string input)
    {
        if(string.IsNullOrWhiteSpace(input))
            return input;

        var words = input.Split(' ' , StringSplitOptions.RemoveEmptyEntries);
        for (int i  = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }
        var result = string.Join(" ", words);
        return result;
    }
}
