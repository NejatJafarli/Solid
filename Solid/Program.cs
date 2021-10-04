using System;
using System.Collections.Generic;

namespace Solid
{
    class User // user adi parolu var
    {
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    static class CheckUser
    {
        static public bool UsernameAndPasswordSame(User user)
        {
            if (user.Password == user.Username) // username ve parolun eyni olup olmamasini yoxlayiriq
                return true;
            return false;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var user = new User("Nicat123","Nicat123");
            Console.WriteLine(CheckUser.UsernameAndPasswordSame(user)); 

        }





    }
}
