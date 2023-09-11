// See https://aka.ms/new-console-template for more information
interface IPersonalDetails
{
    void showDetails();
}
interface IAccountDetails
{
    void showAccountDetails();
    void showBalance();
}
class Bank : IAccountDetails, IPersonalDetails
{
    public void showBalance(){
        
    }
    public void showDetails() { }
    public void showAccountDetails()
    {

    }
}