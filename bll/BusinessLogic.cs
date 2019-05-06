using System;
using System.Collections.Generic;
using System.Linq;
using entities;
using entities.viewmodels;
using System.Threading.Tasks;
using entities.Contexts;
using Microsoft.EntityFrameworkCore;

namespace bll
{
    public class BusinessLogic : IBusinessLogic
    {
        GamesContext _context;
        GetGamesData GetGames = new GetGamesData();

        public BusinessLogic(GamesContext context)
        {
            _context = context;
        }     
        public async Task<IEnumerable<GamesDataList>> GetAllGames()
        {
            return await _context.gamesdblist.ToListAsync();
        }
        /*
        async Task<IEnumerable<GamesDataList>> testing()
        {d
            return GetGames.Get();
        }
        
        public async Task<IEnumerable<GamesDataList>> GetAllGames1()
        {
            var result = await testing();
            return result;
        }
        */
        /*
         public GamesDataList GetDataID(int id)
        {
            var result = GetGames.Get().FirstOrDefault(t => t.id == id);
            return result;
        }
        
        public IEnumerable<GamesDataList> GetGamesByName(string name)
        {
            var result = GetGames.Get().Where(t=>t.Genre.ToLower().Contains(name));
            return result;
        }
        
        public IEnumerable<GamesDataList> SearchFilterGames(int count, int page, string search)
        {
          var result = GetGames.Get().Where(t=>t.Name.ToLower().Contains(search.ToLower())
            || t.Genre.ToLower().Contains(search.ToLower()) || t.System.ToLower().Contains(search.ToLower()));
            return result.Skip((page - 1) * count).Take(count) ;
        }

         */

    }
}
