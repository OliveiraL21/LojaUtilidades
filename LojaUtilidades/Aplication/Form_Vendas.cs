﻿using Domain.Interfaces.Services.Produtos;
using Service.Services.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplication
{
    public partial class Form_Vendas : Form
    {
        public int i = 0;
        private readonly IProdutoService _service;
        public Form_Vendas()
        {
            InitializeComponent();
            _service = new ProdutoService();
        }
        #region Front-End
        private void btn_Produto_MouseHover(object sender, EventArgs e)
        {
            btn_Produto.BackColor = Color.DarkMagenta;
        }

        private void btn_Produto_MouseLeave(object sender, EventArgs e)
        {
            btn_Produto.BackColor = Color.FromArgb(41, 0, 39);
        }

        private void btn_Vendas_MouseHover(object sender, EventArgs e)
        {
            btn_Vendas.BackColor = Color.DarkMagenta;
        }

        private void btn_Vendas_MouseLeave(object sender, EventArgs e)
        {
            btn_Vendas.BackColor = Color.FromArgb(41, 0, 39);
        }

        private void btn_Estoque_MouseHover(object sender, EventArgs e)
        {
            btn_Estoque.BackColor = Color.DarkMagenta;
        }

        private void btn_Estoque_MouseLeave(object sender, EventArgs e)
        {
            btn_Estoque.BackColor = Color.FromArgb(41, 0, 39);
        }

        private void btn_Sair_MouseHover(object sender, EventArgs e)
        {
            btn_Sair.BackColor = Color.DarkMagenta;
        }

        private void btn_Sair_MouseLeave(object sender, EventArgs e)
        {
            btn_Sair.BackColor = Color.FromArgb(41, 0, 39);
        }

        private void btn_Produto_Click(object sender, EventArgs e)
        {
            Form_Produtos form_Produtos = new();
            form_Produtos.ShowDialog();
            Close();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            Close();
            Form_Estoque form_Estoque = new Form_Estoque();
            form_Estoque.ShowDialog();
           
        }

        private void btn_Vendas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O formulário de Vendas já está aberto", "Formulario já aberto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private async void btn_Consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Produto.Text) || string.IsNullOrEmpty(txt_Quantidade.Text))
            {
                MessageBox.Show("digite o nome de um produto e/ou sua quantidade de venda!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var nome = txt_Produto.Text;
            var quantidade = int.Parse(txt_Quantidade.Text);
            try
            {
                var result = await _service.SelectByName(nome);
                if(result != null)
                {
                    dgv_Vendas.Rows.Add();
                    dgv_Vendas.Rows[i].Cells[0].Value = result.Nome;
                    dgv_Vendas.Rows[i].Cells[1].Value = result.Valor.ToString();
                    dgv_Vendas.Rows[i].Cells[2].Value = quantidade;
                    i++;
                    
                }
                else
                {
                    MessageBox.Show("Produto não encontrado !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            for(int x = 0; x < dgv_Vendas.Rows.Count; x++)
            {
                var total = double.Parse(dgv_Vendas.Rows[x].Cells[1].Value.ToString()) * double.Parse(dgv_Vendas.Rows[x].Cells[2].Value.ToString());
            }
        }
    }
}
