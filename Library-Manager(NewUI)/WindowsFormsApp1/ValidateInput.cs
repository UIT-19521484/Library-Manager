using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ValidateInput
    {
        public static bool ValidNoneSpCharacter(string str, out string errMsg)
        {
            if (str.Length == 0)
            {
                errMsg = "Xin nhập trường này";
                return false;
            }

            if (!(str.All(char.IsLetter) || str.Any(char.IsWhiteSpace) || str.All(char.IsDigit)))
            {
                errMsg = "Không được chứa kí tự đặc biệt";
                return false;
            }

            errMsg = "";
            return true;
        }

        public static bool ValidNumber(string number, out string errMsg)
        {
            if (number.Length == 0)
            {
                errMsg = "Xin nhập trường này";
                return false;
            }

            if (number.All(char.IsDigit))
            {
                errMsg = "";
                return true;
            }

            errMsg = "Trường này chỉ nhập số";
            return false;
        }

        public static bool ValidName(string name, out string errMsg)
        {
            if (name.Length == 0)
            {
                errMsg = "Xin nhập trường này";
                return false;
            }

            errMsg = "";
            return true;
        }
    }
}
