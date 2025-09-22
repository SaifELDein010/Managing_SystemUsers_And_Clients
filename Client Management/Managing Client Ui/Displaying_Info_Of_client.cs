using Bank_system.Client_Management.Managing_Client_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Client_Management.Managing_Client_Ui
{
    internal class Displaying_Info_Of_client
    {

        static public void FindClient()
        {

            Managing_Client_UI.Header("Finiding exist client");

            Console.Write("\t Enter account name: ");
            Managing_Client_UI.client.accountName = Console.ReadLine();

            while (!Client_Is_Exist.IsExist(Managing_Client_UI.client.accountName))
            {

                Managing_Client_UI.ErrorMessage("\n\t There is error in account name, Do you want to enter another account name or finish?(Y/N): ");

                if (!Managing_Client_UI.CountiesProcess())
                    return;

                Console.Write("\t  account name: ");
                Managing_Client_UI.client.accountName = Console.ReadLine();

            }

            Managing_Client_UI.client = Sending_Info_Of_Client.SendingClientInfo(Managing_Client_UI.client.accountName);

            Managing_Client_UI.DisplayClientInfo();


        }

        static public void DisplayAllClients()
        {

            Managing_Client_UI.Header("Display all clients");

            List<Handling_Client_Storage.ClientInfo> clients = new List<Handling_Client_Storage.ClientInfo>();

            clients = Sending_All_Clients_Info.SendingAllClientInfo();

            foreach (Handling_Client_Storage.ClientInfo _client in clients)
            {

                Managing_Client_UI.DisplayClientInfo(_client);

            }

        }

    }

}
