using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();


        byte[] asciiMessage = Encoding.ASCII.GetBytes(MESSAGE);
           
        Array.Reverse(asciiMessage);    //byte tömb megfordítása
        
       
        BitArray bitMessage = new BitArray(asciiMessage);   //byte tömb átkonvertálása bináris tömbbé (lsb first - először a legkisebb helyiértékű bitet írja ki)
        
        string outputMSG = "";  //kimeneti üzenet
        int zeroDB = 0;     //0-k számolása
        int oneDB = 0;      //1-ek számolása
        int state = 0;  //állapotváltozó
        
        for(int i=(bitMessage.Length-1);i>=0;i--)   //hátulról megyünk végig a tömb elemein (msb first), így helyes lesz a byte sorrend és a bit sorrend is
        {
            if(i % 8 != 7)      //az egyes byte-oknál az msb-t nem vesszük figyelembe, mivel az ASCII karakter 7 bites
            {
                
                switch(state)
                {
                    case 0:         // előző bit "0" volt (vagy most dolgozzuk fel az első bitet)
                        
                        if(bitMessage[i]==true)     //a mostani bit "1"
                        {
                            state = 1;      //beállítom az állapotot 1-re
                            oneDB++;
                            if(zeroDB != 0)     //ha már olvastunk be "0"-t
                            {
                                outputMSG += "00 ";
                                for(int z=0;z<zeroDB;z++)   //zeroDB darab 0-t hozzáadok a kimeneti sztringhez
                                {
                                    outputMSG += "0";
                                }
                                outputMSG += " ";
                            }
                            zeroDB = 0;
                            if(i==0)				// utolsó "1"-es kiírása
                            {
                                outputMSG += "0 0";
                            }
                            
                        }
                        else
                        {
                            state = 0;
                            zeroDB++;
                            if(i==0)			// maradék "0"-k kiírása
                            {
                                outputMSG += "00 ";
                                for(int z=0;z<zeroDB;z++)
                                {
                                    outputMSG += "0";
                                }
                            }
                        }
                        
                        break;
                        
                    case 1:         // előző bit "1" volt
                        
                        if(bitMessage[i]==true)
                        {
                            state = 1;
                            oneDB++;
                            if(i==0)				// maradék "1"-esek kiírása
                            {
                                outputMSG += "0 ";
                                for(int o=0;o<oneDB;o++)
                                {
                                    outputMSG += "0";
                                }
                            }
                        }
                        else        //előző bit "1", és most "0"-t kaptunk
                        {
                            state = 0;
                            zeroDB++;
                            if(oneDB != 0)
                            {
                                outputMSG += "0 ";
                                for(int o=0;o<oneDB;o++)
                                {
                                    outputMSG += "0";   //ha volt "1"-es, akkor azokat kiiratjuk
                                }
                                outputMSG += " ";
                            }
                            oneDB = 0;
                            if(i==0)			
                            {
                                outputMSG += "00 0";    //utolsó "0" kiírása
                            }
                        }
                        break;
                 
         
                }
                
            }
        }
        
        Console.WriteLine(outputMSG);
    }
}