
namespace AplicacaoComercial
{
    partial class ComCarro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelAno = new System.Windows.Forms.Label();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.labelPortas = new System.Windows.Forms.Label();
            this.textBoxPortas = new System.Windows.Forms.TextBox();
            this.labelCores = new System.Windows.Forms.Label();
            this.comboBoxCor = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.gridCarros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(24, 35);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 0;
            this.labelMarca.Text = "Marca:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(83, 35);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(193, 20);
            this.textBoxMarca.TabIndex = 1;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(24, 64);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 2;
            this.labelModelo.Text = "Modelo:";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(83, 61);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(193, 20);
            this.textBoxModelo.TabIndex = 3;
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(24, 90);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(29, 13);
            this.labelAno.TabIndex = 4;
            this.labelAno.Text = "Ano:";
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(83, 87);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(112, 20);
            this.textBoxAno.TabIndex = 5;
            // 
            // labelPortas
            // 
            this.labelPortas.AutoSize = true;
            this.labelPortas.Location = new System.Drawing.Point(24, 120);
            this.labelPortas.Name = "labelPortas";
            this.labelPortas.Size = new System.Drawing.Size(40, 13);
            this.labelPortas.TabIndex = 6;
            this.labelPortas.Text = "Portas:";
            // 
            // textBoxPortas
            // 
            this.textBoxPortas.Location = new System.Drawing.Point(83, 113);
            this.textBoxPortas.Name = "textBoxPortas";
            this.textBoxPortas.Size = new System.Drawing.Size(72, 20);
            this.textBoxPortas.TabIndex = 7;
            // 
            // labelCores
            // 
            this.labelCores.AutoSize = true;
            this.labelCores.Location = new System.Drawing.Point(27, 147);
            this.labelCores.Name = "labelCores";
            this.labelCores.Size = new System.Drawing.Size(26, 13);
            this.labelCores.TabIndex = 8;
            this.labelCores.Text = "Cor:";
            // 
            // comboBoxCor
            // 
            this.comboBoxCor.FormattingEnabled = true;
            this.comboBoxCor.Location = new System.Drawing.Point(83, 139);
            this.comboBoxCor.Name = "comboBoxCor";
            this.comboBoxCor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCor.TabIndex = 9;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(231, 137);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(24, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(83, 6);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(36, 20);
            this.textBoxId.TabIndex = 12;
            // 
            // gridCarros
            // 
            this.gridCarros.AllowUserToAddRows = false;
            this.gridCarros.AllowUserToDeleteRows = false;
            this.gridCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarros.Location = new System.Drawing.Point(30, 181);
            this.gridCarros.Name = "gridCarros";
            this.gridCarros.ReadOnly = true;
            this.gridCarros.Size = new System.Drawing.Size(605, 229);
            this.gridCarros.TabIndex = 13;
            // 
            // ComCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 435);
            this.Controls.Add(this.gridCarros);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.comboBoxCor);
            this.Controls.Add(this.labelCores);
            this.Controls.Add(this.textBoxPortas);
            this.Controls.Add(this.labelPortas);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ComCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Carro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.Label labelPortas;
        private System.Windows.Forms.TextBox textBoxPortas;
        private System.Windows.Forms.Label labelCores;
        private System.Windows.Forms.ComboBox comboBoxCor;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridView gridCarros;
    }
}

