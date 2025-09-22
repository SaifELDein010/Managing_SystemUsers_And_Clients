using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Screen
{
    internal class SystemUser_Read_Choice
    {

        static public short choice;

        static private void ReadInput()
        {

            Console.Write("\t  Enter youe choice: ");
            choice = Convert.ToInt16(Console.ReadLine());

        }

        static private void Message(string message)
        {

            Console.WriteLine(message);

        }

        static public void ReadChoice()
        {

            ReadInput();

            while (choice < 1 || choice > 6)
            {

                Message("\n\t  Invalid choice, Enter between [1:6]\n");
                ReadInput();

            }

        }

    }
}
