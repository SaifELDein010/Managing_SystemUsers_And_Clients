using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Client_Management.Managing_Client_Ui
{
    internal class Managing_Client_UI
    {

        static public Handling_Client_Storage.ClientInfo client = new Handling_Client_Storage.ClientInfo();

        static public void Header(string message)
        {

            Console.WriteLine($"\n\n\t  {message} Page\n");
            Console.WriteLine("\t ___________________________________________\n");

        }


        static public void DisplayClientInfo()
        {

            Console.WriteLine($"\n\t  {client.name} client info ");
            Console.WriteLine("\t  --------------------------------------");

            Console.WriteLine($"\t  Name: {client.name}");
            Console.WriteLine($"\t  Email: {client.email}");
            Console.WriteLine($"\t  Phone number: {client.phoneNumber}");
            Console.WriteLine($"\t  Account number: {client.accountName}");
            Console.WriteLine($"\t  PIN code: {client.password}");
            Console.WriteLine($"\t  Amount: {client.amount}\n");

        }

        static public void DisplayClientInfo(Handling_Client_Storage.ClientInfo _client)
        {

            Console.WriteLine($"\t {_client.name,15} | {_client.email,20} | {_client.phoneNumber,15} | " +
                $"{_client.accountName,10} | {_client.password,15} | {_client.amount}");

        }


        static public void ErrorMessage(string message)
        {

            Console.Write(message);

        }

        static public bool CountiesProcess()
        {

            char answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'Y' || answer == 'y')
                return true;

            return false;

        }

    }

}
