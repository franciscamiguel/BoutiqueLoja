using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Data
{
    public class Repositorio : IRepositorio
    {
        private readonly DataContext context;

        public Repositorio(DataContext context)
        {
            this.context = context;
        }

        public void Adiconar<T>(T entidade) where T : class =>
         context.Add(entidade);

        public void Atualizar<T>(T entidade) where T : class => 
            context.Update(entidade);

        public void Excluir<T>(T entidade) where T : class => context.Remove(entidade);

        public async Task<bool> Salvar() => await context.SaveChangesAsync() > 0;
    }
}
