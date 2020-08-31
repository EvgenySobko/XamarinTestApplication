using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Refit;
using TestApp2.Entities;

namespace TestApp2{
    public interface IApi{
        
        [Get("/beers")]
        Task<List<Beer>>? GetAllBeers();

        [Get("/beers/{id}")]
        Task<List<Beer>>? GetBeerById([AliasAs("id")] int id);
    }
}