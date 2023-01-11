using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Models.Entities;

namespace Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetAllCategorias();
        Task<int> Save(Categoria categoria);
    }


}
