// Assignment 4: Interfaces – Payment Gateway System
csharpCopyEditusing System;using System.Collections.Generic;
interface IPayment{
    void Pay();
    void Refund();
}
class CreditCardPayment : IPayment{
    public string CardNumber { get; set; }
    public CreditCardPayment(string cardNumber)
    {
        CardNumber = cardNumber;
    }
    public void Pay()
    {
        Console.WriteLine($"Paid using Credit Card: {CardNumber}");
    }
    public void Refund()
    {
        Console.WriteLine($"Refund to Credit Card: {CardNumber}");
    }
}
class UPIPayment : IPayment{
    public string UPIID { get; set; }
    public UPIPayment(string upiID)
    {
        UPIID = upiID;
    }
    public void Pay()
    {
        Console.WriteLine($"Paid using UPI: {UPIID}");
    }
    public void Refund()
    {
        Console.WriteLine($"Refund to UPI: {UPIID}");
    }
}


csharpCopyEdit// Main method class Program{
    static void Main(string[] args)
    {
        List<IPayment> payments = new List<IPayment>
        {
            new CreditCardPayment("1234-5678-9012-3456"),
            new UPIPayment("user@upi")
        };
        foreach (var payment in payments)
        {
            payment.Pay();
            payment.Refund();
        }
    }
}
