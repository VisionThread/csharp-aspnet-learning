using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo.Client
{
    class Class1:IPrintTask
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax done");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("Photocopy done");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("PrintContent done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan done");
            return true;
        }

        ///NOW if i have printer "cannon432" which can only perforn print and photocopy task so for that we
        ///have to handle it in such way where all methods of printask interface are not implemented so we will make changes in 
        ///Interface IPrintTask so that every printer have some mandatory functions and add extra functions accordingly
    }
}
