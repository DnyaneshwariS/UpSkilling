using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first string");
        string a=Console.ReadLine();
         Console.WriteLine("Enter the second string");
        string b=Console.ReadLine();
           string reversedString = null; 
     for(int i = b.Length - 1; i >= 0; i--) 
    { 
         
        reversedString += b[i]; 
    }
      if(a.Equals(reversedString))
      {
          Console.WriteLine("Both are reversed");
      }
      else
      {
                Console.WriteLine("Both are not reversed");
      }
        
    }

}