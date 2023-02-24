using System;
using System.Collections.Generic;
using System.Text;

namespace Addition
{
    class ProgramManager
    {
        public void Start()
        {
            int Number1, Number2;
            string Continue, UserSelection;

            InputManager inputManager = new InputManager();
            Calculation val = new Calculation();
            MenuManager menumanager = new MenuManager();
            do
            {
                menumanager.MenuDisplay();
                UserSelection = Console.ReadLine();
                //Number1 = inputManager.UserInputNumber("Enter the first number:");
                //Number2 = inputManager.UserInputNumber("Enter the second number:");
                switch (UserSelection)
                {
                    case "1":
                        Number1 = inputManager.UserInputNumber("Enter the first number:");
                        Number2 = inputManager.UserInputNumber("Enter the second number:");
                        Console.WriteLine("Total :" + val.Add(Number1, Number2));
                        break;
                    case "2":
                        Number1 = inputManager.UserInputNumber("Enter the first number:");
                        Number2 = inputManager.UserInputNumber("Enter the second number:");
                        Console.WriteLine("Total :" + val.Mul(Number1, Number2));
                        break;
                    default:
                        Console.WriteLine("Select a valid number..");
                        break;
                }
                
                Console.WriteLine("Do you want to continue Y or N ?");
                Continue = Console.ReadLine();
                Continue = Continue.ToUpper();
            } while (Continue == "Y");


        }
    }
}