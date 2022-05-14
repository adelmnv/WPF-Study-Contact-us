using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.IO;

namespace WPF_Study
{
    class Model : Abstractions.IModel
    {
        public string email;
        public string name;
        public void ShowIn(string message)
        {
            Debug.WriteLine(message);
        }
        public void SaveIn(string message1, string message2 )
        {
            name = message1;
            email = message2;

            string path = "data.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("Your Name:\t{0}",name);
                writer.WriteLine("Email Adress:\t{0}",email);
            }
        }
        public bool Check(string mes1, string mes2)
        {
            bool e = false;
            bool n = false;
            if(mes2.Length > 0 && mes2.Contains("@") && mes2.Contains(".") && mes2.IndexOf(',') < 0 && mes2.IndexOf(';') < 0 && mes2.IndexOf(' ') < 0)
            {
                int i = mes2.IndexOf('@');
                int d = mes2.LastIndexOf('.');
                if (i < mes2.Length - 5 && i - 1 != d && i + 1 != d && d - i >= 2 && mes2.Length - d >= 3)
                    e = true;
            }
            if(mes1.Length > 0)
            {
                n = mes1.All(Char.IsLetterOrDigit);
            }
            if (e == true && n == true)
                return true;
            else
                return false;
        }
        
        
    }
}
