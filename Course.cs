using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_assignment
{
    class Course
    {
        int sccount = 0;
        private string cName;

        public string CName
        {
            get { return cName; }
            set { cName = value; }
        }

        public int cteachingHor;

        public int CTeachingHor
        {
            get { return cteachingHor; }
            set { cteachingHor = value; }
        }

        private string courseId;

        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        public void AddSection(Section sc)
        {
            sectionlist[sccount++] = sc;
        }
        Section[] sectionlist;
        public Course()
        {
            sectionlist = new Section[100];
        }
        public Course(string cName, string courseId, int cteachingHor)
        {
            this.cName = cName;
            this.courseId = courseId;
            this.cteachingHor = cteachingHor;
            sectionlist = new Section[100];
        }
        public void showInfo()
        {
            Console.WriteLine("Course Name : " + cName);
            Console.WriteLine("Course ID : " + courseId);
            Console.WriteLine("Course Teaching Hour : " + cteachingHor + "hors");
        }
        public void ShowSection()
        {
            Console.WriteLine("This Course has :");
            for (int i = 0; i < sccount; i++)
            {
                sectionlist[i].showInfo();

            }
        }

    }
}
