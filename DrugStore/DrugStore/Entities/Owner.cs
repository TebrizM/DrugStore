using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DrugStore.Entities
{
    class Owner
    {
        public int Id;
        public string name;
        public string surName;
        public string drugStoreName;

        public DrugStores[] drugStores;

        public Owner(string Name, string SurName, DrugStores drugstoreName)
        {

            Name = name;
            SurName = surName;
            drugStoreName = drugstoreName.name;
   


        }
    }
}
