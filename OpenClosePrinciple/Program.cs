using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new ExecutiveModel { FirstName = "Monika", LastName = "Johan"},
                new ManagerModel { FirstName = "John", LastName = "Doe"},
                new PersonModel { FirstName = "Clark", LastName = "Kent" }
            };

            List<EmplyeeModel> emplyees = new List<EmplyeeModel>();
           

            foreach (var person in applicants)
            {
                emplyees.Add(person.AccountProcessor.Create(person));
            }
            foreach (var emp in emplyees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();

        }
    }
}
