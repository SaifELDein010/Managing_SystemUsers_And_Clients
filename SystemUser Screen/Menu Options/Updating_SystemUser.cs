using Bank_system.SystemUser_Management.Managing_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Screen.Menu_Options
{
    internal class Updating_SystemUser : IChoice
    {

        public void Action()
        {

            Console.Clear();

            // Updatin exist SystemUser
            Updating_Exist_User_info.UpdatingSystemUser();

            SystemUser_UI.GoBack();

        }

    }
}
