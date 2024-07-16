using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listarPokemon()
        {
            List<Pokemon> list = new List<Pokemon>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setConsulta("Select P.Id, P.Numero, P.Nombre, P.Descripcion, P.UrlIMagen from POKEMONS P");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Pokemon pokemonAux = new Pokemon();
                    pokemonAux.setId((int)accesoDatos.Lector["Id"]);
                    pokemonAux.setNumero((int)accesoDatos.Lector["Numero"]);
                    pokemonAux.setNombre((string)accesoDatos.Lector["Nombre"]);
                    pokemonAux.setDescripcion((string)accesoDatos.Lector["Descripcion"]);
                    if (!(accesoDatos.Lector["UrlImagen"] is DBNull))
                    {
                        pokemonAux.setImagen((string)accesoDatos.Lector["UrlImagen"]);
                    }
                    else
                    {
                        pokemonAux.setImagen("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
                    }
                    
                    list.Add(pokemonAux);


                }
                return list;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
            

            



            
        }
    }
}
