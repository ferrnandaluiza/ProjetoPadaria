﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PANDOKS_V1._0
{
    public partial class Cadastrarprodutos : Form
    {
        public Cadastrarprodutos()
        {
            InitializeComponent();
        }


        private void Cadastrarprodutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database_padarianovoDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter1.Fill(this.database_padarianovoDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'database_padariaDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.database_padariaDataSet.produto);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void produtoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_padariaDataSet);

        }

        private void id_produtoTextBox_TextChanged(object sender, EventArgs e)
        {
            id_produtoTextBox.ReadOnly = true;
        }

        private void nome_produtoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            produtoBindingSource1.MoveNext();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            produtoBindingSource1.MovePrevious();
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            produtoBindingSource1.RemoveCurrent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            produtoBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(database_padarianovoDataSet);
            this.produtoTableAdapter1.Fill(this.database_padarianovoDataSet.produto);
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource1.AddNew();
        }
    }
}
