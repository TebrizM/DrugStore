using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DrugStore.Entities
{
    class DrugStores
    {
        public int Id;
        public string name;
        public string adress;
        public string contactNumber;
        public string email;
        public Druggist[] Druggists;
        public Drug[] Drugs;
        public Owner[] Owners;


        public DrugStores(string Name, string Adress, string ContactNumber, string Email)
        {
            Name = name;
            Adress = adress;
            ContactNumber = contactNumber;
            Email = email;
            Druggists = new Druggist[0];
            Drugs = new Drug[0];
            Owners = new Owner[0];



        }
        public void AddDruggist(Druggist druggist)
        {
            Array.Resize(ref Druggists, Druggists.Length + 1);
            Druggists[Druggists.Length - 1] = druggist;

        }
        public void AddDrugs(Drug drug)
        {
            Array.Resize(ref Drugs, Drugs.Length + 1);
            Drugs[Drugs.Length - 1] = drug;

        }
        public void AddOwners(Owner owner)
        {
            Array.Resize(ref Owners, Owners.Length + 1);
            Owners[Owners.Length - 1] = owner;

        }


    }
}
