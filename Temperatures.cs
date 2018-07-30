using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526

        
        if (n==0)       
        {
            Console.WriteLine("0");     //Ha üres a tömb, írjon ki 0-t
        }
        else
        {
            string[] splitTemps = temps.Split(' ');     //szóköz mentén elválasztom a hőmérsékletértékeket
            int[] intTemps= new int[n];         //létrehozok n elemszámú egész számokból álló tömböt
            int negDb=0;
            int pozDb=0;
            
            for (int i=0; i<n; i++)
            {
                intTemps[i]=Convert.ToInt32(splitTemps[i]);   //sztringet intté konvertálom
               
                if (intTemps[i]<0)              //megszámolom a negatív számokat
                {
                    negDb++;
                }
                if (intTemps[i]>0)
                {
                    pozDb++;                //megszámolom a pozitiv számokat
                }
            }
            int[] negTemps=new int [negDb];
            int[] pozTemps=new int [pozDb];
            
            negDb = 0;
            pozDb = 0;
            
            for (int i=0; i<n; i++)
            {
                  
                if (intTemps[i]<0)
                {
                    negTemps[negDb]=intTemps[i];        //feltöltöm a tömböt a negatív hőmérséklet értékekkel
                    negDb++;
                    
                }
                if (intTemps[i]>0)
                {
                    pozTemps[pozDb]=intTemps[i];        //feltöltöm a tömböt a pozitiv hőmérséklet értékekkel
                    pozDb++;
                    
                }
               
            }
            
            
            int max=0, min=0;
            
            for (int i=0; i<negDb; i++)                 //megkeresem a 0-hoz legközelebb eső negatív számot
            {
                if (negTemps[i]> negTemps[max])
                {
                    max=i;
                }
                
            }
            
                
            for (int i=0; i<pozDb; i++)             //megkeresem a 0-hoz legközelebb eső pozitív számot
            {
                if (pozTemps[i]<pozTemps[min])
                {
                    min=i;
                }
            }
            
           
            
            if (pozDb !=0 && negDb!=0)          //Ha van negatív és pozitív hőmérsékletérték ...
            {
                  int negMax = (negTemps[max])*(-1);  //vegye a 0-hoz legközelebb eső negatív szám abszolút értékét...
				 
				  if (negMax < pozTemps[min])          //hasonlítsa össze a 0-hoz legközelebb eső pozitív számmal
                  {
                       Console.WriteLine(negTemps[max]);
                  }
                  else if (negMax > pozTemps[min])
                  {
                       Console.WriteLine(pozTemps[min]);
                   }
                  else
                  {
                      Console.WriteLine(pozTemps[min]);    //Írja ki a két szám közül a 0-hoz közelebbit
                  }
            }
            else if (pozDb==0 && negDb!=0)
            {
                Console.WriteLine(negTemps[max]);       //Ha csak negatív hőmérsékletérték van, írja ki a 0-hoz közelebb eső neg. számot
            }
            else if (pozDb!=0 && negDb==0)
            {
                Console.WriteLine(pozTemps[min]);   //Ha csak pozitív hőmérsékletérték van, írja ki a 0-hoz közelebb eső poz. számot
            }
           
            
                
                
        }
        
   
    }
}