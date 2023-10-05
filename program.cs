using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcode
 {
   public class Program
   {
     public static void Main(string[] args)
     {
 // solicitando o peso e a altura
      Console.Write("Your weight in kg: ");
      double weight = Double.Parse(Console.ReadLine());
      Console.Write("Your height in m: ");
      double height = Double.Parse(Console.ReadLine());

 // cálculo do IMC
      double imc = (weight / (height * height));
      Console.WriteLine("Seu IMC é: " + imc);
      
 // informando o estado da pessoa
      if (imc < 16) { 
         Console.WriteLine("Severe thinness"); 
       } else if (imc < 17) { 
         Console.WriteLine("Moderate thinness"); 
       } else if (imc < 18.5) { 
         Console.WriteLine("Mild thinness"); 
       } else if (imc < 25) { 
         Console.WriteLine("Normal!!!"); 
       } else if (imc < 30) { 
         Console.WriteLine("Overweight"); 
       } else if (imc < 35) { 
         Console.WriteLine("Obese class I"); 
       } else if (imc < 40) { 
         Console.WriteLine("Obese class II"); 
       } else if (imc >= 40) { 
         Console.WriteLine("Obese class III"); 
      }
     }
   }
 }
