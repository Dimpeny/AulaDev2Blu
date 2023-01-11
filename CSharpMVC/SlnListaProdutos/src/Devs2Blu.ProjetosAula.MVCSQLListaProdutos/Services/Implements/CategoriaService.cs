using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Repository;
using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Services.Interfaces;

namespace Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Services.Implements
{
    public class CategoriaService : ICategoriaService
    {
        private readonly CategoriaRepository _repository;

        public CategoriaService(CategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Categoria>> GetAllCategorias()
        {
            return await _repository.GetAll();
        }

        public async Task<int> Save(Categoria categoria)
        {
            return await _repository.SaveCategoria(categoria);
        }

    }
}
