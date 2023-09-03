//add reference of LoanApp.Services namespace in Program.cs file
using LoanApp.Services;
//add reference of LoanApp.Models namespace in Program.cs file
using LoanApp.Models;
class Program{
    static void Main(string[] args){
        //create instance of LoanApplication class and set the value of its properties
        LoanApplication loanApplication = new LoanApplication();
        loanApplication.LoanAmount = 200000;
        loanApplication.InterestRate = 0.035m;
        loanApplication.TermInYears = 30;
        //create instance of Customer class and set the value of its properties
        Customer customer = new Customer();
        customer.FirstName = "John";

        customer.LastName = "Smith";
        customer.DateOfBirth = new System.DateTime(1980, 1, 1);
        customer.CreditScore = 800;
        customer.LoanApplication = loanApplication;
        //create instance of LoanManagerApproval class
        LoanManagerApproval loanManagerApproval = LoanManagerApproval.Instance;
        //call ApproveLoan method on loanManagerApproval object
        bool isApproved = loanManagerApproval.ApproveLoan(customer);
        //print the value of isApproved variable
        System.Console.WriteLine(isApproved);
        //create instance of LoanManager class and call ProcessLoan method on it
        LoanManager loanManager = new LoanManager();    
        //call ProcessLoan method on loanManager object
        bool isLoanProcessed = loanManager.ProcessLoan(customer);
    //print the loan status
        System.Console.WriteLine(isLoanProcessed ? "Loan Approved" : "Loan Rejected");


    }
}
