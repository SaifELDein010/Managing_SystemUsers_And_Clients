using Bank_system.SystemUser_Management.Managing_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Screen.Menu_Options
{
    internal class Display_All_SystemUsers_Info : IChoice
    {
        public void Action()
        {

            Console.Clear();

            // Display all SystemUsers info
            Display_Info_Of_User.DisplayAllUsers();

            SystemUser_UI.GoBack();

        }

    }
}
