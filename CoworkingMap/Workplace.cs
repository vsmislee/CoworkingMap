using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingMap
{
    class Workplace
    {
        int number;//вопрос:  проверка на совпадение номеров мест. возможно массив намеров статический
        bool busy;
        Member member;
        // добавить поле для срока бронирования 
        // нужны координаты на карте
        public Workplace(int number, Member member)
        {
            this.number = number;
            this.member = member;
            this.busy = true;
        }

        public Workplace(int number)
        {
            this.number = number;
            this.member = null;
            this.busy = false;
        }

        public int Number
        {
            get { return this.number; }
        }

        public Member Member
        {
            get { return this.member; }
        }

        public bool IsBusy() { return this.busy; }

        public void Draw() // тут нужно будет рисовать
        { 
            
        }

        public bool Take(Member member) // ещё нужен параметр срока бронирования
        {
            if (!this.IsBusy())
            {
                this.member = member;
                this.busy = true;
                // тут ещй должны быть штуки с базой данных

                return true;
            }
            return false;
        }

        public void ChangeNumber(int number)
        {
            this.number = number;
        }
    }
}
