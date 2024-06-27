using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiarioDaGratidaoV2.Shared.Entidades;

namespace DiarioDaGratidaoV2.Shared.Interfaces
{
    public interface INotaRepository
    {
        Task<Nota> GetNotaAsync(int notaId);
        Task<List<Nota>> GetAllNotasAsync();
        Task<Nota>AddNotaAsync(Nota nota);
        Task<Nota>UpdateNotaAsync(Nota nota);
        Task<Nota>DeleteNotaAsync(int id);
    }
}
