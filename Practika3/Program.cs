using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Practika3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonnelManagement personnelManagement;
            // создаем объект нижнего уровня
            IPersonnelManagement programmit = new Programmer("Андрей");
            // создаем объект класса верхнего уровня - управления кадрами
            // передаем ему объект нижнего уровня, который поддерживает интерфейс
            personnelManagement = new PersonnelManagement(programmit);
            // задаем команды объекту нижнего уровня
            personnelManagement.TransferToAnotherDepartment("тестирование");
            personnelManagement.Bonuses();
            personnelManagement.Dismissal();

            Console.WriteLine();
            // заменим объект нижнего уровня
            IPersonnelManagement cleaner = new Сleaner("Валера");
            personnelManagement = new PersonnelManagement(cleaner);
            // опять задаем команды объекту нижнего уровня
            personnelManagement.TransferToAnotherDepartment("главный смены");
            personnelManagement.Bonuses();
            personnelManagement.Dismissal();
            // убедимся, что все работает правильно
            Console.Read();
        }
    }
}
