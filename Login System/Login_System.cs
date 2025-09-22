using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Login_System
{
    internal class Login_System
    {

        static public void LoginSystem()
        {

            Login_UI.Header();
            Login_UI.InputForme();

            while(Login_Input_Validation.InputValidation() == false)
            {

                Login_UI.Message("\n\t Username/Password invalid.\n\n");
                Login_UI.InputForme();

            }

            Login_UI.Message("\n\t Successful login.\n\n");

            Login_Action_After_Validation.ActionAfterValidation();

        }

    }

}
