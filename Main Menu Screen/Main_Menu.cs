using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Main_Menu_Screen
{
    internal class Main_Menu
    {

        static public void MainMenu()
        {
            
            Console.Clear();
            Menu_UI.Header();

            Menu_UI.MenuOptions();

            Menu_Option_Action.Action(Menu_Read_Choice.choice);

        }

    }


}
