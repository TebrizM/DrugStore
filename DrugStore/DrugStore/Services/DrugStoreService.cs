using DrugStore.Entities;
using DrugStore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DrugStore.Services
{
    class DrugStoreService : IPharmacyInterface
    {

        private DrugStores[] _drugstores;
        public DrugStores[] drugStores => _drugstores;

        public DrugStoreService()
        {
            _drugstores = new DrugStores[0];
        }
      


        #region Drugstore
            public void AddDrugStore(string Name, string Adress, string ContactNumber, string Email)
            {
                    DrugStores drugStores = new DrugStores(Name, Adress, ContactNumber,Email);
                    Array.Resize(ref _drugstores, _drugstores.Length + 1);
                     _drugstores[_drugstores.Length - 1] = drugStores;
                    Console.WriteLine("DrugStores added Successfully :");
            }
          
            public void EditDrugStore(string oldname, string newname, string oldAdress, string newAdress, string oldContactNumber, string newContactNumber)
            {
                foreach (DrugStores item in drugStores)
                {
                        if (item.name == oldname)
                        {

                        item.name = newname;
                        Console.WriteLine("Editing is Completed!");

                        }
                        else
                        {
                        Console.WriteLine("No Such Drugstore:");
                        }
                        if(item.adress == oldAdress)
                        {
                            item.adress = newAdress;
                             Console.WriteLine("Adress Updated");
                        }
                        else
                        {
                             Console.WriteLine("Adress is wrong");
                        }
                        if (item.contactNumber == oldContactNumber)
                        {
                            item.contactNumber = newContactNumber;
                            Console.WriteLine("Contact Number Updated");
                        }
                        else
                        {
                            Console.WriteLine("Number is wrong");
                        }
                 }
            }
            public DrugStores[] GetDrugStores()
            {
                return _drugstores;
            }


        #endregion

        #region Drug
            public void AddDrug(string Name, double Price, int Count, int DrugStoreIndex)
            {
                DrugStores drugStores = _drugstores[DrugStoreIndex];

                Drug drug = new Drug(Name, Price, Count);
                drugStores.AddDrugs(drug);
                Console.WriteLine("Drug is added to the DrugStore!");
            }
            public void EditDrug(string Name, double Price, int Count)
            {
                throw new NotImplementedException();
            }

            public void RemoveDrug(string Name, int Count)
            {
                throw new NotImplementedException();
            }


            
        #endregion

        #region
        public void AddOwner(string Name, string SurName)
        {
            throw new NotImplementedException();
        }

        public void EditOwner(string Name, string SurName)
        {
            throw new NotImplementedException();
        }

        public void RemoveOwner(string Name)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Druggist

        public void AddDruggist(string Name, string Surname, int Age, int Experience, int DrugStoreIndex)
            {
                DrugStores drugStores = _drugstores[DrugStoreIndex];

                Druggist druggist = new Druggist(Name, Surname, Age, Experience, drugStores);
                drugStores.AddDruggist(druggist);
                Console.WriteLine("Employee is added to the DrugStore!");
            }

            public void EditDruggist(string oldName, string newName, string oldSurname, string newSurname, int oldAge, int newAge, int oldExperience, int newExperience)
            {
                
            }

            public void RemoveDruggist(string Name, string drugstoreName,string workerNo)
            {
                DrugStores drugStores = null;
                foreach (DrugStores item in _drugstores)
                {
                    if (item.name.ToLower() == drugstoreName.ToLower())
                    {
                        drugStores = item;
                        break;

                    }

                }
                Druggist druggist = null;

                if (drugStores != null)
                {
                    foreach (Druggist item in drugStores.Druggists)
                    {

                        if (item.name.ToUpper() == Name.ToUpper())
                        {
                            druggist = item;
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("There is no such Drugstore!");
                }
                if (druggist != null)
                {
                    foreach (var item in drugStores.Druggists)
                    {
                        if (item.No.ToUpper() == workerNo.ToUpper())
                        {
                            int index = Array.IndexOf(drugStores.Druggists, druggist);
                            Array.Clear(drugStores.Druggists, index, 1);
                            Console.WriteLine("Worker successfully Removed!");
                            for (int i = 0; i < drugStores.Druggists.Length; i++)
                            {
                                if (drugStores.Druggists[i] != null)
                                {
                                    continue;
                                }
                                for (int j = 0; j < drugStores.Druggists.Length; j++)
                                {
                                    if (drugStores.Druggists[i] == null)
                                    {
                                        continue;
                                        drugStores.Druggists[i] = drugStores.Druggists[j];
                                        drugStores.Druggists[j] = null;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("There is no such Druggist in Drugstore!");
                }

            }
            #endregion



    }
}
