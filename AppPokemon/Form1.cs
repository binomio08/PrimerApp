using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;
using business;

namespace AppPokemon
{
    public partial class fmrPokemon : Form
    {
        private List<Pokemon> listPokemons;
        public fmrPokemon()
        {
            InitializeComponent();
        }

        private void fmrPokemon_Load(object sender, EventArgs e)
        {
            //Invoco la lectura de la base de datos y muestro en pantalla
            PokemonBusiness business = new PokemonBusiness();
            listPokemons = business.list();
            dgvPokemons.DataSource = listPokemons;
            hideColumns();
            loadImage(listPokemons[0].UrlImage);
        }

        //Metodo para que se muestre la imagen de la fila seleccionada
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon selected = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            loadImage(selected.UrlImage);
        }

        //Método para cargar imágen, en caso que el dato extraido no contenga imágen devuelve una genérica
        private void loadImage(string image)
        {
            try
            {
                pbxPokemon.Load(image);
            }
            catch (Exception )
            {
                pbxPokemon.Load("https://marriland.com/wp-content/plugins/marriland-core/images/pokemon/sprites/home/full/eternal-floette.png");
            }
        }

        private void hideColumns()
        {
            dgvPokemons.Columns["UrlImage"].Visible = false;
            dgvPokemons.Columns["Id"].Visible = false;
        }
    }
}
