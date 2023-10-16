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
            load();
        }

        private void load()
        {
            //Invoco la lectura de la base de datos y muestro en pantalla
            PokemonBusiness business = new PokemonBusiness();
            try
            {

                listPokemons = business.list();

                listPokemons = listPokemons.OrderBy(p => p.Number).ToList();
                dgvPokemons.DataSource = listPokemons;
                hideColumns();
                loadImage(listPokemons[0].UrlImage);
                btnAgregar.FlatStyle = FlatStyle.Flat;
                btnAgregar.FlatAppearance.BorderSize = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCreatePokemon createPokemon = new frmCreatePokemon();
            createPokemon.ShowDialog();
            load();

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Pokemon selected;
            selected = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

            frmCreatePokemon modifyPokemon = new frmCreatePokemon(selected);
            modifyPokemon.ShowDialog();
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PokemonBusiness business = new PokemonBusiness();
            Pokemon selected;

            try
            {
                DialogResult req = MessageBox.Show("Are you sure you want to delete?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (req == DialogResult.Yes)
                {
                    selected = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                    business.delete(selected.Id);
                    load();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
