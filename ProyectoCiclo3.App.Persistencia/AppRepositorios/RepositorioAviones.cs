using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> aviones;
 
    public RepositorioAviones()
        {
            aviones= new List<Aviones>()
            {
                new Aviones{id=1,modelo=2008,marca= "Boeing 777",numero_asientos= 100,numero_banos= 4,capacidad= 2000},
                new Aviones{id=2,modelo=2021,marca= "A320",numero_asientos= 150,numero_banos= 8,capacidad= 3500},
                new Aviones{id=3,modelo=1976,marca= "Boeing 757",numero_asientos= 35,numero_banos= 2,capacidad= 1200}
            };
        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return aviones;
        }
 
        public Aviones GetWithId(int id){
            return aviones.SingleOrDefault(a => a.id == id);
        }
    }
}
