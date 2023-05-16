using Microsoft.AspNetCore.Identity;

namespace Stocks.Data.Entities;

public class AppUser : IdentityUser<int>
{
    public List<AppRole> Roles { get; set; } = null!;
}