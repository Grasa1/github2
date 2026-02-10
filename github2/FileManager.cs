using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github2
{
    internal class FileManager
    {
        static List<disznok> ReadFile(string fileName)
        {
            List<disznok> Disznok = new List<disznok>();
            try
            {
                foreach (string line in File.ReadAllLines(fileName, Encoding.UTF8).Skip(1)) 
                Disznok.Add(new disznok(line.Split(';')));
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
        }
    }
}
