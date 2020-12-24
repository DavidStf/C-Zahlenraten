using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcher Tag ist heute (1-7) eingeben: ");
      int tag = Convert.ToInt32(Console.ReadLine());
      switch(tag)
      {
        case 1:
          Console.WriteLine("Heute ist Montag");
          break;
        case 2:
          Console.WriteLine("Huete ist Dienstag");
          break;
         case 3:
          Console.WriteLine("Heute ist Mittwoch");
          break; 
         case 4:
          Console.WriteLine("Heute ist Donnerstag");
          break;
         case 5:
          Console.WriteLine("Heute ist Freitag");
          break;
         case 6:
          Console.WriteLine("Heute ist Samstag");
          break;
         case 7:
          Console.WriteLine("Heute ist Sonntag");
          break;
          //Erro else
         default:
         Console.WriteLine("Erro Tippfehler");
          break;
      }
    }
  }
}
