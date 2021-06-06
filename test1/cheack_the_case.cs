using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test1
{
    class cheack_the_case
    {
        //check empty
        public static bool IsEmpty(string text, string name )
        {
            if (name != "" && text.Length == 0)
            {
                messagebox.Warning($"{name} Không được để trống!");
                return true;
            }

            return false;
        }
        //check number
        public static bool IsNumeric(string text, string name)
        {
            if (!Regex.IsMatch(text, @"^\d+$"))
            {
                messagebox.Warning($"{name} không phải là số!");
                return false;
            }
            return true;
        }
        //cheack length
        public static bool IsInRange(string text, int min, int max, string name)
        {
            if (text.Length < min)
            {
                messagebox.Warning($"{name} quá ngắn!");
                return false;
            }
            else if (text.Length > max)
            {
                messagebox.Warning($"{name} quá dài!");
                return false;
            }
            return true;
        }
        //check general
        public static bool CommonValidation(string text, int min, int max, string name)
        {
            if (IsEmpty(text, name))
            {
                return false;
            }
            else if (!IsInRange(text, min, max, name))
            {
                return false;
            }
            return true;
        }
        //cheak phone
        public static bool IsPhoneInvalid(string text)
        {
            string name = "Phone number";
            if (!Regex.IsMatch(text, @"^[0-9]*$"))
            {
                messagebox.Warning($"Số điện thoại!\n{name} include 0->9");
                return false;
            }
            return true;
        }
        //cheack mail
        public static bool IsEmailInvalid(string text)
        {
            if (!Regex.IsMatch(text, @"^\b[\w\.-]+@[\w\.-]+\.\w{2,4}\b$"))
            {
                messagebox.Warning($"Địa chỉ email không hợp lệ !");
                return false;
            }
            return true;
        }
    }
}
