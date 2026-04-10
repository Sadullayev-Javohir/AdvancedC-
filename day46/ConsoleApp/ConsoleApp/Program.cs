// class Account
// {
//     public string AccountNumber { get; set; }
//     public decimal Balance { get; private set; }
//
//     public bool CanWithdraw(decimal amount) => Balance >= amount;
//
//     public void Witdhraw(decimal amount)
//     {
//         if (CanWithdraw(amount)) Balance -= amount;
//     }
// }

// class Book
// {
//     public string Title { get; set; }
//     public int Copies { get; set; }
// }
//
// class Library
// {
//     public List<Book> Books { get; set; }
//
//     public bool CanBorrow(Book book)
//     {
//         if (book.Copies > 0) return true;
//         return false;
//     }
// }

// class Book
// {
//     public string Title { get; set; }
//     public int Copies { get; set; }
//
//     public bool CanBorrow() => Copies > 0;
// }
//
// class Library
// {
//     public List<Book> Books { get; set; }
//
//     public bool BorrowBook(Book book)
//     {
//         if (book.CanBorrow())
//         {
//             book.Copies--;
//             return true;
//         }
//
//         return false;
//     }
// }


// class BankAccount
// {
//     public string Name { get; set; }
//     public decimal Balance { get; set; }
// }
//
// class Bank
// {
//     public bool CanWithdraw(BankAccount account, decimal amount)
//     {
//         if (account.Balance >= amount) return true;
//         return false;
//     }
//
//     public bool Witdhraw(BankAccount account, decimal amount)
//     {
//         if (CanWithdraw(account, amount)) account.Balance -= amount;
//         return true;
//     }
// }

class BankAccount
{
    public string Name { get; set; }
    public decimal Balance { get; private set; }

    public bool CanWithdraw(decimal amount) => Balance >= amount;

    public bool Withdraw(decimal amount)
    {
        if (!CanWithdraw(amount)) return false;

        Balance -= amount;
        return true;
    }
}

class Bank
{
    public void ProcessWitdraw(BankAccount account, decimal amount)
    {
        if (account.Withdraw(amount)) Console.WriteLine("Pul yechildi");
        else Console.WriteLine("Balans yetarli emas");
    }
}