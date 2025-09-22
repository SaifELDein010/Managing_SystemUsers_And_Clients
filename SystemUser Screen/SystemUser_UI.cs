using Bank_system.Main_Menu_Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Screen
{

    internal class SystemUser_UI
    {

        static public void Header()
        {

            Console.WriteLine("\n\n\t  System User Menu Page\n");
            Console.WriteLine("\t ___________________________________________\n");

        }

        static public void MenuOptions()
        {

            Console.WriteLine("\n\t  [1] Adding new User");
            Console.WriteLine("\t  [2] Updating User information");
            Console.WriteLine("\t  [3] Deleting User information");
            Console.WriteLine("\t  [4] Finding User information");
            Console.WriteLine("\t  [5] Display All Users information");
            Console.WriteLine("\t  [6] Back to main menu");

            Console.WriteLine("\t  ______________________________");
            SystemUser_Read_Choice.ReadChoice();

        }

        static public void GoBack()
        {

            Console.Write("\n\t Enter any key to go back to SystemUser Menu...");

            Console.ReadKey();

            Console.Clear();

            SystemUser_Menu.SystemUserMenu();

        }

    }


}
