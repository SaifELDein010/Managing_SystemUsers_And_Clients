using Bank_system.Main_Menu_Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Screen.Menu_Options
{
    internal class Back_To_Main_Menu : IChoice
    {

        public void Action()
        {

            System.Threading.Thread.Sleep(400);

            Console.Clear();

            Main_Menu.MainMenu();
        }

    }
}
