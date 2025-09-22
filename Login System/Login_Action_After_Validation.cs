using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Login_System
{
    internal class Login_Action_After_Validation
    {

        static public void ActionAfterValidation()
        {

            System.Threading.Thread.Sleep(400);

            Console.Clear();

            Main_Menu_Screen.Main_Menu.MainMenu();

        }


    }


}
