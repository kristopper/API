using System.Collections.Generic;
using System.Threading.Tasks;
using entities.viewmodels;

namespace bll
{
  public interface IBusinessLogic
 {
    Task<IEnumerable<GamesDataList>> GetAllGames();
   // GamesDataList GetDataID(int id);
   // IEnumerable<GamesDataList> GetGamesByName(string name);
   // IEnumerable<GamesDataList> SearchFilterGames(int count, int page, string search);
 }
}
