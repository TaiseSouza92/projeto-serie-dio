using System;
using System.Collections.Generic;
using ProjetoSeries.Interface;

namespace ProjetoSeries.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        void IRepositorio<Serie>.Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        void IRepositorio<Serie>.Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        void IRepositorio<Serie>.Insere(Serie objeto)
        {
             listaSerie.Add(objeto);
        } 

        List<Serie> IRepositorio<Serie>.Lista()
        {
            return listaSerie;
        }

        int IRepositorio<Serie>.ProximoId()
        {
            return listaSerie.Count;
        }

        Serie IRepositorio<Serie>.RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}