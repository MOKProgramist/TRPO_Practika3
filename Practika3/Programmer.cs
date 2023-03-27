using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika3
{
    internal class Programmer : IPersonnelManagement
    {
        string Name;
        public Programmer(string name)
        {
            Name = name;
        }

        public void Bonuses()
        {
            Console.WriteLine($"Программист {Name} получил премию");
        }

        public void Dismissal()
        {
            Console.WriteLine($"Программист {Name} был уволен");
        }

        public void TransferToAnotherDepartment(string nameDepartment)
        {
            Console.WriteLine($"Программист {Name} был переден в отдел {nameDepartment}");
        }
    }
}
