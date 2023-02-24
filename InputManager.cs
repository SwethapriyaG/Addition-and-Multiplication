using System;
using System.Collections.Generic;
using System.Text;

namespace Addition
{
    class InputManager
    {

        public int UserInputNumber(string msg)
        {
            int Number;

            Console.WriteLine(msg);
            
           string UserInput = Console.ReadLine();
            Int32.TryParse(UserInput, out Number);
            return Number;
        }
        
    }
}
