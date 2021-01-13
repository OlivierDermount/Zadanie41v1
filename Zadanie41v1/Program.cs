using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie41v1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Podaj liczbę," +
                        " której chcesz sprawdzić parzystość");

                    var liczbaInt = int.Parse(Console.ReadLine());
                    var modulo = liczbaInt % 2;

                    var parzystosc = (modulo == 0) ? "liczba parzysta" : "liczba nieparzysta";
                    Console.WriteLine(
                        $"Podana przez Ciebie liczba {liczbaInt} jest {parzystosc}\n \n" +
                          "Chcesz sprawdzić następną liczbę ?\n\n" +
                          "Wciśnij dowolny klawisz aby kontynuować\n" +
                          "lub n aby wyjść z programu");
                    var takLubNie = Console.ReadLine();
                    Console.Clear();

                    if (takLubNie == "n") break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
