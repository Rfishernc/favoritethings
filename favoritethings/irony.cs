using System;
using System.Collections.Generic;
using System.Text;

namespace favoritethings
{
    class Irony
    {
        public IronyType Type { get; set; }
        public string Description { get; set; }

        public void IsntItIronic()
        {
            Console.WriteLine("Its like rayaaaaiinnnn on your wedding day");
        }
        public void WriteLine()
        {
            Console.WriteLine("Console.ReadLine()");
        }
    }
    
    enum IronyType
    {
        Verbal,
        Situational,
        Dramatic
    }
}
