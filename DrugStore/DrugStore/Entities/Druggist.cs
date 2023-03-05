using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DrugStore.Entities
{
    class Druggist
    {
        private static int _no = 1000;
        public string No;
       
        public string name; 
        public string surname;
        public int age;
        public int experience;
        public DrugStores drugStore;


        public Druggist(string Name, string Surname, int Age, int Experience, DrugStores DrugStores)
        {
            _no++;
            Name = name;
            Surname = surname;
            Age = age;
            Experience = experience;
            DrugStores = drugStore;
            No = drugStore.name.Substring(0, 2).ToUpper() + _no;

        }
    }
}
