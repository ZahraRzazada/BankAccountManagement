using BankAccountManagement;
using BankAccountManagement.Services;

Console.WriteLine("Istediyiniz prosesi secin!");
Console.WriteLine("       ");

//MenuService.UserRegistration();
//MenuService.UserLogin();


byte selection;
do

{
    Console.WriteLine("1.User Registration");
    Console.WriteLine("2.User Login");
    Console.WriteLine("3.Find User");
    Console.WriteLine("0.Exit");
    bool result = byte.TryParse(Console.ReadLine(), out selection);

    if (result)
    {
        switch (selection)
        {
            case 1:
                MenuService.UserRegistration();
                break;
            case 2:
                MenuService.UserLogin();
                byte selection2;
                do
                {
                    Console.WriteLine("1.Check Balanse");
                    Console.WriteLine("2.Top Up Balance");
                    Console.WriteLine("3.Change Password");
                    Console.WriteLine("4.Bank User List");
                    Console.WriteLine("5.Block User");
                    Console.WriteLine("0.Log Out");
                    bool result2 = byte.TryParse(Console.ReadLine(), out selection2);
                    
                    if (result2)
                    {
                        switch (selection2)
                        {
                            case 1:
                                
                                MenuService.CheckBalance();
                                break;
                            case 2:
                                MenuService.TopUpBalance();
                                break;
                            case 3:
                                MenuService.ChangePassword();
                                break;
                            case 4:
                                MenuService.BankUserList();
                                break;
                            case 5:
                                MenuService.BlockUser();
                                break;
                        }
                    }
                } while (selection2 != 0);
                break;
            case 3:
                MenuService.FindUserByEmail();
                break;
        }
    }
} while (selection != 0);
