using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        private readonly AppContext _appContext = new AppContext();
 
        public IEnumerable<Aviones> GetAll()
        {
            return _appContext.Aviones;
        }
 
        public Aviones GetAvionWithId(int id){
            return _appContext.Aviones.Find(id);
        }
 
        public Aviones Update(Aviones newAvion){
            var avion = _appContext.Aviones.Find(newAvion.id);
            if(avion != null){
                avion.marca = newAvion.marca;
                avion.modelo = newAvion.modelo;
                avion.numero_asientos = newAvion.numero_asientos;
                avion.numero_banos = newAvion.numero_banos;
                avion.capacidad = newAvion.capacidad;

                //Guardar en base de datos
                _appContext.SaveChanges();
            }
            return avion;
        }
 
        public Aviones Create(Aviones newAvion)
        {
            var addAvion = _appContext.Aviones.Add(newAvion);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addAvion.Entity;
        }
 
        public Aviones Delete(int id)
        {
            var avion = _appContext.Aviones.Find(id);
            if (avion != null){
                _appContext.Aviones.Remove(avion);
                //Guardar en base de datos
                _appContext.SaveChanges();
            }
            return null;
        }
    }
}