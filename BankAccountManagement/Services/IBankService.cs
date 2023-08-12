using System;
namespace BankAccountManagement.Services
{
	internal interface IBankService
	{
        User[] Users { get; }
        public void UserRegistration( string name, string surname, string password,  string email, bool isAdmin);
        public void UserLogin(string newemail, string newpassword);
        public void FindUserbyEmail(string searcingemail);
        public void CheckBalance(string email);
        public void TopUpBalance(string email, double additionBalance);
        public void ChangePassword(string email, string oldPassword, string newPassword);
        public void BankUserList();
        public void BlockUser(string searchingEmail);

    }
}

