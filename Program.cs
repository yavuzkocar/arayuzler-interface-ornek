using System;

namespace arayuzler_interface_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            focus focus=new focus();
            Console.WriteLine(focus.HangiMarkanınAracı().ToString());
            Console.WriteLine(focus.kactekerlektenolusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            civic civic=new civic();
            Console.WriteLine(civic.HangiMarkanınAracı().ToString());
            Console.WriteLine(civic.kactekerlektenolusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());
        }
    }
}
