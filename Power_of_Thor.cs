using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTX = int.Parse(inputs[2]); // Thor's starting X position
        int initialTY = int.Parse(inputs[3]); // Thor's starting Y position

        
        int actualTX = initialTX;   //Thor aktuális X helyzete
        int actualTY = initialTY;   //Thor aktuális Y helyzete    
        
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            
            if (lightX > actualTX)      //ha light keletebbre van Thor-nál
            {
                if (lightY > actualTY)  //ha light délebbre van Thornál
                {
                    Console.WriteLine("SE");
                    actualTX++;
                    actualTY++;     //Thor aktuális helyzetének beállítása
                }
                else if (lightY < actualTY)
                {
                    Console.WriteLine("NE");
                    actualTX++;
                    actualTY--;
                    
                }
                else 
                {
                    Console.WriteLine("E");
                    actualTX++;
                }
            }
            
           else if (lightX < actualTX)
           {
               if (lightY > actualTY)
               {
                   Console.WriteLine("SW");
                   actualTX--;
                   actualTY++;
                   }
              else if (lightY < actualTY)
                   {
                       Console.WriteLine("NW");
                       actualTX--;
                       actualTY--;
                       }
              else 
                   {
                       Console.WriteLine("W");
                       actualTX--;
                       }
               }
            else 
            { 
                if (lightY > actualTY)
                {
                    Console.WriteLine("S");
                    actualTY++;
                    }
                else
                {
                    Console.WriteLine("N");
                    actualTY--;
                    }
                }
            

            
        }
    }
}