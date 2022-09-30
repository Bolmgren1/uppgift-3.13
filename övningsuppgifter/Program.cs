using System;
namespace inlämningsuppgift
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur gammal är du?");
            Console.WriteLine("Svara här");          int ålder = int.Parse(Console.ReadLine());


            if (ålder <19 && ålder >16  )
            {
                Console.WriteLine("Du får delta i denna tävlingen");



            }
             
            else
            {
                Console.WriteLine("Du får inte delta i tävlingen");
                

            }




        }







    }







}