using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStore.Entities
{
    class Drug
    {
        public int Id;
        public string name;
        public double price;
        public int count;
   
        public Drug(string Name, double Price, int Count)
        {

            Name = name;
            Price = price;
            Count = count;
            
        
        }

    }
}
