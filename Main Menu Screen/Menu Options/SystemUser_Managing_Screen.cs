using Bank_system.SystemUser_Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Main_Menu_Screen.Menu_Options
{
    internal class SystemUser_Managing_Screen : IChoice
    {

        public void Action()
        {

            Console.Clear();

            SystemUser_Menu.SystemUserMenu();

        }

    }
}
