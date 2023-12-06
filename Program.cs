using System; 
namespace UsingOperator 
{ 
class Program 
     { private static void Main(string[] args) 

    { 
    float width; float height; Console.Write("Enter width: 4"); 
    width = float.Parse(Console.ReadLine()); 
    Console.Write("Enter height: 5"); 
    height = float.Parse(Console.ReadLine()); 
    float area =  width * height;
    Console.WriteLine("Area is: " + area); 
    } 
 } 
 
 }