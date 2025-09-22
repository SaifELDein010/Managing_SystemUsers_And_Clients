using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Main_Menu_Screen.Menu_Options
{
    internal class Type_Of_Option
    {

        static public IChoice TypeOfAction(short choice)
        {

            switch (choice)
            {

                case 1: return new Adding_New_Client();
                case 2: return new Updatin_Client();
                case 3: return new Deleting_Client();
                case 4: return new Finding_Client_Information();
                case 5: return new Display_All_Clients_Info();
                case 6: return new SystemUser_Managing_Screen();
                case 7: return new LogOut();

                default: return null;

            }

        }

    }
}
