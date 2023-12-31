﻿using System;
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
using System.Diagnostics;

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
            cboField.Items.Add("Description");
            cboField.Items.Add("Name");
            cboField.Items.Add("Number");

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
            if(dgvPokemons.CurrentRow != null)
            {
                Pokemon selected = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                loadImage(selected.UrlImage);

            }
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
            delete();
        }

        private void disablePokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete(true);
        }

        private void delete(bool disable= false)
        {
            PokemonBusiness business = new PokemonBusiness();
            Pokemon selected;

            try
            {
                DialogResult req = MessageBox.Show("Are you sure you want to delete?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (req == DialogResult.Yes)
                {
                    selected = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                    if(disable)
                        business.disablePokemon(selected.Id);
                    else
                        business.delete(selected.Id);
                    load();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addPokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreatePokemon createPokemon = new frmCreatePokemon();
            createPokemon.ShowDialog();
            load();
        }

        private void modPokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pokemon selected;
            selected = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

            frmCreatePokemon modifyPokemon = new frmCreatePokemon(selected);
            modifyPokemon.ShowDialog();
            load();
        }

        private void deletePokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> filterList;
            string filter = tbxSearch.Text;

            if(filter != "")
            {
                filterList = listPokemons.FindAll(x => x.Name.ToUpper().Contains(filter.ToUpper()) || x.Number.ToString().Contains(filter));
            }
            else
            {
                filterList = listPokemons;
            }

            dgvPokemons.DataSource = null;
            dgvPokemons.DataSource = filterList;
            hideColumns();
        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cboField.SelectedItem.ToString();
            if(option == "Number")
            {
                cboRange.Items.Clear();
                cboRange.Items.Add("Greater than");
                cboRange.Items.Add("Less than");
                cboRange.Items.Add("Equal to");
            }
            else
            {
                cboRange.Items.Clear();
                cboRange.Items.Add("Starts with");
                cboRange.Items.Add("Ends with");
                cboRange.Items.Add("Contains");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PokemonBusiness business = new PokemonBusiness();
            try
            {
                string field = cboField.SelectedItem.ToString();
                string range = cboRange.SelectedItem.ToString();
                string filter = tbxFilter.Text;
                dgvPokemons.DataSource = business.filter(field, range, filter);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
