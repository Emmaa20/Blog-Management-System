﻿using Blog_Management_System.Database.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blog_Management_System.ApplicationLogic.Validations
{
    public class UserValidation
    {

        public static bool IsNameValid(string name)
        {
            Regex regex = new Regex(@"^[A-Z]+[a-z]{3,30}");

            return regex.IsMatch(name);
        }

        public static bool IsSurnameValid(string surname)
        {
            Regex regex = new Regex(@"^[A-Z]+[a-z]{4,29}");

            return regex.IsMatch(surname);
        }

        public static bool IsEmailValid(string email)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]{10,20}@code.edu.az$");

            return regex.IsMatch(email);
        }

        public static bool IsPasswordValid(string password)
        {
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$");

            return regex.IsMatch(password);
        }

        public static bool IsPasswordsMatch(string password, string confirmPassword)
        {
            if (confirmPassword == password)
            {
                return true;
            }
            Console.WriteLine("Password is not match");
            return false;
        }



        public static bool IsUserExitsUnique(string email)
        {
            if (UserRepository.IsUserExitsByEmail(email))
            {
                Console.WriteLine("User already exists");
                return true;
            }
            return false;
        }
    }
}
        //public static bool IsLengthCorrect(string text, int startLengt, int endLength)
        //{
        //    return text.Length >= startLengt && text.Length <= endLength;
        //}

