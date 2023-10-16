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
using Business;

namespace AppPokemon
{
    public partial class frmCreatePokemon : Form
    {
        private Pokemon pokemon = null;
        public frmCreatePokemon()
        {
            InitializeComponent();
        }

        public frmCreatePokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;

            this.Text = "Modify Pokemon";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            PokemonBusiness pokeBusiness = new PokemonBusiness();
            try
            {
                if(pokemon == null)
                    pokemon = new Pokemon();
                pokemon.Number = int.Parse(tbxNumber.Text);
                pokemon.Name = tbxName.Text;
                pokemon.Description = tbxDescription.Text;
                pokemon.UrlImage = txtUrlImage.Text;
                pokemon.Type = (Element)cboType.SelectedItem;
                pokemon.Weaknesess = (Element)cboWaknesess.SelectedItem;

                if(pokemon.Id != 0)
                {
                    pokeBusiness.modify(pokemon);
                    MessageBox.Show("Successfully modified");

                }
                else
                {
                    pokeBusiness.create(pokemon);
                    MessageBox.Show("Successfully added");
                }
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmCreatePokemon_Load(object sender, EventArgs e)
        {
            ElementBusiness elementBusiness = new ElementBusiness();

            try
            {
                //ConfigureAutocomplete(cboType);
                //ConfigureAutocomplete(cboWaknesess);

                cboType.DataSource = elementBusiness.list();
                cboType.ValueMember = "Id";
                cboType.DisplayMember = "Description";
                cboWaknesess.DataSource = elementBusiness.list();
                cboWaknesess.ValueMember = "Id";
                cboWaknesess.DisplayMember = "Description";

                //Precargo los datos en la caja de texto

                if(pokemon != null)
                {
                    tbxNumber.Text = pokemon.Number.ToString();
                    tbxName.Text = pokemon.Name;
                    tbxDescription.Text = pokemon.Description;
                    txtUrlImage.Text = pokemon.UrlImage;
                    loadImage(pokemon.UrlImage);
                    cboType.SelectedValue = pokemon.Type.Id;
                    cboWaknesess.SelectedValue = pokemon.Weaknesess.Id;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ConfigureAutocomplete(ComboBox comboBox)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void txtUrlImage_TextChanged(object sender, EventArgs e)
        {
            loadImage(txtUrlImage.Text);
        }

        private void loadImage(string image)
        {
            try
            {
                pbxPokemon.Load(image);
            }
            catch (Exception)
            {
                pbxPokemon.Load("https://marriland.com/wp-content/plugins/marriland-core/images/pokemon/sprites/home/full/eternal-floette.png");
            }
        }
    }

}
