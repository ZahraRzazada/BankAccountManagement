using System;
namespace BankAccountManagement.Services
{
    internal static class MenuService
    {
        private  static BankService _bankService;

        static MenuService()
        {
            _bankService = new BankService();
        }
        public static void UserRegistration()
        {
            Console.WriteLine("Zehmet olmasa adinizi daxil edin:");
        name:
               

                string name = Console.ReadLine();
                if (name.Length <= 2)
                {
                    Console.WriteLine("Zehmet olmasa duzgun ad daxil edin");
                    goto name;
                }

            Console.WriteLine("Zehmet olmasa soyadnizi daxil edin:");
        surName:

            string surName = Console.ReadLine();
            if (surName.Length <= 2)
            {
                Console.WriteLine("Zehmet olmasa duzgun ad daxil edin");
                goto surName;
            }

            Console.WriteLine("Zehmet olmasa emailinizi daxil edin:");
        email:

            string email = Console.ReadLine();
            if (!email.Contains('@'))
            {
                Console.WriteLine("Zehmet olmasa duzgun email daxil edin");
                goto email;
            }

            Console.WriteLine("Zehmet olmasa parolunuzu daxil edin:");
        password:
            bool result = false;
            string password = Console.ReadLine();
            if (password.Length > 7)
            {
                bool hasUpper = false;
                bool hasLower = false;
                foreach (char letter in password)
                {

                    if (char.IsUpper(letter))
                    {
                        hasUpper = true;
                    }
                    else if (char.IsLower(letter))
                    {
                        hasLower = true;
                    }
                }

                result = hasUpper && hasLower;

            }
            if (!result)
            {
                Console.WriteLine("Zehmet olmasa duzgun parol daxil edin");
                goto password;

            }

            Console.WriteLine("Admin olub olmadiginizi daxil edin(true or false):");
            bool isAdmin = Boolean.TryParse(Console.ReadLine(), out isAdmin);

            _bankService.UserRegistration(name, surName,  email, password, isAdmin);
        }
        public static void UserLogin()
        {
            Console.WriteLine("Zehmet olmasa girish etmek istediyiniz emaili daxil edin");
         
        email:

            string email = Console.ReadLine();
            if (!email.Contains('@'))
            {
                Console.WriteLine("Zehmet olmasa duzgun email daxil edin");
                goto email;
            }
         
            Console.WriteLine("Zehmet olmasa hemin emailin sifresini daxil edin");

        password:
            bool result= false;
            string password = Console.ReadLine();
            if (password.Length > 7)
            {
                bool hasUpper = false;
                bool hasLower = false;
                foreach (char letter in password)
                {

                    if (char.IsUpper(letter))
                    {
                        hasUpper = true;
                    }
                    else if (char.IsLower(letter))
                    {
                        hasLower = true;
                    }
                }

                result = hasUpper && hasLower;
            }
            if (!result)
            {
                Console.WriteLine("Zehmet olmasa duzgun parol daxil edin");
                goto password;

            }
        
            _bankService.UserLogin(email, password);
        }
        public static void FindUserByEmail()
        {
            Console.WriteLine("Tapmaq istediyiniz userin emailini daxil edin:");
            string email = Console.ReadLine();
            _bankService.FindUserbyEmail(email);
        }
        public static void CheckBalance()
        {
            Console.WriteLine("Balansini yoxlamaq istediyniz emaili daxil edin:");
            string email = Console.ReadLine();
            _bankService.CheckBalance(email);
        }
        public static void TopUpBalance()
        {
            Console.WriteLine("Balansini artirmaq istediyniz emaili daxil edin:");
            string email = Console.ReadLine();
            Console.WriteLine("Balansi ne qeder artirmaq istediyinizi qeyd edin:");
            double additionBalance = Convert.ToDouble(Console.ReadLine());
            _bankService.TopUpBalance(email,additionBalance);
        }
        public static void ChangePassword()
        {
            Console.WriteLine("Parolunu deyismek istediyiniz emaili daxil edin");
            string email= Console.ReadLine();
            Console.WriteLine("Hemin emailin kohne parolunu daxil edin:");
            string oldPassword= Console.ReadLine();
            Console.WriteLine("Yeni parolu daxil edin");
            string newPassword= Console.ReadLine();
            _bankService.ChangePassword(email,oldPassword,newPassword);
        }
        public static void BankUserList()
        {
            _bankService.BankUserList();
        }
        public static void BlockUser()
        {
            Console.WriteLine("Bloklamaq istediyiniz emaili qeyd edin:");
            string email = Console.ReadLine();
            _bankService.BlockUser(email);
        }
    }
}

