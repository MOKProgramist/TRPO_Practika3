using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika3
{
    internal class Сleaner: IPersonnelManagement
    {
        string Name;
        public Сleaner(string name) {
            Name= name;
        }

        public void Bonuses()
        {
            Console.WriteLine($"Уборщик {Name} получил премию");
        }

        public void Dismissal()
        {
            Console.WriteLine($"Уборщик {Name} был уволен");
        }

        public void TransferToAnotherDepartment(string nameDepartment)
        {
            Console.WriteLine($"Уборщик {Name} был переден в отдел {nameDepartment}");
        }
    }
}
