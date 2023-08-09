using System;
namespace BankAccountManagement.Services
{
	public class BankService:IBankService
	{
		User[] Users;
		public BankService()
		{
			Users = new User[0];
		}
	}
}

