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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            this.ptbxPokedex = new System.Windows.Forms.PictureBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblField = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.cboRange = new System.Windows.Forms.ComboBox();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspDisablePokemon = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ftSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lblField1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxPokedex)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(282, 5);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(0, 13);
            this.lblField.TabIndex = 4;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(426, 9);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(39, 13);
            this.lblRange.TabIndex = 6;
            this.lblRange.Text = "Range";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(577, 9);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 8;
            this.lblFilter.Text = "Filter";
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(616, 2);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(100, 20);
            this.tbxFilter.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(736, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboField
            // 
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(320, 2);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(100, 21);
            this.cboField.TabIndex = 11;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // cboRange
            // 
            this.cboRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRange.FormattingEnabled = true;
            this.cboRange.Location = new System.Drawing.Point(471, 2);
            this.cboRange.Name = "cboRange";
            this.cboRange.Size = new System.Drawing.Size(99, 21);
            this.cboRange.TabIndex = 12;
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
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
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lblField1
            // 
            this.lblField1.AutoSize = true;
            this.lblField1.Location = new System.Drawing.Point(282, 9);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(32, 13);
            this.lblField1.TabIndex = 13;
            this.lblField1.Text = "Field:";
            // 
            // fmrPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 675);
            this.Controls.Add(this.lblField1);
            this.Controls.Add(this.cboRange);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblField);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxPokedex)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbxPokedex;
        private System.Windows.Forms.PictureBox pbxPokemon;
        private System.Windows.Forms.DataGridView dgvPokemons;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.ComboBox cboRange;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modPokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspDisablePokemon;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ftSearch;
        private System.Windows.Forms.ToolStripTextBox tbxSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lblField1;
    }
}

