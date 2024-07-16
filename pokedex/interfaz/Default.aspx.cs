using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace interfaz
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Pokemon> ListadoPokemon {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaPokemon"] == null)
            {
                PokemonNegocio pokeNegocio = new PokemonNegocio();
                ListadoPokemon = pokeNegocio.listarPokemon();
                Session.Add("listadoPokemon", ListadoPokemon);
            }

        }
    }
}