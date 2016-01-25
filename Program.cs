using System;
using System.IO;
using System.Text;

public class CharsFromStr
{
    private static int b;

    public static void Main()
    {
        // this is your string 
        string MyString = "hello world!";
        char[] MyChar = {'a', 'e', 'i', 'o', 'u'};
        //this should trim the stirng 
        string NewString = MyString.Trim(MyChar);
        Console.WriteLine(NewString);

        //this wtill give the ASCII vlaue 
        byte[] ASCIIValues = Encoding.ASCII.GetBytes(MyString);
        foreach (byte b in ASCIIValues)
        // this will detemrine the vowels based on the ASCII value 
        if (b == 97 || b == 101 || b == 105 || b == 111 || b == 117)
        
        // this write the lower case vowels on the console
        {
            Console.WriteLine(b);
            string c = Char.ConvertFromUtf32(b-32);
            Console.WriteLine(c);
            
        }
        else
            {
                String c = Char.ConvertFromUtf32(b);
                Console.WriteLine(c);
            }
    }
}



