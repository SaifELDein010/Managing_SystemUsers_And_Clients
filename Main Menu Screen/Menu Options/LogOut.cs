using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Main_Menu_Screen.Menu_Options
{
    internal class LogOut : IChoice
    {

        public void Action()
        {

            System.Threading.Thread.Sleep(400);

            Console.Clear();

        }

    }

}
