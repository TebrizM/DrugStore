using DrugStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStore.Interface
{
     interface IPharmacyInterface
    {
        public DrugStores[] drugStores { get; }

        public void AddDrugStore(string Name, string Adress, string ContactNumber, string Email);

        //For Editing DrugStore
        public void EditDrugStore(string oldname, string newname, string oldAdress, string newAdress, string oldContactNumber, string newContactNumber);
    



        // Method for Adding Drug
        public void AddDrug(string Name, double Price, int Count, int DrugStoreIndex);
        //Method for Removing Drug
        public void RemoveDrug(string Name, int Count);

        //For Editing Drug
        public void EditDrug(string Name, double Price, int Count);
        // Method for Adding Owner
        public void AddOwner(string Name, string SurName);
        //Method for Removing Owner
        public void RemoveOwner(string Name);
        //For Editing Owner
        public void EditOwner(string Name, string SurName);

        public void AddDruggist(string Name, string Surname, int Age, int Experience, int DrugStoreIndex);
        public void EditDruggist(string oldName, string newName, string oldSurname, string newSurname, int oldAge, int newAge, int oldExperience, int newExperience);
        public void RemoveDruggist(string Name, string drugstoreName, string workerNo);


    



        public DrugStores[] GetDrugStores();
    }
}
