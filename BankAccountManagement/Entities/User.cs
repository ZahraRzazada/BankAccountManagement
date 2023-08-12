using System;
namespace BankAccountManagement
{
	internal class User
	{
        static int Id;
		string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (CheckName(value))
				{
					_name = value;
				}
			}
		}
		string _surName;
		public string SurName
        {
            get
            {
                return _surName;
            }
            set
            {
                if (CheckSurName(value))
                {
                    _surName = value;
                }
            }
        }
    
		string _email;
		public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (CheckEmail(value))
                {
                    _email = value;
                }
            }
        }
        public double Balance = 0;
        string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
            }
        }
        public bool IsAdmin;
		public bool IsBlocked;
		public bool IsLogged;
        static User()
        {
            Id = 0;
            Id++;
          
        }

        public User( string name, string surname, string email, string password, bool isAdmin = false, bool isBlocked = false ,bool isLogged=false)
        {
            Name = name;
            SurName = surname;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
            
        }
        public bool CheckName(string name)
        {
            //Console.WriteLine("Please write name:");
        name:
            //string resultName = Console.ReadLine();
            if (name.Length <= 2)
            {
                Console.WriteLine("Please write valid name");
                goto name;
            }
            return true;
        }
        public bool CheckSurName(string SurName)
        {
            //Console.WriteLine("Please write surname:");
        surName:
            //string resultsurName = Console.ReadLine();
            if (SurName.Length <= 2)
            {
                Console.WriteLine("Please write valid surname");
                goto surName;
            }
            return true;
        }
       
        public bool CheckEmail(string email)
        {

        //    Console.WriteLine("Email yazin:");
        email:
            //    string resultEmail = Console.ReadLine();
            if (!email.Contains('@'))
            {
                Console.WriteLine("Please write valid email");
                goto email;
            }
            return true;
        }
        public bool CheckPassword(string pw)
		{
			bool result = default;
			if (pw.Length>7)
			{
                bool hasUpper = false;
                bool hasLower = false;
                foreach (char letter in pw)
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

                result =  hasUpper && hasLower;

            }
            return result;
        }

        public override string ToString()
        {
            return $"UserName: {Name}, UserSurname: {SurName},  UserEmail: {Email} , UserPassword: {Password}, UserIsAdmin :{IsAdmin}";
        }

    }
}

