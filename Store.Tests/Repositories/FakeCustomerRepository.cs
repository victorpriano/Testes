using Store.Domain.Entities;

namespace Store.Tests.Repositories
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public Customer Get(string document)
        {
            if(document == "12345678911")
                return new Customer("Bruce Wayne", "victor@curu");
            
            return null;
        }
    }
}