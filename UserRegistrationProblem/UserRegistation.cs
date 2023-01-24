using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UserRegistation
    {
        public void FirstNameAndLastName(string Name)
        {
            Regex firstLastName = new Regex(@"^([A-z]{1}[a-z]{2,})$");
            bool matches = firstLastName.IsMatch(Name);

            if (matches == true)
            {
                Console.WriteLine($"{Name} is Valid Name");
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Name {Name}");
            }
        }
    }
}
