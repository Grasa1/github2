using System.Reflection.Metadata.Ecma335;

namespace github2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<disznok> diszok = FileManager.ReadFile("disznok2.csv");


            foreach (disznok item in diszok)
            {
                Console.WriteLine(item);
            }
            //1 feladat
            disznok legidosebb = diszok[0];
            foreach (disznok item in diszok)
            {
                if (legidosebb.age < item.age)
                {
                    legidosebb = item;
                }

            }
            Console.WriteLine($"A legidősebb malac:{legidosebb.name}");
            Console.WriteLine("--------------------------");

            //2 feladat
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


            //3 feladat
            foreach (disznok item in diszok)
            {
                if (item.gender == "kan")
                {
                    Console.WriteLine(item.ToString());
                }

            }
            Console.WriteLine("--------------------------");

            //4 feladat

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


            //5 feladat
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

            //6 feladat

            int fiuk = 0;
            foreach (disznok item in diszok)
            {

                if (item.gender == "kan")
                {
                    fiuk++;
                }
            }
            Console.WriteLine("--------------------------");
            //7 feladat
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
            //8 feladat
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


            //9 feladat

            foreach (disznok item in diszok)
            {
                if (item.name.Length % 2 == 0)
                {
                    item.Feed();
                }
            }
            Console.WriteLine("--------------------------");


            //10 feladat
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


            Console.WriteLine($"A  2 év fölöttiek atlag sulya {asd / atlag2} kg");
            Console.WriteLine("--------------------------");

            //11 feladat

            foreach (disznok item in diszok)
            {

            }
            Console.WriteLine("--------------------------");
            foreach (disznok item in diszok)
            {
                if (item.weight > (fiuhossz / fiuk))
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("--------------------------");

            //12 feladat
            Console.WriteLine($"{fiuk} kan van");
            Console.WriteLine($"{lanyok} lany van");

            //13 feladat

            double lanysuly = 0;
            foreach (disznok item in diszok)
            {
                if (item.gender != "kan")
                {
                    lanysuly += item.weight;
                }
            }
            Console.WriteLine($"A lanyok  atlag hossza {lanysuly / lanyok}");
            Console.WriteLine("--------------------------");
            foreach (disznok item in diszok)
            {
                if ((fiuhossz / fiuk) > (lanysuly / lanyok))
                {
                    Console.WriteLine("A kanok a nehezbbek");
                }
                else
                {
                    Console.WriteLine("A lányok a nehezebbek");
                }
            }
        }
    }
   
}
