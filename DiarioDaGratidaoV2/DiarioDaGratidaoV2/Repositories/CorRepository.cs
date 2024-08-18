using DiarioDaGratidaoV2.Context;
using DiarioDaGratidaoV2.Shared.Entidades;
using Microsoft.EntityFrameworkCore;
using DiarioDaGratidaoV2.Shared.Interfaces;

namespace DiarioDaGratidaoV2.Repositories
{
    public class CorRepository : ICorRepository
    {
        private readonly NotaContext _context;

        public CorRepository(NotaContext context)
        {
            _context = context;
        }

        public async Task<Cor> GetCorAsync(int corId)
        {
            return await _context.Cores.FindAsync(corId);
        }

        public async Task<List<Cor>> GetAllCoresAsync()
        {
            return await _context.Cores.ToListAsync();
        }

        public async Task<Cor> AddCorAsync(Cor cor)
        {
            if (cor == null) return null!;

            var nhk = await _context.Cores.FindAsync(cor.Id);
            if (nhk != null) return null!;

            var novaCor = _context.Cores.Add(cor).Entity;
            await _context.SaveChangesAsync();
            return novaCor;
        }

        public async Task<Cor> UpdateCorAsync(Cor cor)
        {
            var corUpdate = await _context.Cores.FindAsync(cor.Id);
            if (corUpdate == null) return null!;

            corUpdate.Nome = cor.Nome;
            corUpdate.Hexa = cor.Hexa;

            await _context.SaveChangesAsync();
            return await _context.Cores.FindAsync(cor.Id);
        }

        public async Task<Cor> DeleteCorAsync(int id)
        {
            var cor = await _context.Cores.FindAsync(id);
            if (cor == null) return null!;

            _context.Cores.Remove(cor);
            await _context.SaveChangesAsync();
            return cor;
        }
    }
}
