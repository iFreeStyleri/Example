using Example.Core.Abstractions;
using Example.DAL;
using Example.DAL.Repositories;
using Example.Domain.Entities;

namespace Example.API
{
    public static class Program
    {
        public static AppDbContext _context { get; private set; }
        public static Task Main()
        {
            _context = new();
            IBaseRepository<Game> gameRepo = new BaseRepository<Game>(_context);
            IBaseRepository<GameType> gameTypeRepo = new BaseRepository<GameType>(_context);
            IBaseRepository<User> userRepo = new BaseRepository<User>(_context);
            return Task.CompletedTask;
        }
    }
}