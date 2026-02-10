using System.Reflection.Metadata.Ecma335;

namespace github2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<disznok> diszok = FileManager.ReadFile("disznok2.csv");
            

            foreach(disznok item in diszok)
            {
                Console.WriteLine(item);
            }

            disznok legidosebb = diszok[0];
            foreach(disznok item in diszok)
            {
                if(legidosebb.age < item.age)
                {
                    legidosebb = item;
                }
               
            }
            Console.WriteLine($"A legidősebb malac:{legidosebb.name}");
            Console.WriteLine("--------------------------");

            disznok legnehezebb = diszok[0];
            foreach (disznok item in diszok)
            {
                if (legnehezebb.weight < item.weight)
                {
                    legnehezebb = item;
                }

            }
            Console.WriteLine($"A legnehezebb malac:{legnehezebb.name}");
            Console.WriteLine("--------------------------");

            foreach (disznok item in diszok)
            {
                if (item.gender == "kan")
                {
                    Console.WriteLine(item.ToString());
                }

            }
            Console.WriteLine("--------------------------");

            disznok leghosszabb = diszok[0];
            foreach (disznok item in diszok)
            {
                if (leghosszabb.name.Length < item.name.Length)
                {
                    leghosszabb = item;
                }

            }
            Console.WriteLine($"A leghosszabb malac:{leghosszabb.name}");
            Console.WriteLine("--------------------------");

            int lanyok = 0;
            foreach (disznok item in diszok)
            {
                if (item.gender != "kan")
                {
                    lanyok++;
                }
            }
            Console.WriteLine($"A lanyok szama:{lanyok}");
            Console.WriteLine("--------------------------");



            int fiuk = 0;
            foreach (disznok item in diszok)
            {
                
                if (item.gender == "kan")
                {
                    fiuk++;
                }
            }
            Console.WriteLine("--------------------------");

            double fiuhossz = 0;
            foreach (disznok item in diszok)
            {
                if (item.gender == "kan")
                {
                    fiuhossz += item.weight;
                }
            }
            Console.WriteLine($"A fiuk  atlag hossza {fiuhossz / fiuk}");
            Console.WriteLine("--------------------------");

            double lanyhossz = 0;
            foreach (disznok item in diszok)
            {
                if (item.gender == "kan")
                {
                    lanyhossz += item.age;
                }
            }
            Console.WriteLine($"A lanyok atlag kora {lanyhossz / lanyok}");
            Console.WriteLine("--------------------------");




            foreach(disznok item in diszok)
            {
                if (item.name.Length  % 2 == 0)
                {
                    item.Feed();
                }
            }
            Console.WriteLine("--------------------------");



            double atlag2 = 0;
            foreach (disznok item in diszok)
            {
                if (item.age >= 2)
                {
                    atlag2++;
                }
            }
            double asd = 0;
            foreach (disznok item in diszok)
            {
                if (item.age >= 2)
                {
                    asd += item.weight;
                }
            }


            Console.WriteLine($"A  2 év fölöttiek atlag sulya {asd/atlag2} kg");
            Console.WriteLine("--------------------------");



            foreach (disznok item in diszok)
            {

            }
            Console.WriteLine("--------------------------");
            foreach (disznok item in diszok)
            {
                if(item.weight > (fiuhossz / fiuk))
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("--------------------------");




        }
    }
   
}
