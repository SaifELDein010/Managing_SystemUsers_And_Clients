using Bank_system.Client_Management.Managing_Client_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Client_Management.Managing_Client_Ui
{
    internal class Updating_Exist_Client_UI
    {

        static private void ReadUpdatingClientInfo()
        {

            Console.WriteLine("\t  Enter information: ");
            Console.WriteLine("\t  ---------------------");

            Console.Write("\t  Name of client: ");
            Managing_Client_UI.client.name = Console.ReadLine();

            Console.Write("\t  Email of client: ");
            Managing_Client_UI.client.email = Console.ReadLine();

            Console.Write("\t  Phone number of client: ");
            Managing_Client_UI.client.phoneNumber = Console.ReadLine();

            Console.Write("\t  PIN code of client: ");
            Managing_Client_UI.client.password = Console.ReadLine();

            Console.Write("\t  amount of client: ");
            Managing_Client_UI.client.amount = Convert.ToDouble(Console.ReadLine());

        }

        static public void UpdatingClient()
        {

            Managing_Client_UI.Header("Updating exist client");

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

            ReadUpdatingClientInfo();

            Managing_Client_UI.DisplayClientInfo();


            Console.Write("\t Ask client if he/she sure to Updating this client account?(Y/N): ");
            if (!Managing_Client_UI.CountiesProcess())
                return;


            if (Updating_Exist_Client.UpdatingExistClientInfo(Managing_Client_UI.client) != 911)
            {
                Console.WriteLine("\t There is an error in system");
                return;
            }

            Console.WriteLine("\t Client Updating successful");

        }

    }

}
