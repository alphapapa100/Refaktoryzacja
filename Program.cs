using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Osoba;

namespace ConsoleApp11
{
    internal class Program
    
    {
        static Osoba wczytajOsobe()
        {
            Console.WriteLine("Podaj imie osoby");
            string imie_ = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko osoby");
            string nazwisko_ = Console.ReadLine();
            Console.WriteLine("Podaj wiek osoby");
            int wiek_ = Convert.ToInt32(Console.ReadLine());
            return new Osoba(imie_, nazwisko_, wiek_);
           
        }
        static string Writeline(string s )
            {
            Console.WriteLine("-------------------------------");
            Console.WriteLine(s);
            Console.WriteLine("-------------------------------");
            return Console.ReadLine();
            }
        static void Main(string[] args)
        {
            Osoba gracz = wczytajOsobe();
            Console.WriteLine("Gotowy?\n"+gracz.Imie_);
            bool tak = true;
            while (tak)
            {
                Console.WriteLine("Tak- a|||Nie- b");
                string inp = Console.ReadLine();
                if (inp == "a")
                {
                    Writeline("Tak to zaczynamy");
                }
                else if (inp == "b")
                {
                    Writeline("Wróć jak będzisz gotoyw");
                    return;

                }
                string inp1 = Writeline("Wchodzisz do szkoły, wchodzisz do sztni?\n"+ "Tak- a|||Nie- b");
                if (inp1 == "a")
                {
                    Writeline("Zmieniasz buty i idzesz do sali");
                }
                else if (inp1 == "b")
                {
                    Writeline("woźna złapała cie, że nie zmieniłeś butów\n"+
                        "zostałeś wyrzucony ze szkoły\n"+ "może teraz isć do domu sie wyspać\n"+"pa pa");
                    return;
                }
                string inp2 = Writeline("Do jakiej sali idzisz\n"+ "Od geografi- a|||Od matmy- b|||Od chemi- c");
                if (inp2 == "a")
                {
                    string inp3 = Writeline("Wchodizsz do sali i się dowiadujesz że jest kartkóka\n"+ "Zaczynasz się uczyć?\n"+ "Tak- a|||Nie- b");
                    if (inp3 == "a")
                    {
                        Writeline("Dobra decyzja dostałeś 5 \n" + "na spokojnie raczej dostaniesz obiad");
                    }
                    else if (inp3 == "b")
                    {
                        Writeline("Oj to była załda decyzja bo dostałeś 1\n" + "mama będzie zła\n" + "lepiej uciekaj");
                        return;
                    }
                }
                else if (inp2 == "b")
                {
                    Writeline("Zapomniałeś, że jest sprawdzan\n" + "dlatego uciekłeś do domu żeby nie dostać 1");
                    return;
                }
                else if (inp2 == "c")
                {
                    string inp4 = Writeline("W sali wybuchł pożar\n" + "Pomagasz ugasić- a|||Ratujesz włąsny tyłek- b");
                    if (inp4 == "a")
                    {
                        Writeline("Brawo wszyscy przeżyli i są szczęsliwi\n" + "Gratulacje "+gracz.Imie_ +" "+gracz.Nazwisko_+ " dzięki tobie inni uczniowie przeżyli." );
                    }
                    else if (inp4 == "b")
                    {
                        Writeline("Przeżyłeś, ale reszta klasy spłoneła\n" + "szuka cie policja lepiej uciekaj");
                        return;
                    }
                }
                Writeline("Udało ci sie przetrwać szkołe\n" + "ze spokojem możesz iśc do domu");
                return;
            }
        }
    }
}