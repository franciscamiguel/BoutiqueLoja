using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Data
{
    public interface IRepositorio
    {
        void Adiconar<T>(T entidade) where T : class;

        void Atualizar<T>(T entidade) where T : class;

        void Excluir<T>(T entidade) where T : class;

        Task<bool> Salvar();
    }
}
