sing System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Player
{
    static void Main(string[] args)
    {

        int [] mountains = new int[8];
        int max =0;

        
        
        while (true)
        {
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // egy hegynek a magassága
                mountains[i]=mountainH;                        // a hegyek magasságát tömbbe mentem

                
                 if (mountains[max] < mountains[i])
                    {
                       max=i;
                        
                    }
                
            }
                
           
            Console.WriteLine(max);
            max=0;
           

            
        }
    }
}