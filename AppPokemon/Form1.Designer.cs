namespace AppPokemon
{
    partial class fmrPokemon
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrPokemon));
            this.dgvPokemons = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspDisablePokemon = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ftSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            this.ptbxPokedex = new System.Windows.Forms.PictureBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxPokedex)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemons
            // 
            this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemons.Location = new System.Drawing.Point(285, 412);
            this.dgvPokemons.MultiSelect = false;
            this.dgvPokemons.Name = "dgvPokemons";
            this.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemons.Size = new System.Drawing.Size(299, 219);
            this.dgvPokemons.TabIndex = 3;
            this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.ftSearch,
            this.tbxSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPokemonToolStripMenuItem,
            this.deletePokemonToolStripMenuItem,
            this.modPokemonToolStripMenuItem,
            this.tspDisablePokemon});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // addPokemonToolStripMenuItem
            // 
            this.addPokemonToolStripMenuItem.Name = "addPokemonToolStripMenuItem";
            this.addPokemonToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addPokemonToolStripMenuItem.Text = "Add Pokemon";
            this.addPokemonToolStripMenuItem.Click += new System.EventHandler(this.addPokemonToolStripMenuItem_Click);
            // 
            // deletePokemonToolStripMenuItem
            // 
            this.deletePokemonToolStripMenuItem.Name = "deletePokemonToolStripMenuItem";
            this.deletePokemonToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.deletePokemonToolStripMenuItem.Text = "Delete Pokemon";
            this.deletePokemonToolStripMenuItem.Click += new System.EventHandler(this.deletePokemonToolStripMenuItem_Click);
            // 
            // modPokemonToolStripMenuItem
            // 
            this.modPokemonToolStripMenuItem.Name = "modPokemonToolStripMenuItem";
            this.modPokemonToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.modPokemonToolStripMenuItem.Text = "Mod Pokemon";
            this.modPokemonToolStripMenuItem.Click += new System.EventHandler(this.modPokemonToolStripMenuItem_Click);
            // 
            // tspDisablePokemon
            // 
            this.tspDisablePokemon.Name = "tspDisablePokemon";
            this.tspDisablePokemon.Size = new System.Drawing.Size(166, 22);
            this.tspDisablePokemon.Text = "Disable Pokemon";
            this.tspDisablePokemon.Click += new System.EventHandler(this.disablePokemonToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ftSearch
            // 
            this.ftSearch.Name = "ftSearch";
            this.ftSearch.Size = new System.Drawing.Size(57, 23);
            this.ftSearch.Text = "Search:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 23);
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.BackgroundImage = global::AppPokemon.Properties.Resources.redP;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(616, 431);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(27, 57);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.Location = new System.Drawing.Point(285, 78);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(299, 222);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 2;
            this.pbxPokemon.TabStop = false;
            // 
            // ptbxPokedex
            // 
            this.ptbxPokedex.Image = global::AppPokemon.Properties.Resources.Pokedex;
            this.ptbxPokedex.Location = new System.Drawing.Point(12, 36);
            this.ptbxPokedex.Name = "ptbxPokedex";
            this.ptbxPokedex.Size = new System.Drawing.Size(868, 645);
            this.ptbxPokedex.TabIndex = 0;
            this.ptbxPokedex.TabStop = false;
            // 
            // btnModify
            // 
            this.btnModify.BackgroundImage = global::AppPokemon.Properties.Resources.redP;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(616, 486);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(27, 57);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "M";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::AppPokemon.Properties.Resources.redP;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(616, 541);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(27, 57);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // fmrPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 675);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPokemons);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.ptbxPokedex);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fmrPokemon";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.fmrPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxPokedex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbxPokedex;
        private System.Windows.Forms.PictureBox pbxPokemon;
        private System.Windows.Forms.DataGridView dgvPokemons;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modPokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspDisablePokemon;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ToolStripMenuItem ftSearch;
        private System.Windows.Forms.ToolStripTextBox tbxSearch;
    }
}

