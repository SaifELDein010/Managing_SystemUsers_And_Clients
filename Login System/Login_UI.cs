using System;


namespace Bank_system.Login_System
{

    internal class Login_UI
    {

        static public void Header()
        {

            Console.WriteLine("\n\n\t  Login page\n");
            Console.WriteLine("\t ___________________________________________\n\n");

        }

        static public void InputForme()
        {

            Login_Input.DisplayMessage("\n\t >> Enter Username: ");
            Login_Input.username = Login_Input.ReadTextInput();

            Login_Input.DisplayMessage("\t >> Enter Password: ");
            Login_Input.password = Login_Input.ReadTextInput();

        }

        static public void Message(string message)
        {

            Console.Write(message);

        }


    }

}
