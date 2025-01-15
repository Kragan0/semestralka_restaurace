using UTB.Restauracia.Infrastructure.Identity;

namespace UTB.Restauracia.Infrastructure.Database.Seeding
{
    internal class UserInit
    {
        public User GetAdmin()
        {
            User admin = new User()
            {
                Id = 1,
                FirstName = "Maros",
                LastName = "Krompac",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.cz",
                NormalizedEmail = "ADMIN@ADMIN.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEB690Jb1ElO7mx3FiF9QPX12GAIPoOeq5L3tpD5lH7UUAtNqR/ntMSph9U3ll+XyJQ==",
                SecurityStamp = "SEJEPXC646ZBNCDYSM3H5FRK5RWP2TN6",
                ConcurrencyStamp = "cff5ac9b-2e69-4305-9079-198641f3468a",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            }; //Heslo : admin
            return admin;
        }
        public User GetManager()
        {
            User manager = new User()
            {
                Id = 2,
                FirstName = "Jozef",
                LastName = "Slota",
                UserName = "manager",
                NormalizedUserName = "MANAGER",
                Email = "manager@manager.cz",
                NormalizedEmail = "MANAGER@MANAGER.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEORgsNaNmLtgkgrkdS2DpkFBe2IxmlvmjKxvjAFcaXvEmqeuilBY0DgPHQqaGp5Qzw==",
                SecurityStamp = "MAJXOSATJKOEM4YFF32Y5G2XPR5OFEL6",
                ConcurrencyStamp = "9ccad41a-9679-4407-aab7-2f837c58a184",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            }; // Heslo : manager
            return manager;
        }
    }
}
