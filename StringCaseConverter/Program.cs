// See https://aka.ms/new-console-template for more information

using System.Text;



static string CamelToKebab(string input)
{
    StringBuilder sb = new StringBuilder();

    foreach (var currentChar in input)
    {
        if (char.IsUpper(currentChar))
        {
            sb.Append('-');
            sb.Append(char.ToLower(currentChar));
        }
        else
        {
            sb.Append(currentChar);
        }

       
    }
    return sb.ToString();
}

Console.WriteLine("Please write variable in camelCase");
string input = Console.ReadLine();

Console.WriteLine(CamelToKebab(input));


static string KebabToCamel(string input2)
{
    StringBuilder sb = new StringBuilder();
    foreach (var currentChar in input2)
    {
        if (currentChar != '-')
        {
            sb.Append(currentChar);

        }
        else
        {
            sb.Replace('-', char.ToUpper(currentChar));
            
        }
    }

    return sb.ToString();
}

Console.WriteLine("Please write variable in kebabCase");
string input2 = Console.ReadLine();

Console.WriteLine(KebabToCamel(input2));