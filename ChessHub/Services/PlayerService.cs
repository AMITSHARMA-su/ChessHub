using ChessHub.Data;
using ChessHub.Models;
using Microsoft.AspNetCore.Identity;

namespace ChessHub.Services
{
    public class PlayerService
    {
        private readonly ApplicationDbContext _context;

        public PlayerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreatePlayerAsync(IdentityUser user)
        {
            var player = new Player
            {
                UserId = user.Id,
                Username = user.UserName!,
                Rating = 1000
            };

            _context.Players.Add(player);
            await _context.SaveChangesAsync();
        }
    }
}