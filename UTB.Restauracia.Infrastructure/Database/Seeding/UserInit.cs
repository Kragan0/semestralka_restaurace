using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Infrastructure.Database.Seeding
{
    internal class UserInit
    {
        public IList<User> GetUser3()
        {
            IList<User> users = new List<User>();

            users.Add(new User()
            {
                Id = 1,
                Username = "Milosko",
                FullName = "Milos Kapusta",
                Password = "secretPa55w0rd",
                Email = "kapusticka45@gmail.com",
                Phone = "1234567890"

            });

            users.Add(new User()
            {
                Id = 2,
                Username = "Samko",
                FullName = "Samko Sneky",
                Password = "secretPa55w0rd",
                Email = "sneg@gmail.com",
                Phone = "1234567890"

            });

            users.Add(new User()
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
