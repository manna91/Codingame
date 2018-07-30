using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lovak
{
    class Program
    {

        public static int Comp(int x, int y)    //osszehasonlito fuggveny
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());      //lovak száma

            int[] lovak = new int[N];

            for (int i = 0; i < N; i++)
            {
                int pi = int.Parse(Console.ReadLine());     //lovak ereje
                lovak[i] = pi;          //lovak erejét tömbbe mentem
            }

            Array.Sort(lovak);      //növekvő sorrendbe rendeztem a lovak erejét

            int[] diff = new int[N - 1];    //lovak kozti kulonbségek

            for (int i=0; i<N-1; i++)
            {
                diff[i] =Comp(lovak[i + 1], lovak[i]);   //2 szomszédos lo kulonbségét letárolom a tombbe
            }

            int min = 0;
            for (int i=0; i<N-1; i++)
            {
                if (diff[i]<diff[min])      //megkeresem a legkisebb kulonbséget
                {
                    min = i;
                }
            }
            int D = diff[min];
            Console.WriteLine(D);   //legkisebb kulonbseg kiiratása
            

            

        }
    }
}
