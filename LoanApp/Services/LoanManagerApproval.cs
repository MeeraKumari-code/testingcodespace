namespace LoanApp.Services
{
    //implement singleton design pattern
    public class LoanManagerApproval
    {
        private static LoanManagerApproval _instance;
        private LoanManagerApproval() { }
        public static LoanManagerApproval Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoanManagerApproval();
                }
                return _instance;
            }
        }
        //create method named as ApproveLoan
        //Approve Loan if Customer Age is between 18 and 50
        //and Loan Amount is between 200000 and 300000

        public bool ApproveLoan(Models.Customer customer)
        {
            if (customer.Age >= 18 && customer.Age <= 50)
            {
                if (customer.LoanApplication.LoanAmount >= 200000 && customer.LoanApplication.LoanAmount <= 300000)
                {
                    return true;
                }
            }
            return false;
        }
    }

}