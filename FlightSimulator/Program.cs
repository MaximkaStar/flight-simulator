using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            WriteLine("Plane prepaired of flight...");
            WriteLine("Engine need to be started. To do this, please, wtite Start. ");
            string start = ReadLine();
            if (start == ReadLine())
            {
                WriteLine("Engine has been started successful.");
            }
            else
            {
                WriteLine("Engine hasn't been started successful. Please, try again.");

            }
            WriteLine("Dispach was been connected.");
            Dispach dispach = new Dispach();
            WriteLine("Please, enter ammout of dispaches, who you want to use.");
            ReadLine(dispach.howDispaches);
            if (dispach.howDispaches > 2)
            {
                WriteLine("You are ready for the flight.");
            }
            else
            {
                WriteLine("You are not ready for the flight. Please, try again.");
            }
            Wheater wheater = new Wheater();
            public delegate void Wheater(Wheater);
        public event Wheater(Wheater)
    }
           
    }
    }
}
