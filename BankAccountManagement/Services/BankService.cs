using System;
namespace BankAccountManagement.Services
{
	internal class BankService : IBankService
	{
		User[] _users;

		public User[] Users
		{
			get
			{
				return _users;
			}
		}

		public BankService()
		{
			_users = new User[0];
		}
		public void UserRegistration( string name, string surname, string password,string email, bool isAdmin)
		{
			User user = new User( name, surname, password, email, isAdmin );
			if (FindUser(email) == null)
			{
				Array.Resize(ref _users, _users.Length + 1);
				_users[_users.Length - 1] = user;
				Console.WriteLine($"{user.Name} adli user ugurla elave olundu");
			}
			else
			{
				Console.WriteLine($"{email} emaili ile bir defe login olunub,basqa email daxil edin");
			}
		}
		public void UserLogin(string email,string password)
		{

			foreach (User user in _users)
			{

				if (email == user.Email && password == user.Password)
				{

					Console.WriteLine("Siz ugurla giris etdiniz");
					return;

				}
                Console.WriteLine("Daxil etdiyiniz email ve sifre ya yalnisdir,yada bir biri ile uyusmur");

            }



		}
		public User FindUser(string email)
		{
			User existedUser = null;

			foreach (User user in _users)
			{
				if (email== user.Email)
				{
					existedUser = user;
				}
			}
			return existedUser;

		}
		public void FindUserbyEmail(string email)
		{
			User existedUser = null;
			foreach (User user in _users)
			{
				if (user.Email == email)
				{
					Console.WriteLine(user);
				}
			}
			Console.WriteLine(existedUser);
		}
		public void CheckBalance(string email)
		{

			User user = FindUser(email);
			Console.WriteLine(user.Balance);
		}
		public void TopUpBalance( string email,double additionBalance)
		{
			User user = FindUser(email);

			user.Balance += additionBalance;
		}
		public void ChangePassword(string email,string oldPassword,string newPassword)

		{

			User user = FindUser(email);
			if (oldPassword!=user.Password)
			{
				Console.WriteLine($"{oldPassword} is not valid password");
			}
			else
			{
				Console.WriteLine($"{user.Password} ugurla {newPassword} parolu ile deyisdirildi");
				user.Password = newPassword;
			}
		}
		public void BankUserList()
		{
			
				foreach (User user in _users)
				{
				
					Console.WriteLine($"User name : {user.Name}  User surname:{user.SurName}");
				
			
				}
			
		}
		public void BlockUser(string email)
		{
           
            User user = FindUser(email);
                if (user is null)
                {
                    Console.WriteLine($"{email} email tapilmadi");
                }

                else
                {
                    Console.WriteLine($"{email} ugurla blok olundu");
                }
			
            }
            
        }
	}

