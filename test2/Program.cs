using System;
using System.IO;
using System.Text;

public class TextInput
{
    private string value;
    private StringBuilder builder;

    public TextInput()
    {
        builder = new StringBuilder();        
    }
    public virtual void Add(char c)
    {
        builder.Append(c);
        value = builder.ToString();
    }
    public string GetValue()
    {
        return value;
    }
}

public class NumericInput:TextInput
{
    public  override void Add(char c)
    {
        if (Char.IsDigit(c))
        {
            base.Add(c);
        }
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add(' ');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}