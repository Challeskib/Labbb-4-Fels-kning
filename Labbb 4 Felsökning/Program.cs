using System;

namespace Labbb_4_Felsökning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case 1
            
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre"); //Här fattades semikolon för att avsluta satsen
            }
            else if(number < 3) //Else if ska särskrivas
            {
                Console.WriteLine("Talet är mindre än tre");
            }


            

            //Case 2
            /*
            for (int i = 1; i <= 100; i++) //For-loopen körs endast när index är MINDRE än 100. Ändra från < till <=.
            {
                Console.WriteLine(i);
            }
            */

            //Case 3
            /*
            for (int i = 1; i <= 5; i++) //Fel på syntax. Saknas förändringsfaktor. 
            {
                for (int j = 1; j <= i; j++)//Fel på syntax. Saknas förändringsfaktor. 
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            */

            //Case 4
            /*
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); //Metoden Console.Write behöver input för att kunna printa output
                } 

                Console.WriteLine();
                i++;
            }
            */

            //Case 5
            /*
            int i = 1;

            switch (i)
            {
                case 1:
                    break;
                    //Det saknas break i case 1 vilket gör att compiler hoppar över hela caset och går direkt till case 2.
                    //break funktion är till för att stoppa exekveringen av kvarvarande kod i kodblocket.
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            */
            /*
            int i = 10;

            if (i == 5) // Endast ett likamedtecken(=) använder man till tilldelning, men i detta fallet vill vi ha (==) en jämförelseoperator för att koden skall funka. 
            {
                Console.WriteLine("i är 5");
            }
            */
        }
    }
}
