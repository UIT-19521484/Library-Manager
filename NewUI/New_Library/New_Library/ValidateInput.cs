using System;
using System.Linq;

namespace New_Library
{
    public class ValidateInput
    {
        public static bool IsEmpty(string str, out string errMsg)
        {
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] != ' ')
            //    {
            //        errMsg = "";
            //        return false;
            //    }   
            //}
            //errMsg = "Trường này không được trống";
            //return true;

            //if (str.Length == 0 || str == "")
            //{
            //    errMsg = "Trường này không được trống";
            //    return true;
            //}
            //errMsg = "";
            //return false;

            if (string.IsNullOrWhiteSpace(str))
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

        public static bool ValidOnlyLetter(string str, out string errMsg)
        {
            
            //if (!IsEmpty(str, out errMsg))
            //{
            //    var regexItem = new System.Text.RegularExpressions.Regex("^[a-zA-Z ]*$");

            //    if (!regexItem.IsMatch(str))
            //    {
            //        errMsg = "Không được chứa kí tự đặc biệt và chữ số";
            //        return false;
            //    }
            //    else
            //    {
            //        errMsg = "";
            //        return true;
            //    }
            //}

            //return false;

            //ĐỂ VIẾT TIẾNG VIỆT
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,0123456789";
            foreach (var item in specialChar)
            {
                if (str.Contains(item))
                {
                    errMsg = "Không được chứa kí tự đặc biệt và chữ số";
                    return false;
                }
            }
            errMsg = "";
            return true;
        }

        public static bool ValidNoneSpecialChar(string str, out string errMsg)
        {
            if (!IsEmpty(str, out errMsg))
            {
                var regexItem = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9 ]*$");

                if (!regexItem.IsMatch(str))
                {
                    errMsg = "Chỉ cho phép các kí tự a-z, A-Z, 0-9";
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
