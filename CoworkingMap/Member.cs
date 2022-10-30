using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingMap
{
    class Member
    {
        string name;
        string surname;
        string middlename;
        string post;
        int worplace;
        public Member()
        {
            this.name = null;
            this.surname = null;
            this.middlename = null;
            this.post = null;
            this.worplace = 0;
        }

        public Member(string name, string surname, string middlename, string post, int workplace)
        {
            this.name = name;
            this.surname = surname;
            this.middlename = middlename;
            this.post = post;
            this.worplace = workplace;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Surname
        {
            get{return this.surname;}
            set { this.surname = value; }
        }
        public string Middlename
        {
            get { return this.middlename; }
            set { this.middlename = value; }
        }
        public string Post
        {
            get { return this.post; }
            set { this.post = value; }
        }
        public int Workplace
        {
            get { return this.worplace; }
            set { this.worplace = value; }
        }


    }
}
