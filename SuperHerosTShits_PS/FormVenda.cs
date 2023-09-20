using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHerosTShits_PS
{
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.superHeroShirtsDBDataSet.Produto);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.ItensVenda' table. You can move, or remove it, as needed.
            this.itensVendaTableAdapter.Fill(this.superHeroShirtsDBDataSet.ItensVenda);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.superHeroShirtsDBDataSet.Cliente);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.superHeroShirtsDBDataSet.Funcionarios);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.superHeroShirtsDBDataSet.Venda);

        }
    }
}
