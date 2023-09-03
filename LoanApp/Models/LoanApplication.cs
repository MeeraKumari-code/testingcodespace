namespace LoanApp.Models
{
    // create Loanpplication class with properties: LoanAmount, InterestRate, TermInYears 
    public class LoanApplication
    {
        public decimal LoanAmount { get; set; }
        public decimal InterestRate { get; set; }
        public int TermInYears { get; set; }
    }
}