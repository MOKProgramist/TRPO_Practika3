using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika3
{
    internal interface IPersonnelManagement
    {
        void TransferToAnotherDepartment(string nameDepartmen);
        void Dismissal();
        void Bonuses();
    }
}
