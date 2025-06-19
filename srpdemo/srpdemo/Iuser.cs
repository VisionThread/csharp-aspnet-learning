using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srpdemo
{
    interface Iuser
    {
        bool login(string username, string password);

        bool register(string username, string password,string email);

        //void logerror(string error);

        //bool sendEmail(string emailContent);
        //since log error deals with send errors while login,
        //there is no need of logerror to be in iuser similarly
        //wit sendEmail it deals with sending email content so there is no need
        // of sendemail to part of Iuser,we will make separate interfaces for them
    }

    interface ILogger
    {
        void logerror(string error);
    }

    interface IEmail
    {
        bool sendEmail(string emailContent);
    }


}
