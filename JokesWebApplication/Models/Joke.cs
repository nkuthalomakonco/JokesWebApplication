using Humanizer;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace JokesWebApplication.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; } = string.Empty;
        public string JokeAnswer { get; set; } = string.Empty;

        // Foreign key to the Identity user
        public string UserId { get; set; } = string.Empty;

        // Navigation property
        public IdentityUser? User { get; set; }

        public Joke()
        {

        }
    }
}
