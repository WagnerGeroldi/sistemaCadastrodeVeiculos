using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoComercial
{
    public partial class ComCarro : Form
    {
        public ComCarro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCor.DataSource = Enum.GetNames(typeof(Veiculo.Cores));
            gridCarros.DataSource = Carro.Consultar();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro(

            textBoxMarca.Text,
            textBoxModelo.Text,
            int.Parse(textBoxAno.Text),
            (Veiculo.Cores) comboBoxCor.SelectedIndex,
            int.Parse(textBoxPortas.Text)
            );
            carro.Incluir();
            gridCarros.DataSource = "";
            gridCarros.DataSource = Carro.Consultar();
            limparCampos();
            MessageBox.Show("Dados Cadastrados com sucesso", "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void limparCampos()
        {
            textBoxAno.Text = " ";
            textBoxId.Text = " ";
            textBoxMarca.Text = " ";
            textBoxModelo.Text = " ";
            textBoxPortas.Text = " ";
            comboBoxCor.SelectedIndex = 0;

        }
    }
}
