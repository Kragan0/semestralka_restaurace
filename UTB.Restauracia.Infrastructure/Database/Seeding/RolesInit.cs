using UTB.Restauracia.Infrastructure.Identity;
namespace UTB.Restauracia.Infrastructure.Database.Seeding
{
    internal class RolesInit
    {
        public List<Role> GetRolesAMC()
        {
            List<Role> roles = new List<Role>();
            Role roleAdmin = new Role()
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "9cf14c2c-19e7-40d6-b744-8917505c3106"
            };
            roles.Add(roleAdmin);

            Role roleManager = new Role()
            {
                Id = 2,
                Name = "Manager",
                NormalizedName = "MANAGER",
                ConcurrencyStamp = "be0efcde-9d0a-461d-8eb6-444b043d6660"
            };
            roles.Add(roleManager);

            Role roleCustomer = new Role()
            {
                Id = 3,
                Name = "Customer",
                NormalizedName = "CUSTOMER",
                ConcurrencyStamp = "29dafca7-cd20-4cd9-a3dd-4779d7bac3ee"
            };
            roles.Add(roleCustomer);

            return roles;
        }
    }
}