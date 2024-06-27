using DiarioDaGratidaoV2.Context;
using DiarioDaGratidaoV2.Shared.Entidades;
using Microsoft.EntityFrameworkCore;
using DiarioDaGratidaoV2.Shared.Interfaces;

namespace DiarioDaGratidaoV2.Repositories
{
    public class NotaRepository : INotaRepository
    {
        private readonly NotaContext _context;

        public NotaRepository(NotaContext context)
        {
            _context = context;
        }

        public async Task<Nota> GetNotaAsync(int notaId)
        {
            return await _context.Notas.FindAsync(notaId);
        }

        public async Task<List<Nota>> GetAllNotasAsync()
        {
            return await _context.Notas.ToListAsync();
        }

        public async Task<Nota> AddNotaAsync(Nota nota)
        {
            if (nota == null) return null!;

            var nhk = await _context.Notas.FindAsync(nota.Id);
            if (nhk != null) return null!;

            var novaNota = _context.Notas.Add(nota).Entity;
            await _context.SaveChangesAsync();
            return novaNota;
        }

        public async Task<Nota> UpdateNotaAsync(Nota nota)
        {
            var notaUpdate = await _context.Notas.FindAsync(nota.Id);
            if (notaUpdate == null) return null!;

            notaUpdate.Conteudo = nota.Conteudo;
            notaUpdate.DataCriacao = DateTime.Now;

            await _context.SaveChangesAsync();
            return await _context.Notas.FindAsync(nota.Id);
        }

        public async Task<Nota> DeleteNotaAsync(int id)
        {
            var nota = await _context.Notas.FindAsync(id);
            if (nota == null) return null!;

            _context.Notas.Remove(nota);
            await _context.SaveChangesAsync();
            return nota;
        }
    }
}
