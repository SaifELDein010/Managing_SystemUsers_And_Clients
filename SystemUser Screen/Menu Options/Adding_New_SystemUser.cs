using Bank_system.SystemUser_Management.Managing_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Screen.Menu_Options
{
    internal class Adding_New_SystemUser : IChoice
    {

        public void Action()
        {

            Console.Clear();

            // Adding new SystemUser
            Adding_New_User.AddingSystemUser();

            SystemUser_UI.GoBack();

        }

    }

}
