using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practika3;

namespace Practika3
{
    internal class PersonnelManagement: IPersonnelManagement
    {
        IPersonnelManagement personnelManagement;
        // конструктор, в который передается объект, нижнего уровня
        // поддерживающий интерфейс IPersonnelManagement
        public PersonnelManagement(IPersonnelManagement personnel)
        {
            this.personnelManagement = personnel;
        }

        // методы задания команд объекту нижнего уровня
        // перевести в другой отдел
        public void TransferToAnotherDepartment(string nameDepartmen)
        {
            personnelManagement.TransferToAnotherDepartment(nameDepartmen);
        }

        // уволить
        public void Dismissal()
        {
            personnelManagement.Dismissal();
        }

        // премия
        public void Bonuses()
        {
            personnelManagement.Bonuses();
        }
    }
}
