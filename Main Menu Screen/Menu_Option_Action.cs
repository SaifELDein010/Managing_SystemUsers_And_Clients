using Bank_system.Main_Menu_Screen.Menu_Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Main_Menu_Screen
{
    internal class Menu_Option_Action
    {

        static public void Action(short choice)
        {

            IChoice action = Type_Of_Option.TypeOfAction(choice);
            action.Action();

        }

    }

}
