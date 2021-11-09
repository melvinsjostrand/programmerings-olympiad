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
        
        Console.WriteLine("välj ett tal mellan 1 till 5");
        Console.ReadLine();
       Console.WriteLine("skriv något");
       string namn = Console.ReadLine();
       
        Console.WriteLine(StringHelper.ReverseString(namn));
        Console.WriteLine("längden på texten va " + namn.Length "bokstäver");
    }
     }
      }