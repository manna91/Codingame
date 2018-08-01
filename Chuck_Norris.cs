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
        string MESSAGE = Console.ReadLine();


        byte[] asciiMessage = Encoding.ASCII.GetBytes(MESSAGE);
           
        Array.Reverse(asciiMessage);    
        
       
        BitArray bitMessage = new BitArray(asciiMessage);   
        
        string outputMSG = "";  
        int zeroDB = 0;     
        int oneDB = 0;      
        int state = 0; 
        
        for(int i=(bitMessage.Length-1);i>=0;i--)  
        {
            if(i % 8 != 7)     
            {
                
                switch(state)
                {
                    case 0:         
                        
                        if(bitMessage[i]==true)     
                        {
                            state = 1;      
                            oneDB++;
                            if(zeroDB != 0)     
                            {
                                outputMSG += "00 ";
                                for(int z=0;z<zeroDB;z++)   
                                {
                                    outputMSG += "0";
                                }
                                outputMSG += " ";
                            }
                            zeroDB = 0;
                            if(i==0)				
                            {
                                outputMSG += "0 0";
                            }
                            
                        }
                        else
                        {
                            state = 0;
                            zeroDB++;
                            if(i==0)			
                            {
                                outputMSG += "00 ";
                                for(int z=0;z<zeroDB;z++)
                                {
                                    outputMSG += "0";
                                }
                            }
                        }
                        
                        break;
                        
                    case 1:        
                        
                        if(bitMessage[i]==true)
                        {
                            state = 1;
                            oneDB++;
                            if(i==0)				
                            {
                                outputMSG += "0 ";
                                for(int o=0;o<oneDB;o++)
                                {
                                    outputMSG += "0";
                                }
                            }
                        }
                        else        
                        {
                            state = 0;
                            zeroDB++;
                            if(oneDB != 0)
                            {
                                outputMSG += "0 ";
                                for(int o=0;o<oneDB;o++)
                                {
                                    outputMSG += "0";   
                                }
                                outputMSG += " ";
                            }
                            oneDB = 0;
                            if(i==0)			
                            {
                                outputMSG += "00 0";   
                            }
                        }
                        break;
                 
         
                }
                
            }
        }
        
        Console.WriteLine(outputMSG);
    }
}
