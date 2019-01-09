using System;
using System.Collections.Generic;

namespace classes
{
    public class BankAccount
    {
		public string Number { get; }
		public string Owner { get; set; }
		public decimal Balance 
		{
			get
			{
				decimal balance = 0;
				foreach (var item in allTransactions)
				{
					balance += item.Amount;
				}

				return balance;
			}
		}
	
		private static int accountNumberSeed = 1234567890;
		private List<Transaction> allTransactions = new List<Transaction>();

		public BankAccount(string name, decimal initialBalance)
		{
			this.Owner = name;
			this.Number = accountNumberSeed.ToString();
			accountNumberSeed++;
			MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
		}

		public void MakeDeposit(decimal amount, DateTime date, string note)
		{
			if (amount <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
			}
			var deposit = new Transaction(amount, date, note);
			allTransactions.Add(deposit);
		}

		public void MakeWithdrawal(decimal amount, DateTime date, string note)
		{
			if (amount <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
			}
			if (Balance - amount < 0)
			{
				throw new InvalidOperationException("Not sufficient funds for this withdrawal");
			}
			var withdrawal = new Transaction(-amount, date, note);
			allTransactions.Add(withdrawal);
		}
		
		public void ShowTransactions()
		{
			foreach (var item in allTransactions)
			{
				Console.WriteLine($"{item.Date}, {item.Amount}, {item.Notes}");
			}
		}
    }
    
	public class Transaction
	{
		public decimal Amount { get; }
		public DateTime Date { get; }
		public string Notes { get; }

		public Transaction(decimal amount, DateTime date, string note)
		{
			this.Amount = amount;
			this.Date = date;
			this.Notes = note;
		}
	}
    
	class main 
	{
		static void Main()
		{
			var account = new BankAccount("Gerrard", 1000);
			Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

			account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
			Console.WriteLine(account.Balance);
			account.MakeDeposit(100, DateTime.Now, "friend paid me back");
			Console.WriteLine(account.Balance);

			account.ShowTransactions();
		}
	}
    
}
