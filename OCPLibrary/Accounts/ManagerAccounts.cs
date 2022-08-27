using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class ManagerAccounts : IAccounts
    {
        public EmplyeeModel Create(IApplicantModel person)
        {
            EmplyeeModel output = new EmplyeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName}.{person.LastName}@randommanager.com";

            output.IsManager = true;

            return output;
        }
    }
}
