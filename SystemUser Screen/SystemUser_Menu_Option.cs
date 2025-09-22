using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Screen
{
    internal class SystemUser_Menu_Option
    {

        static public void Action(short choice)
        {

            Menu_Options.IChoice action = Menu_Options.Type_Of_Option.TypeOfOption(choice);
            action.Action();

        }


    }

}
