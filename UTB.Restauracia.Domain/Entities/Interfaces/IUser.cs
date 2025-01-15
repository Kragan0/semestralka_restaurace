using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Restauracia.Domain.Entities.Interfaces
{
    public interface IUser<TKey>
    {
        TKey Id { get; set; }
        string? UserName { get; set; }
        string? Email { get; set; }
        string? PhoneNumber { get; set; }
        string? FirstName { get; set; }
        string? LastName { get; set; }
    }
}
