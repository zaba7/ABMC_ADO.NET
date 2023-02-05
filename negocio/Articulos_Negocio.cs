using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dominio;
using static System.Net.Mime.MediaTypeNames;

namespace negocio
{
    public class Articulos_Negocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {
                AccesoDatos datos = new AccesoDatos();
                string consulta;
                consulta = "select Codigo, Nombre,A.Descripcion ,C.Descripcion AS Categoria, M.Descripcion AS Marca, ImagenUrl,Precio, A.Id IdArt,c.Id IdCat,m.Id IdMarca from ARTICULOS AS A, CATEGORIAS AS C, MARCAS AS M where A.IdMarca = M.Id and A.IdCategoria=C.Id";
;
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux= new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    //validacion de que la img no sea null
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    }                  
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCat"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Marca= new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Id= (int)datos.Lector["IdArt"];

                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)" +
                    "values('" + nuevo.Codigo + "','" + nuevo.Nombre + "', '" + nuevo.Descripcion + "',@IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.setearParametros("@IdMarca",nuevo.Marca.Id);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@ImagenUrl", nuevo.ImagenUrl);
                datos.setearParametros("@Precio", nuevo.Precio);
                datos.ejecutarAcciones();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo=@codigo,Nombre=@nombre,Descripcion=@descripcion,IdCategoria=@idcat,IdMarca=@idmarca,ImagenUrl=@imagen,precio=@precio where id = @id");
                datos.setearParametros("@codigo",modificar.Codigo);
                datos.setearParametros("@nombre",modificar.Nombre);
                datos.setearParametros("@descripcion",modificar.Descripcion);
                datos.setearParametros("@idcat",modificar.Categoria.Id);
                datos.setearParametros("@idMarca",modificar.Marca.Id);
                datos.setearParametros("@imagen",modificar.ImagenUrl);
                datos.setearParametros("@id",modificar.Id);
                datos.setearParametros("@precio", modificar.Precio);


                datos.ejecutarAcciones();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where Id=@id");
                datos.setearParametros("@id", id);
                datos.ejecutarAcciones();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }






    }

}
