using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Schema;

namespace OOP_Tyggegummi_Maskine
{
    class Disp
    {
        public static List<Gum> GumInDisp = new List<Gum>();
        //Is being called in the beginning and adding gum objects to a list. 
        public void AddGum()
        {
            //Gum Red = new Gum("Red", "Strawberry");
            //GumInDisp.Add(Red);

            Random rand = new Random();
            for(int i = 0; i<55; i++) 
            {
                switch (rand.Next(1,5))
                {
                    case 1:
                        GumInDisp.Add(new Gum("Red", "Strawberry"));
                        break;
                    case 2:
                        GumInDisp.Add(new Gum("Blue", "Mint"));
                        break;
                    case 3:
                        GumInDisp.Add(new Gum("Green", "Watermelon"));
                        break;
                    case 4:
                        GumInDisp.Add(new Gum("Yellow", "Lemon"));
                        break;
                    default:
                        break;
                }
            }
        }
        //DispenserGum is the primary method for removing gums, with random and manual function. 
        public void DispenseGum()
        {
            string userInput = Console.ReadLine();
            //My While loop that runs until the user exits the loop.  
            while (userInput != "9")
            {
                Console.WriteLine("What Gum would you like? Red, Blue, Green or Yellow. Type 'Random' for a surprise. Type: 'Exit' To stop\n");

                int index = 0;
                int indexTwo = 9;
                bool colourFund = false;

                userInput = Console.ReadLine().ToUpper();
                Console.WriteLine();
                if (userInput == "RANDOM")
                {
                    Random rand = new Random();

                    switch (rand.Next(1,5))
                    {
                        case 1:
                            foreach (Gum g in GumInDisp)
                            {
                                if (g.Colour.Equals("Red") && GumInDisp.Count > 0)
                                {
                                    indexTwo = index;
                                    colourFund = true;
                                }
                                index++;
                            }
                            if (colourFund)
                            {
                                Console.WriteLine("You dispensed a red gum. \n");
                                GumInDisp.RemoveAt(indexTwo);
                            }
                            else { Console.WriteLine("There are no more reds\n"); }

                            Console.WriteLine("There are " + GumInDisp.Count + " Gums left \n");
                            break;

                        case 2:
                            foreach (Gum g in GumInDisp)
                            {
                                if (g.Colour == "Blue" && GumInDisp.Count > 0)
                                {
                                    indexTwo = index;
                                    colourFund = true;
                                }
                                index++;
                            }
                            if (colourFund)
                            {
                                Console.WriteLine("You dispensed a blue gum. \n");
                                GumInDisp.RemoveAt(indexTwo);
                            }
                            else { Console.WriteLine("There are no more blues\n"); }

                            Console.WriteLine("There are " + GumInDisp.Count + " Gums left \n");
                            break;

                        case 3:
                            foreach (Gum g in GumInDisp)
                            {
                                if (g.Colour == "Green" && GumInDisp.Count > 0)
                                {
                                    indexTwo = index;
                                    colourFund = true;
                                }
                                index++;
                            }
                            if (colourFund)
                            {
                                Console.WriteLine("You dispensed a green gum. \n");
                                GumInDisp.RemoveAt(indexTwo);
                            }
                            else { Console.WriteLine("There are no more greens\n"); }

                            Console.WriteLine("There are " + GumInDisp.Count + " Gums left \n");
                            break;

                        case 4:
                            foreach (Gum g in GumInDisp)
                            {
                                if (g.Colour == "Yellow" && GumInDisp.Count > 0)
                                {
                                    indexTwo = index;
                                    colourFund = true;
                                }
                                index++;
                            }
                            if (colourFund)
                            {
                                Console.WriteLine("You dispensed a yellow gum. \n");
                                GumInDisp.RemoveAt(indexTwo);
                            }
                            else { Console.WriteLine("There are no more yellows\n"); }

                            Console.WriteLine("There are " + GumInDisp.Count + " Gums left \n");
                            break;

                        case 9:
                            userInput = "9";
                            break;

                        default:
                            Console.WriteLine("You haven't entered anything\n");
                            break;
                    }
                }
                else
                {
                    switch (userInput)
                    {
                        case "RED":
                            foreach (Gum g in GumInDisp)
                            {
                                if (g.Colour.Equals("Red") && GumInDisp.Count > 0)
                                {
                                    indexTwo = index;
                                    colourFund = true;
                                }
                                index++;
                            }
                            if (colourFund)
                            {
                                Console.WriteLine("You dispensed a red gum. \n");
                                GumInDisp.RemoveAt(indexTwo);
                            }
                            else { Console.WriteLine("There are no more reds\n"); }        
                            
                            Console.WriteLine("There are " + GumInDisp.Count + " Gums left \n"); 
                            break;

                        case "BLUE":
                            foreach (Gum g in GumInDisp)
                            {
                                if (g.Colour == "Blue" && GumInDisp.Count > 0)
                                {
                                    indexTwo = index; 
                                    colourFund = true;
                                }
                                index++;
                            }
                            if (colourFund)
                            {
                                Console.WriteLine("You dispensed a blue gum. \n");
                                GumInDisp.RemoveAt(indexTwo);
                            }
                            else { Console.WriteLine("There are no more blues\n"); }

                            Console.WriteLine("There are " + GumInDisp.Count + " Gums left \n");
                            break;

                        case "GREEN":
                            foreach (Gum g in GumInDisp)
                            {
                                if (g.Colour == "Green" && GumInDisp.Count > 0)
                                {
                                    indexTwo = index;
                                    colourFund = true;
                                }
                                index++;
                            }
                            if (colourFund)
                            {
                                Console.WriteLine("You dispensed a green gum. \n");
                                GumInDisp.RemoveAt(indexTwo);
                            }
                            else { Console.WriteLine("There are no more greens\n"); }

                            Console.WriteLine("There are " + GumInDisp.Count + " Gums left \n");
                            break;

                        case "YELLOW":
                            foreach (Gum g in GumInDisp)
                            {
                                if (g.Colour == "Yellow" && GumInDisp.Count > 0)
                                {
                                    indexTwo = index;
                                    colourFund = true;
                                }
                                index++;
                            }
                            if (colourFund)
                            {
                                Console.WriteLine("You dispensed a yellow gum. \n");
                                GumInDisp.RemoveAt(indexTwo);
                            }
                            else { Console.WriteLine("There are no more yellows\n"); }

                            Console.WriteLine("There are " + GumInDisp.Count + " Gums left \n");
                            break;

                        case "EXIT":
                            userInput = "9";
                            break;

                        default:
                            Console.WriteLine("Sorry I didn't get that\n");
                            break;
                    }
                }
            }
        }
    }
}
