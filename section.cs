using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_assignment
{
    class Section
    {
        private string secName;

        public string SecName
        {
            get { return secName; }
            set { secName = value; }
        }


        public Section(string secName)
        {
            this.secName = secName;

        }
        public void showInfo()
        {
            Console.WriteLine("Sec Name:" + secName);

        }


    }
}