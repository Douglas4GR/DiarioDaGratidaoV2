using DiarioDaGratidaoV2.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDaGratidaoV2.Shared.Interfaces
{
    public interface ICorRepository
    {
        Task<Cor> GetCorAsync(int id);
        Task<List<Cor>> GetAllCoresAsync();
        Task<Cor>AddCorAsync(Cor cor);
        Task<Cor> UpdateCorAsync(Cor cor);
        Task<Cor> DeleteCorAsync(int id);

    }
}
