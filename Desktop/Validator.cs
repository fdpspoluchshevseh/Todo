using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desktop
{
    public class Validator
    {
        public static bool Name(string name)
        {
            if (name.Length >= 3)
                return true;

            else
                return false;
        }
        public static bool Mail(string mail)
        {
            Regex regex = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$");
            Match match = regex.Match(mail);
            if (match.Success)
                return true;

            else
                return false;
        }
        public static bool Regpass(string regparol)
        {
            if (regparol.Length >= 6)
                return true;

            else
                return false;
        }
        public static bool Regpasstwo(string regparoltwo, string regparol)
        {
            if (regparoltwo == regparol)
                return true;

            else
                return false;
        }
    }
}
