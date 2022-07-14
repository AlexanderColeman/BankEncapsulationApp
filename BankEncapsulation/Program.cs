using BankEncapsulation;

var account1 = new BankAccount();

account1.Deposite(121);
account1.Deposite(165);
account1.Deposite(78);

Console.WriteLine(account1.GetBalance()); 
