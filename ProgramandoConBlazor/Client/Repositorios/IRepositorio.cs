﻿using ProgramandoConBlazor.Shared.Entities;

namespace ProgramandoConBlazor.Client.Repositorios
{
    public interface IRepositorio
    {
        List<Proveedor> GetProveedores();
    }

    class Repositorio : IRepositorio
    {
        public List<Proveedor> GetProveedores()
        {
            return new List<Proveedor>()
            {
                new Proveedor { Id = 1, Nombre = "Juan's Electronics", Direccion = "123 Calle Principal, Ciudad Ejemplo" },
                new Proveedor { Id = 2, Nombre = "Tech Solutions", Direccion = "456 Avenida Central, Ciudad Ejemplo" },
                new Proveedor { Id = 3, Nombre = "Globex Corporation", Direccion = "789 Calle Comercial, Ciudad Ejemplo" },
                new Proveedor { Id = 4, Nombre = "InnovaTech", Direccion = "321 Avenida Principal, Ciudad Ejemplo" },
                new Proveedor { Id = 5, Nombre = "Mega Supplies", Direccion = "654 Calle Central, Ciudad Ejemplo" },
                new Proveedor { Id = 6, Nombre = "Advanced Systems", Direccion = "987 Avenida Comercial, Ciudad Ejemplo" },
                new Proveedor { Id = 7, Nombre = "TechWorld", Direccion = "135 Calle Principal, Ciudad Ejemplo" },
                new Proveedor { Id = 8, Nombre = "FutureTech", Direccion = "246 Avenida Central, Ciudad Ejemplo" },
                new Proveedor { Id = 9, Nombre = "Innovative Solutions", Direccion = "579 Calle Comercial, Ciudad Ejemplo" },
                new Proveedor { Id = 10, Nombre = "Global Gadgets", Direccion = "864 Avenida Principal, Ciudad Ejemplo" }
            };
        }
    }

}
