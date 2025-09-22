using Bank_system.SystemUser_Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Main_Menu_Screen
{
    internal class Menu_UI
    {

        static public void Header()
        {

            Console.WriteLine("\n\n\t  Main Menu Page\n");
            Console.WriteLine("\t ___________________________________________\n");

        }

        static public void MenuOptions()
        {

            Console.WriteLine("\n\t  [1] Adding new client");
            Console.WriteLine("\t  [2] Updating client information");
            Console.WriteLine("\t  [3] Deleting client information");
            Console.WriteLine("\t  [4] Finding client information");
            Console.WriteLine("\t  [5] Display All clients information");
            Console.WriteLine("\t  [6] Managing system user");
            Console.WriteLine("\t  [7] Logout");

            Console.WriteLine("\t  ______________________________");
            Menu_Read_Choice.ReadChoice();

        }

        static public void GoBack()
        {

            Console.Write("\n\t Enter any key to go back to Main Menu...");

            Console.ReadKey();

            Console.Clear();

            Main_Menu.MainMenu();

        }

    }


}

