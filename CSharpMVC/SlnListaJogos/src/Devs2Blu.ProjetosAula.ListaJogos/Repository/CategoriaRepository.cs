using Devs2Blu.ProjetosAula.ListaJogos.Models;
using Devs2Blu.ProjetosAula.ListaJogos.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.ListaJogos.Repository
{
    public class CategoriaRepository
    {
        private readonly ContextoDatabase _context;

        public CategoriaRepository(ContextoDatabase context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Categoria>> GetAll()
        {
            return await _context.Categoria.ToListAsync();
        }

        public async Task<int> SaveCategoria(Categoria categoria)
        {
            _context.Add(categoria);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateCategoria(Categoria categoria)
        {
            _context.Update(categoria);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteCategoria(Categoria categoria)
        {
            _context.Remove(categoria);
            return await _context.SaveChangesAsync();
        }
    }
}
