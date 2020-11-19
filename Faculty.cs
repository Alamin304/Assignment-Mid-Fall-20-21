using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_assignment
{
    class Faculty
    {
        private int cscount = 0;
        private int sccount = 0;
        private string facultyName;

        public string FacultyName
        {
            get { return facultyName; }
            set { facultyName = value; }
        }
        private string facultyId;

        public string FacultyId
        {
            get { return facultyId; }
            set { facultyId = value; }
        }
        private float teachHor;

        public float TeachHor
        {
            get { return teachHor; }
            set { teachHor = value; }
        }


        public Faculty(string facultyName, string facultyId)
        {
            this.facultyName = facultyName;
            this.facultyId = facultyId;
            seclist = new Section[100];
            cslist = new Course[100];
        }

        Section[] seclist;

        public void AddSection(Section sc)
        {
            seclist[sccount++] = sc;

        }

        public void ShowSection()
        {
            for (int i = 0; i < sccount; i++)
            {
                seclist[i].showInfo();

            }
        }

        public void AddTeachHour(Course cs, Section sc)
        {
            if (teachHor + cs.cteachingHor > 21)
            {
                Console.WriteLine("Sorry Can't Add more Section.Because it will exced 21 hors in a week !");
            }
            else
            {
                this.teachHor = this.teachHor + cs.cteachingHor;
            }
        }

        public void showInfo()
        {
            Console.WriteLine("Teacher's Name :" + facultyName);
            Console.WriteLine("Teacher's ID : " + facultyId);
            Console.WriteLine("Weekly Teaching Hours : " + teachHor + " hours");
            Console.WriteLine();
            Console.WriteLine("MR. " + facultyName + "'s Courses :");
            FShowCourse();
        }
        Course[] cslist;

        public void AddCourse(Course cs)
        {
            cslist[cscount++] = cs;
        }
        public void FShowCourse()
        {
            for (int i = 0; i < sccount; i++)
            {
                cslist[i].showInfo();

            }
            FShowSection();
        }

        public void FShowSection()
        {
            for (int i = 0; i < sccount; i++)
            {
                seclist[i].showInfo();

            }
        }

    }
}