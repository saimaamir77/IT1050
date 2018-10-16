using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AccountTest
{
    class ClassHouse
    {
        string address;
        int builtyear;
        int sqaurefoot;
        public string GetbuilderName()
        {
            return this.address;
        }
        public void SetbuilderName(string y)
        {
            this.address = y;
                }

    }
}
