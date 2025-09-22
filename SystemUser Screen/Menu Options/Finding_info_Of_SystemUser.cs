using Bank_system.SystemUser_Management.Managing_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Screen.Menu_Options
{
    internal class Finding_info_Of_SystemUser : IChoice
    {

        public void Action()
        {

            Console.Clear();

            // Get info about SystemUser
            Display_Info_Of_User.FindSystemUser();

            SystemUser_UI.GoBack();

        }

    }
}
