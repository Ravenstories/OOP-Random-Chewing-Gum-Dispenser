using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tyggegummi_Maskine
{
    class Program
    {
        static void Main(string[] args)
        {
            Disp disp = new Disp();
            disp.AddGum();
            Program enterCoin = new Program();

            Console.WriteLine("Hallo! Please enter a coin:");
            enterCoin.EnterCoin();
            Console.WriteLine("End of program");
            Console.ReadLine();
        }
        //Method that asked for a coin. It has to be exactly 5. When true, it will send to dispenser method in Disp class. 
        void EnterCoin()
        {
            Disp disp = new Disp();
            int x = 0;
            int coin;
            
            while (x != 100) 
            { 
                string line = Console.ReadLine();
                if (int.TryParse(line, out coin))
                {
                    x = coin;
                    if(coin < 5)
                    {
                        Console.WriteLine("You need a bigger coin!");
                    } else if (coin > 5)
                    {
                        Console.WriteLine("Your coin is to big!");
                    }else if (coin == 5) 
                    { 
                        disp.DispenseGum();
                        x = 100;
                    } 
                }
                else
                {
                    Console.WriteLine("Not a coin!");
                }
            }
        }

    }
}
