using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github2
{
    public class disznok
    {
        public string name { get; set; }
        public string gender { get; set; }
        public double weight { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return $" Neve {name} Gender: {gender}, Súlya: {weight}, Kor: {age}";
        }
        public disznok(string[] data)
        { 
            this.name = data[0].Trim(' ');
            this.gender = data[1].Trim(' ');
            this.weight = double.Parse(data[2]);
            this.age = int.Parse(data[3]);
        }
        public string Rename(string newName)
        {
            newName = name;
            return $"az uj neve:{name}";
        }
        public double Feed()
        {
            weight += (weight * 0.01);
            return weight;
        }
        }
    }
