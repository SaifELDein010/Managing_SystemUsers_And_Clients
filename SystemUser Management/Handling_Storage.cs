using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Management
{
    internal class Handling_Storage
    {

        static public readonly string _path = "SystemUser_info.txt";

        public struct SystemUserInfo
        {

            public string name;
            public string email;
            public string phoneNumber;
            public string accountName;
            public string password;
            public short permission;


        }

        static public List<SystemUserInfo> systemUsers = new List<SystemUserInfo>();


        static public SystemUserInfo ConvertRecordIntoSystemUser(string record)
        {

            SystemUserInfo systemUser = new SystemUserInfo();

            string[] strings = record.Split("#&&#");

            systemUser.name = strings[0];
            systemUser.email = strings[1];
            systemUser.phoneNumber = strings[2];
            systemUser.accountName = strings[3];
            systemUser.password = strings[4];
            systemUser.permission = Convert.ToInt16(strings[5]);

            return systemUser;

        }

        static public string ConvertSystemUserIntoRecord(SystemUserInfo newSystemUser)
        {

            string record = $"{newSystemUser.name}#&&#{newSystemUser.email}" +
                $"#&&#{newSystemUser.phoneNumber}#&&#{newSystemUser.accountName}" +
                $"#&&#{newSystemUser.password}#&&#{newSystemUser.permission}";

            return record;

        }


        static public void ReadRecordsFromFile()
        {

            systemUsers.Clear();

            try
            {

                using (StreamReader read = new StreamReader(_path))
                {

                    string record;

                    while ((record = read.ReadLine()) != null)
                    {

                        systemUsers.Add(ConvertRecordIntoSystemUser(record));

                    }

                }

            }
            catch
            {


                File.CreateText(_path);


            }


        }

        static public void UpdatingSystemUserInfoFile()
        {

            try
            {

                using (StreamWriter write = File.CreateText(_path))
                {

                    foreach (SystemUserInfo systemUser in systemUsers)
                    {

                        write.WriteLine(ConvertSystemUserIntoRecord(systemUser));

                    }

                }


            }
            catch
            {

                File.CreateText(_path);

            }

        }


        static public int GetIndexOfSystemUser(string systemUserName)
        {

            foreach (SystemUserInfo systemUser in systemUsers)
            {

                if (systemUser.accountName == systemUserName)
                    return systemUsers.IndexOf(systemUser);

            }

            return -1;

        }


    }

}
