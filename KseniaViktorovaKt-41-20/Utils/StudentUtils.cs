using KseniaViktorovaKt_41_20.Models;
using System.Text.RegularExpressions;

namespace KseniaViktorovaKt_41_20.Utils
{
    public class StudentUtils
    { 
        public static bool IsAdult(Student student)
        {
            DateTime eighteenYearsAgo = DateTime.Now.AddYears(-18);
            DateTime dateOfBirth = Convert.ToDateTime(student.DateBirth);

            return dateOfBirth <= eighteenYearsAgo;
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^\+7\(\d{3}\)\d{3}-\d{2}-\d{2}$");

            return regex.IsMatch(phoneNumber);
        }

        public static bool IsValidEmail(string email)
        {
            Regex regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");

            return regex.IsMatch(email);
        }

    }
}
