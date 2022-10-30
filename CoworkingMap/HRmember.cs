using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingMap
{
    class HRmember : Member
    {
        public HRmember(string name, string surname, string middlename, string post, int workplace) : base(name, surname, middlename, post, workplace) { }
        
            
        
        public void AddWorkplace(int number)
        { 
            // добавление места и штуки с базой данных
        }

        public void DeleteWorkplace(Workplace workplace)
        { 
            // удаление места и штуки с бд
        }

        public Member AddMember(bool isHR, string name, string surname, string middlename, string post, int workplace)
        {
            Member newmember;
            if (isHR)
                newmember = new HRmember(name, surname, middlename, post, workplace);
            else
                newmember = new Member(name, surname, middlename, post, workplace);
            // добавить добавление в базу данных

            return newmember;
        }
    }
}
