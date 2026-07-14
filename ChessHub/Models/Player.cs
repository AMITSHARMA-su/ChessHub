using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
namespace ChessHub.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; } = string.Empty;
        public IdentityUser? User { get; set; }
        [Required]
        public string Username { get; set; } = string.Empty;
        public int Rating { get; set; } = 1000;
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public DateTime JoinedOn { get; set; } = DateTime.Now;

    }
}
