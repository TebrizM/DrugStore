using System;

using DrugStore.Interface;
using DrugStore.Entities;
using DrugStore.Services;

namespace DrugStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling our Method
            Runmthd();
        }
        static void Runmthd()
        {
            //Changes color of the all texts
            Console.ForegroundColor = ConsoleColor.Yellow;
            DrugStoreService drugStoreService = new DrugStoreService();



            byte choice;

            //variables to store user inputs and create objects;
            string name;
            string adress;
            string email;
            string contactnumber;

            // Used for Editing Department
            string oldDrugstore;
            string newDrugstore;
            string oldAdress;
            string newAdress;
            string oldContactNumber;
            string newContactNumber;

            //Editing variables;
            string editID;
            bool isFound = false;


            string typestr;
            int typeint;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Creating out Menu
                Console.Write("                                            << 1: Show DrugStore >> \n                                            << 2: Add DrugStore >> \n                                            << 3: Edit DrugStore >> \n                                            << 4: Add Druggist >> \n                                            << 5: Edit Druggist >> \n                                            << 6: Remove Druggist >> \n                                            << 7: Get Druggist Data >> \n                                            << 0: Exit >>");
                Console.WriteLine();
                choice = Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    #region CASE 1
                    case 1:
                        //Showing Information about Departments
                        foreach (var item in drugStoreService.GetDrugStores())
                        {
                            Console.WriteLine($"Drug Store Name: {item.name} ");

                        }

                        break;
                    #endregion
                    #region CASE 2
                    case 2:
                        //Gathering user input
                        Console.Write("                                                Department Name: ");
                        name = Console.ReadLine();
                        Console.Write("                                                Adress: ");
                        adress = Console.ReadLine();
                        Console.Write("                                                Email: ");
                        email = Console.ReadLine();
                        Console.Write("                                                ContactNumber: ");
                        contactnumber = Console.ReadLine();
                        //Creating object based on user input
                        DrugStores drugStore = new DrugStores(name, adress, email, contactnumber);

                        //Calling our Add Department method and passing the newly created object
                        drugStoreService.AddDrugStore(name, adress, email,contactnumber);
                        break;
                    #endregion
                    #region CASE 3
                    case 3:
                        //Method for Editing Department
                        Console.WriteLine("                                                Enter Drugstore Name: ");
                        oldDrugstore = Console.ReadLine();
                        Console.WriteLine("                                                New Drugstore Name: ");
                        newDrugstore = Console.ReadLine();
                        Console.WriteLine("                                                Old Address: ");
                        oldAdress = Console.ReadLine();
                        Console.WriteLine("                                                New Address: ");
                        newAdress = Console.ReadLine();
                        Console.WriteLine("                                                Old Contact Number: ");
                        oldContactNumber = Console.ReadLine();
                        Console.WriteLine("                                                New Contact NameNumber ");
                        newContactNumber = Console.ReadLine();



                        
                        drugStoreService.EditDrugStore(oldDrugstore, newDrugstore,oldAdress,newAdress,oldContactNumber,newContactNumber);

                        break;
                    #endregion
                    #region CASE 4
                    case 4:
                        // Method for add new employee
                        int dprtInt = int.Parse(Console.ReadLine());
                        Console.Write("                        Druggist's Name:");
                        string druggistName = Console.ReadLine();
                        Console.Write("                        Druggist's SurName:");
                        string surname = Console.ReadLine();
                        Console.Write("                        Druggist's Age:");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("                        Druggist's Experience:");
                        int experience = int.Parse(Console.ReadLine());

                        drugStoreService.AddDruggist(druggistName, surname, age, experience,(dprtInt - 1));
                        break;
                    #endregion
                    #region CASE 5
                    case 5:
                        //Method for make change on employee
                        Console.Write("Search Druggist: ");
                        editID = Console.ReadLine();
                        foreach (var item in drugStoreService.GetDrugStores())
                        {
                            for (int i = 0; i < item.Druggists.Length; i++)
                            {

                                if (editID == item.Druggists[i].No)
                                {
                                    Console.WriteLine($"Druggists's Name: {item.Druggists[i].name} Druggists's Surname: {item.Druggists[i].surname} Druggists's age: {item.Druggists[i].age} Employee's Experience {item.Druggists[i].experience}");

                                   
                                    isFound = true;
                                    break;
                                }

                            }
                        }
                        if (!isFound)
                        {
                            Console.WriteLine("No Such Druggist: ");
                            isFound = false;

                        }

                        break;
                    #endregion
                    #region CASE 6
                    case 6:
                        //Method for Removing employee
                        Console.Write("Search Employee: ");
                        editID = Console.ReadLine();
                        foreach (var item in drugStoreService.GetDrugStores())
                        {
                            for (int i = 0; i < item.Druggists.Length; i++)
                            {

                                if (editID == item.Druggists[i].No)
                                {
                                    Console.WriteLine($"Druggists's Name: {item.Druggists[i].name} Druggists's Surname: {item.Druggists[i].surname} Druggists's age: {item.Druggists[i].age} Employee's Experience {item.Druggists[i].experience}");

                                    Console.WriteLine("Druggists Deleted: ");
                                    item.Druggists[i] = item.Druggists[item.Druggists.Length - 1];
                                    Array.Resize(ref item.Druggists, item.Druggists.Length - 1);
                                    isFound = true;

                                }
                            }
                        }
                        if (!isFound)
                        {
                            Console.WriteLine("Not Such Druggists");
                            isFound = false;

                        }
                        break;

                    #endregion
                    #region CASE 7
                    case 7:
                        //Method for Showing employee's info
                        foreach (var drugStores1 in drugStoreService.GetDrugStores())
                        {
                            Console.WriteLine($"\n {drugStores1.name} \n");
                            foreach (var employee in drugStores1.Druggists)
                            {
                                Console.WriteLine($"{employee.No}  {employee.name}  {employee.surname} {employee.age}");
                            }
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                        }
                        break;
                    #endregion
                    #region  CASE 8
                    case 0:
                        Console.WriteLine("                                                Program Terminated");
                        break;
                    #endregion
                    #region  CASE 9
                    default:
                        Console.WriteLine("                                                Invalid Option!");
                        break;
                        #endregion
                }

            }
            while (choice != 0);
        }
    }
}
