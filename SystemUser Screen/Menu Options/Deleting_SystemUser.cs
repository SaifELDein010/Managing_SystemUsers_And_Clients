using Bank_system.SystemUser_Management.Managing_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Screen.Menu_Options
{
    internal class Deleting_SystemUser : IChoice
    {

        public void Action()
        {

            Console.Clear();

            // Deleting exist SystemUser
            Deleting_Exist_User.DeletingSystemUser();

            SystemUser_UI.GoBack();

        }

    }
}
