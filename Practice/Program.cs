using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   string characterName = "John";
               int characterAge;
               characterAge = 35;


               Console.WriteLine("There once was a man named " + characterName);
               Console.WriteLine("He was " + characterAge + " years old"); 
               Console.WriteLine("He really like the name " + characterName);
               Console.WriteLine("But he didn't like being " + characterAge  ); */

            // if else statements

            /*  bool isMale = true;
              bool isTall = (true);

              if(isMale && isTall)
              {
                  Console.WriteLine("You are a tall male");
              } else
              {
                  Console.WriteLine("You are either not male or both");
              }*/

            // for loops
            /* int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

             for(int i = 0; i < luckyNumbers.Length; i++ )
             {
                 Console.WriteLine(luckyNumbers[i]);

             }*/

            // error handling
            /*
                        try
                        {
                            Console.WriteLine("Enter a number: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter another number: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(num1 / num2);
                        }// catching each individual exception
                        catch(DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                       catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {

                        } */

            // class and objects

            /*   Book book1 = new Book("Harry Potter", "JK Rowling", 400);           

               Book book2 = new Book("Lord Of the Rings", "Tolkein", 700);          

               Console.WriteLine(book2.title);*/

            // getters and setters
           /* Movie avengers = new Movie("The Avengers", "Josh Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Mike Myers", "PG");


            Console.WriteLine(avengers.Rating); */

            // Inheritance
            // super class
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            // sub class extending the functionality
            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeSpecialDish();

            Console.ReadLine();


        }
    }
}