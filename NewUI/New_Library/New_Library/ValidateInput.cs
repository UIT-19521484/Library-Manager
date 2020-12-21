using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Library
{
    public class ValidateInput
    {
        public static bool IsEmpty(string str, out string errMsg)
        {
            if (str.Length == 0)
            {
                errMsg = "Trường này không được trống";
                return true;
            }
            errMsg = "";
            return false;
        }

        public static bool ValidNoneSpecialChar(string str, out string errMsg)
        {
            if (str.Length == 0)
            {
                errMsg = "Trường này không được trống";
                return true;
            }
            else if (!(str.All(char.IsLetter) || str.Any(char.IsWhiteSpace) || str.All(char.IsDigit)))
            {
                errMsg = "Không được chứa kí tự đặc biệt";
                return false;
            }

            errMsg = "";
            return true;
        }

        public static bool ValidNumber(string number, out string errMsg)
        {
            if (!IsEmpty(number, out errMsg))
            {
                if (number.All(char.IsDigit))
                {
                    errMsg = "";
                    return true;
                }
            }

            errMsg = "Trường này chỉ nhập số";
            return false;
        }

        public static bool ValidEmail(string email, out string errMsg)
        {
            if (!IsEmpty(email, out errMsg))
            {
                if (email.IndexOf("@") > -1)
                {
                    if (email.IndexOf(".", email.IndexOf("@")) > email.IndexOf("@"))
                    {
                        errMsg = "";
                        return true;
                    }
                }
            }

            errMsg = "Email không hợp lệ";
            return false;
        }
    }
}
