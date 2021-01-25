namespace Interfaces
{
    class CustomerManager
    {
        public void Add(ICustomerDal customer)
        {
            customer.Add();

        }
    }
}
