using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Screen.Menu_Options
{
    internal class Type_Of_Option
    {

        static public IChoice TypeOfOption(short choice)
        {

            switch(choice)
            {

                case 1: return new Adding_New_SystemUser();
                case 2: return new Updating_SystemUser();
                case 3: return new Deleting_SystemUser();
                case 4: return new Finding_info_Of_SystemUser();
                case 5: return new Display_All_SystemUsers_Info();
                case 6: return new Back_To_Main_Menu();

                default: return null;

            }


        }


    }

}
