using System;

namespace storttest
{
static class StringHelper
{
    public static string ReverseString(string myStr)
    {
        char[] myArr = myStr.ToCharArray();
        Array.Reverse(myArr);
        return new string(myArr);
    }
}
 
class myProgram
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("välj hur många ord  meningen ska ha mellan 1 till 5");
        Console.ReadLine();
       Console.WriteLine("skriv något");
       string namn = Console.ReadLine();
       
        Console.WriteLine(StringHelper.ReverseString( namn +"  :rä gnineM"));
       int wordCount = 0, index = 0;

// skip whitespace until first word
while (index < namn.Length && char.IsWhiteSpace(namn[index]))
    index++;

while (index < namn.Length)
{
    // check if current char is part of a word
    while (index < namn.Length && !char.IsWhiteSpace(namn[index]))
        index++;

    wordCount++;

    // skip whitespace until next word
    while (index < namn.Length && char.IsWhiteSpace(namn[index]))
        index++;
    
}
Console.WriteLine(wordCount);
    }
    }
      }