using System;
using System.Linq;

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

        public static bool ValidVietnamesePhone(string phNumber, out string errMsg)
        {
            if (!IsEmpty(phNumber, out errMsg))
            {
                if (System.Text.RegularExpressions.Regex.Match(phNumber, @"^(0|\+84)[35789]\d{8}$").Success)
                {
                    errMsg = "";
                    return true;
                }
                errMsg = "Số điện thoại không hợp lệ";
                return false;
            }
            return false;
        }

        public static bool ValidNoneSpecialChar(string str, out string errMsg)
        {
            //if (str.Length == 0)
            //{
            //    errMsg = "Trường này không được trống";
            //    return true;
            //}
            //else if (!(str.All(char.IsLetter) || str.Any(char.IsWhiteSpace) || str.All(char.IsDigit)))
            //{
            //    errMsg = "Không được chứa kí tự đặc biệt";
            //    return false;
            //}

            if (!IsEmpty(str, out errMsg))
            {
                if (!(str.All(char.IsLetter) || str.Any(char.IsWhiteSpace) || str.All(char.IsDigit)))
                {
                    errMsg = "Không được chứa kí tự đặc biệt";
                    return false;
                }
                else
                {
                    errMsg = "";
                    return true;
                }
            }

            return false;
        }

        public static bool ValidEmail(string email, out string errMsg)
        {
            if (!IsEmpty(email, out errMsg))
            {
                //if (email.IndexOf("@") > -1)
                //{
                //    if (email.IndexOf(".", email.IndexOf("@")) > email.IndexOf("@"))
                //    {
                //        errMsg = "";
                //        return true;
                //    }
                //}

                //errMsg = "Email không hợp lệ";
                //return false;

                try
                {
                    System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(email);

                    errMsg = "";
                    return true;
                }
                catch (FormatException)
                {
                    errMsg = "Email không hợp lệ";
                    return false;
                }
            }

            return false;
        }
    }
}
