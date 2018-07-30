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
        string[] inputs;
        int surfaceN = int.Parse(Console.ReadLine()); //a Mars felszínének rajzolásához használt pontok száma
        for (int i = 0; i < surfaceN; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int landX = int.Parse(inputs[0]); // X szélesseg (0 to 6999) 
            int landY = int.Parse(inputs[1]); // Y magassag Ha egymás után összekapcsoljuk az összes pontot, akkor a Mars felszínét alkotja
        }


        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);
            int hSpeed = int.Parse(inputs[2]); // the horizontal speed (in m/s), can be negative. ezzel most nem kell folalkoznunk
            int vSpeed = int.Parse(inputs[3]); // függőleges sebesség m/s-ban (lehet negativ is) nem lehet > abs. ertek 40 , ha lefele megy negativ, ha fel pozitiv
            int fuel = int.Parse(inputs[4]); // uzemanyag hatralevo mennyisége literben
            int rotate = int.Parse(inputs[5]); // the rotation angle in degrees (-90 to 90). ez sem érdekes most
            int power = int.Parse(inputs[6]); // the thrust power (0 to 4). toloero

            if (vSpeed <= -35)
            {
                power++;
            }

            if (power<0)
            {
                power=0;
            }
            if (power>4)
            {
                power=4;
            }
            
            // output: 2 int, rotate mindig 0, thrustpower- minden korben max eggyel modosithatjuk
            
            Console.WriteLine("{0} {1}", rotate, power);
        }
    }
}