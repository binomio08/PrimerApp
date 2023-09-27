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
            this.ptbxPokedex = new System.Windows.Forms.PictureBox();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            this.dgvPokemons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxPokedex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbxPokedex
            // 
            this.ptbxPokedex.Image = global::AppPokemon.Properties.Resources.Pokedex;
            this.ptbxPokedex.Location = new System.Drawing.Point(12, 12);
            this.ptbxPokedex.Name = "ptbxPokedex";
            this.ptbxPokedex.Size = new System.Drawing.Size(856, 660);
            this.ptbxPokedex.TabIndex = 0;
            this.ptbxPokedex.TabStop = false;
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.Location = new System.Drawing.Point(285, 56);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(299, 221);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 2;
            this.pbxPokemon.TabStop = false;
            // 
            // dgvPokemons
            // 
            this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemons.Location = new System.Drawing.Point(285, 395);
            this.dgvPokemons.Name = "dgvPokemons";
            this.dgvPokemons.Size = new System.Drawing.Size(299, 219);
            this.dgvPokemons.TabIndex = 3;
            this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
            // 
            // fmrPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 675);
            this.Controls.Add(this.dgvPokemons);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.ptbxPokedex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmrPokemon";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.fmrPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxPokedex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbxPokedex;
        private System.Windows.Forms.PictureBox pbxPokemon;
        private System.Windows.Forms.DataGridView dgvPokemons;
    }
}

