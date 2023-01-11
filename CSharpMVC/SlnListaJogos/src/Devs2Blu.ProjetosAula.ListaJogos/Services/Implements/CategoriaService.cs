using Devs2Blu.ProjetosAula.ListaJogos.Models.Entities;
using Devs2Blu.ProjetosAula.ListaJogos.Repository;
using Devs2Blu.ProjetosAula.ListaJogos.Services.Interfaces;

namespace Devs2Blu.ProjetosAula.ListaJogos.Services.Implements
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

        public async Task<int> Update(Categoria categoria)
        {
           return await _repository.UpdateCategoria(categoria);
        }

        public async Task<int> Delete(Categoria categoria)
        {
            return await _repository.DeleteCategoria(categoria);
        }
    }
}
