using Bank_system.Client_Management.Managing_Client_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Client_Management.Managing_Client_Ui
{
    internal class Deleting_Exist_Client_UI
    {

        static public void DeletingClient()
        {

            Managing_Client_UI.Header("Deleting exist client");

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

            Console.Write("\t Ask client if he/she sure to deleting this client account?(Y/N): ");
            if (!Managing_Client_UI.CountiesProcess())
                return;


            if (Deleting_Exist_Client.DeletingEisxtClient(Managing_Client_UI.client.accountName) != 911)
            {
                Console.WriteLine("\t There is an error in system");
                return;
            }

            Console.WriteLine("\t Client deleting successful");

        }

    }

}
