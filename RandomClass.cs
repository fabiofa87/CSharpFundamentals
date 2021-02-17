using System;

namespace RandomClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            const int passwordLength = 10;

            var password = new char[passwordLength];
            for(var i = 0; i < passwordLength; i++)
            
                password[i] = (char)('a' + random.Next(0, 26));

                var newPassword = new string(password);

                Console.Write(newPassword);
                
            
            
        }
    }
}
