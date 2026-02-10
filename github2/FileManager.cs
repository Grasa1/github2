using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github2
{
     public class FileManager
    {
        public static List<disznok> ReadFile(string fileName)
        {
            List<disznok> Disznok = new List<disznok>();
            try
            {
                foreach (string item in File.ReadAllLines(fileName, Encoding.UTF8).Skip(1)) 
                Disznok.Add(new disznok(item.Replace('.',',').Split(';')));
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
            return Disznok;
        }
    }
}
