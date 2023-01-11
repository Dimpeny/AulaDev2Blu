using Devs2Blu.ProjetosAula.ListaJogos.Models.Entities;

namespace Devs2Blu.ProjetosAula.ListaJogos.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetAllCategorias();
        Task<int> Save(Categoria categoria);

        Task<int> Update(Categoria categoria);
        
        Task<int> Delete(Categoria categoria);
    }
}
