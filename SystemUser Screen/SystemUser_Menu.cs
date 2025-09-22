using Bank_system.Main_Menu_Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Screen
{
    internal class SystemUser_Menu
    {

        static public void SystemUserMenu()
        {

            Console.Clear();
            SystemUser_UI.Header();

            SystemUser_UI.MenuOptions();

            SystemUser_Menu_Option.Action(SystemUser_Read_Choice.choice);

        }


    }

}
