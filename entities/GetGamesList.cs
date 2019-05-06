using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using entities.viewmodels;

namespace entities
{
    public class GetGamesData
    {
        public IEnumerable<GamesDataList> Get()
        {
           return new List<GamesDataList>(){
                new GamesDataList(){
                    id = 1,
                    Name = "Final Fantasy III",
                    Genre = "RPG",
                    System = "SNES",
                    Price = Convert.ToDecimal(59.99)
                },
                new GamesDataList(){
                    id = 2,
                    Name = "Final Fantasy VI",
                    Genre = "RPG",
                    System = "SNES",
                    Price = Convert.ToDecimal(69.99)
                },
                new GamesDataList(){
                    id = 29,
                    Name = "Dota 2",
                    Genre = "MOBA",
                    System = "PC",
                    Price = Convert.ToDecimal(25.90)
                }
            };

            
        }
    }
}
