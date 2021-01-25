using System;

namespace Interfaces
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Server Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Server Updated");
        }
    }
}
