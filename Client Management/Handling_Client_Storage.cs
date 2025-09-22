using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Client_Management
{
    internal class Handling_Client_Storage
    {

        static public readonly string _path = "clients_info.txt";

        public struct ClientInfo
        {

            public string name;
            public string email;
            public string phoneNumber;
            public string accountName;
            public string password;
            public double amount;

        }

        static public List<ClientInfo> clients = new List<ClientInfo>();


        static public ClientInfo ConvertRecordIntoClient(string record)
        {

            ClientInfo clientInfo = new ClientInfo();

            string[] strings = record.Split("#&&#");

            clientInfo.name = strings[0];
            clientInfo.email = strings[1];
            clientInfo.phoneNumber = strings[2];
            clientInfo.accountName = strings[3];
            clientInfo.password = strings[4];
            clientInfo.amount = Convert.ToDouble(strings[5]);

            return clientInfo;

        }

        static public string ConvertClientIntoRecord(ClientInfo newClient)
        {

            string record = $"{newClient.name}#&&#{newClient.email}" +
                $"#&&#{newClient.phoneNumber}#&&#{newClient.accountName}" +
                $"#&&#{newClient.password}#&&#{newClient.amount}";

            return record;

        }


        static public void ReadRecordsFromFile()
        {

            clients.Clear();

            try
            {

                using (StreamReader read = new StreamReader(_path))
                {

                    string record;

                    while ((record = read.ReadLine()) != null)
                    {

                        clients.Add(ConvertRecordIntoClient(record));

                    }

                }

            }
            catch
            {


                File.CreateText(_path);


            }


        }

        static public void UpdatingClientInfoFile()
        {

            try
            {

                using (StreamWriter write = File.CreateText(_path))
                {

                    foreach (ClientInfo client in clients)
                    {

                        write.WriteLine(ConvertClientIntoRecord(client));

                    }

                }


            }
            catch
            {

                File.CreateText(_path);

            }

        }


        static public int GetIndexOfClient(string accountName)
        {

            foreach (ClientInfo client in clients)
            {

                if (client.accountName == accountName)
                    return clients.IndexOf(client);

            }

            return -1;

        }


    }


}
