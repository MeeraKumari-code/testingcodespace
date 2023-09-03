namespace LoanApp.Models
{
    // create Customer class with properties: FirstName, LastName, DateOfBirth, CreditScore and LoanApplication
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
   
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year; // expression-bodied property
        
        public string FullName => $"{FirstName} {LastName}"; // expression-bodied property
        public System.DateTime DateOfBirth { get; set; }
        public int CreditScore { get; set; }
        public LoanApplication LoanApplication { get; set; }
    }
    
}