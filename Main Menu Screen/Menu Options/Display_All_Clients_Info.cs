using Bank_system.Client_Management.Managing_Client_Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Main_Menu_Screen.Menu_Options
{
    internal class Display_All_Clients_Info : IChoice
    {

        public void Action()
        {

            Console.Clear();

            // Display all information of exist clients
            Displaying_Info_Of_client.DisplayAllClients();

            Menu_UI.GoBack();

        }


    }
}
