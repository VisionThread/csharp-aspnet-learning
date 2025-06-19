using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    public interface IPrintTask
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        
        bool PhotoCopyContent(string content);


        //bool FaxContent(string content);
        //bool PhotoDuplex(string content);   

        ///FaxContent and PhotoDuplex are extra functionality some printer may have this feature or not so
        ///seperate interface for this so that Interface segeration prinicpal is followed
    }

    interface IFax
    {
        bool FaxContent(string content);
    }

    interface IPhoto
    {
        bool PhotoDuplex(string content);
    }
}
