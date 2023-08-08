using System;
namespace BankAccountManagement
{
	internal class User
	{
		public int Id;
		string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value.Length>2)
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
                if (value.Length > 2)
                {
                    _surName = value;
                }
            }
        }
        public double Balance;
		string _email;
		public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Contains('@'))
                {
                    _email = value;
                }
            }
        }
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

		//public User(string name,string surname,string email,string password)
		//{
  //          Name = name;
  //          SurName = surname;
  //          Email = email;
  //          Password = password;
		//}
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

		
	}
}

