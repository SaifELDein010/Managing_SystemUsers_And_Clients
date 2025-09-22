using Bank_system.Client_Management.Managing_Client_Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Main_Menu_Screen.Menu_Options
{
    internal class Adding_New_Client : IChoice
    {

        public void Action()
        {

            Console.Clear();

            // Adding new client
            Adding_New_Client_UI.AddingClient();

            Menu_UI.GoBack();

        }


    }
}
