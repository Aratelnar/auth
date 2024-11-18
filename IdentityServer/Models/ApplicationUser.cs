// using Microsoft.AspNetCore.Identity;
//
// namespace IdentityServer.Models
// {
//     public class ApplicationUser : IdentityUser
//     {
//     }
// }

using AspNetCore.Identity.Mongo.Model;

namespace IdentityServer.Models
{
    public class ApplicationUser : MongoUser<string>
    {
    }
}