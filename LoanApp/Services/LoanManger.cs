namespace LoanApp.Services
{
    //create a class named as LoanManager and add a method named as ProcessLoan and make a call to ApproveLoan method of LoanManagerApproval class
    public class LoanManager
    {
        public bool ProcessLoan(Models.Customer customer)
        {
            return LoanManagerApproval.Instance.ApproveLoan(customer);
        }
    }

}