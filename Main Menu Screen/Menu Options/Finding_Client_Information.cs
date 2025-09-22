using Bank_system.Client_Management.Managing_Client_Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Main_Menu_Screen.Menu_Options
{
    internal class Finding_Client_Information : IChoice
    {

        public void Action()
        {

            Console.Clear();

            // Finding information of exist client
            Displaying_Info_Of_client.FindClient();

            Menu_UI.GoBack();

        }

    }
}
