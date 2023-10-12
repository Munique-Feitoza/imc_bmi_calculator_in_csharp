using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace IMC
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
      Console.Write("Your BMI is: " + imc + "! You're ");
      
 // informando o estado da pessoa
      if (imc < 16) { 
         Console.Write("severe thinness"); 
       } else if (imc < 17) { 
         Console.Write("moderate thinness"); 
       } else if (imc < 18.5) { 
         Console.Write("mild thinness"); 
       } else if (imc < 25) { 
         Console.Write("normal!!!"); 
       } else if (imc < 30) { 
         Console.Write("overweight"); 
       } else if (imc < 35) { 
         Console.Write("obese class I"); 
       } else if (imc < 40) { 
         Console.Write("obese class II"); 
       } else if (imc >= 40) { 
         Console.Write("obese class III"); 
      }
     }
   }
 }
