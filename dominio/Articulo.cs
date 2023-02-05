using System;
using System.Collections.Generic;
using System.ComponentModel; //permite usar el DsiplayName y modificar los nombres de las columnas
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        //las properties son las cabeceras de los campos en la tabla de la interfaz
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public Marca Marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }

        public decimal Precio { get; set; }
        public string ImagenUrl { get; set; }

       
    }
}
