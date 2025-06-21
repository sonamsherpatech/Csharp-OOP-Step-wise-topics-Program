using System;

namespace _8.PropertiesAndTypes
{
    class UserProfile
    {
        //Auto-Implemented property
        public string UserName { get; set; }
        private string email;

        //Read-Only Property
        public string Email
        {
            get { return email; }
        }
        //using constructor to write the email property
        public UserProfile(string email)
        {
            this.email = email;
        }

        private string password;
        //Write-Only Property
        public string Password
        {
            set { password = value; }
        }

        private int age;
        //Read-Write Property
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

    class PropertyEx2
    {
        public static void Main()
        {
            UserProfile p1 = new UserProfile("hello@gmail.com");
            p1.UserName = "xhello";
            p1.Password = "hello123";
            p1.Age = 22;

            Console.WriteLine("User Profile");
            Console.WriteLine($"{p1.UserName}\t{p1.Email}\t{p1.Age}\nEdit");
        }
    }
}
