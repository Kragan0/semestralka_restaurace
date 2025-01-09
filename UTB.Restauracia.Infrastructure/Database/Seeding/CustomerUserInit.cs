using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Infrastructure.Database.Seeding
{
    internal class CustomerUserInit
    {
        public IList<CustomerUser> GetUser3()
        {
            IList<CustomerUser> users = new List<CustomerUser>();

            users.Add(new CustomerUser()
            {
                Id = 1,
                Username = "Milosko",
                FullName = "Milos Kapusta",
                Password = "secretPa55w0rd",
                Email = "kapusticka45@gmail.com",
                Phone = "1234567890"

            });

            users.Add(new CustomerUser()
            {
                Id = 2,
                Username = "Samko",
                FullName = "Samko Sneky",
                Password = "secretPa55w0rd",
                Email = "sneg@gmail.com",
                Phone = "1234567890"

            });

            users.Add(new CustomerUser()
            {
                Id = 3,
                Username = "Matko",
                FullName = "Matko Mrkva",
                Password = "secretPa55w0rd",
                Email = "Mrkva@gmail.com",
                Phone = "1234567890"

            });

            return users;
        }
    }
}
