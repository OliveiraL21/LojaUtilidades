﻿
namespace Aplication
{
    partial class Form_Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Vendas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Estoque = new System.Windows.Forms.Button();
            this.btn_Vendas = new System.Windows.Forms.Button();
            this.btn_Produto = new System.Windows.Forms.Button();
            this.dgv_Vendas = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Quantidade = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.txt_Produto = new System.Windows.Forms.TextBox();
            this.label_Produto = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vendas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.panel_Menu.Controls.Add(this.pictureBox1);
            this.panel_Menu.Controls.Add(this.btn_Sair);
            this.panel_Menu.Controls.Add(this.btn_Estoque);
            this.panel_Menu.Controls.Add(this.btn_Vendas);
            this.panel_Menu.Controls.Add(this.btn_Produto);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(229, 935);
            this.panel_Menu.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.FlatAppearance.BorderSize = 0;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Image")));
            this.btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sair.Location = new System.Drawing.Point(0, 841);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(225, 93);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            this.btn_Sair.MouseLeave += new System.EventHandler(this.btn_Sair_MouseLeave);
            this.btn_Sair.MouseHover += new System.EventHandler(this.btn_Sair_MouseHover);
            // 
            // btn_Estoque
            // 
            this.btn_Estoque.FlatAppearance.BorderSize = 0;
            this.btn_Estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Estoque.ForeColor = System.Drawing.Color.White;
            this.btn_Estoque.Image = ((System.Drawing.Image)(resources.GetObject("btn_Estoque.Image")));
            this.btn_Estoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Estoque.Location = new System.Drawing.Point(0, 513);
            this.btn_Estoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Estoque.Name = "btn_Estoque";
            this.btn_Estoque.Size = new System.Drawing.Size(225, 93);
            this.btn_Estoque.TabIndex = 3;
            this.btn_Estoque.Text = "Estoque";
            this.btn_Estoque.UseVisualStyleBackColor = true;
            this.btn_Estoque.Click += new System.EventHandler(this.btn_Estoque_Click);
            this.btn_Estoque.MouseLeave += new System.EventHandler(this.btn_Estoque_MouseLeave);
            this.btn_Estoque.MouseHover += new System.EventHandler(this.btn_Estoque_MouseHover);
            // 
            // btn_Vendas
            // 
            this.btn_Vendas.FlatAppearance.BorderSize = 0;
            this.btn_Vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vendas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Vendas.ForeColor = System.Drawing.Color.White;
            this.btn_Vendas.Image = ((System.Drawing.Image)(resources.GetObject("btn_Vendas.Image")));
            this.btn_Vendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Vendas.Location = new System.Drawing.Point(3, 393);
            this.btn_Vendas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Vendas.Name = "btn_Vendas";
            this.btn_Vendas.Size = new System.Drawing.Size(225, 93);
            this.btn_Vendas.TabIndex = 2;
            this.btn_Vendas.Text = "Vendas";
            this.btn_Vendas.UseVisualStyleBackColor = true;
            this.btn_Vendas.Click += new System.EventHandler(this.btn_Vendas_Click);
            this.btn_Vendas.MouseLeave += new System.EventHandler(this.btn_Vendas_MouseLeave);
            this.btn_Vendas.MouseHover += new System.EventHandler(this.btn_Vendas_MouseHover);
            // 
            // btn_Produto
            // 
            this.btn_Produto.FlatAppearance.BorderSize = 0;
            this.btn_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Produto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Produto.ForeColor = System.Drawing.Color.White;
            this.btn_Produto.Image = ((System.Drawing.Image)(resources.GetObject("btn_Produto.Image")));
            this.btn_Produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Produto.Location = new System.Drawing.Point(0, 264);
            this.btn_Produto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Produto.Name = "btn_Produto";
            this.btn_Produto.Size = new System.Drawing.Size(225, 93);
            this.btn_Produto.TabIndex = 1;
            this.btn_Produto.Text = "Produtos";
            this.btn_Produto.UseVisualStyleBackColor = true;
            this.btn_Produto.Click += new System.EventHandler(this.btn_Produto_Click);
            this.btn_Produto.MouseLeave += new System.EventHandler(this.btn_Produto_MouseLeave);
            this.btn_Produto.MouseHover += new System.EventHandler(this.btn_Produto_MouseHover);
            // 
            // dgv_Vendas
            // 
            this.dgv_Vendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Vendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Vendas.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgv_Vendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Valor,
            this.Quantidade});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Vendas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Vendas.GridColor = System.Drawing.Color.Black;
            this.dgv_Vendas.Location = new System.Drawing.Point(679, 210);
            this.dgv_Vendas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Vendas.Name = "dgv_Vendas";
            this.dgv_Vendas.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Vendas.RowHeadersWidth = 51;
            this.dgv_Vendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Vendas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Vendas.RowTemplate.Height = 25;
            this.dgv_Vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Vendas.Size = new System.Drawing.Size(658, 541);
            this.dgv_Vendas.TabIndex = 12;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.MinimumWidth = 6;
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // label_Quantidade
            // 
            this.label_Quantidade.AutoSize = true;
            this.label_Quantidade.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Quantidade.Location = new System.Drawing.Point(248, 373);
            this.label_Quantidade.Name = "label_Quantidade";
            this.label_Quantidade.Size = new System.Drawing.Size(152, 28);
            this.label_Quantidade.TabIndex = 18;
            this.label_Quantidade.Text = "Quantidade";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Total.Location = new System.Drawing.Point(248, 491);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(66, 28);
            this.label_Total.TabIndex = 17;
            this.label_Total.Text = "Total";
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Total.Location = new System.Drawing.Point(248, 525);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(146, 37);
            this.txt_Total.TabIndex = 16;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Quantidade.Location = new System.Drawing.Point(248, 415);
            this.txt_Quantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(155, 37);
            this.txt_Quantidade.TabIndex = 15;
            // 
            // txt_Produto
            // 
            this.txt_Produto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Produto.Location = new System.Drawing.Point(248, 268);
            this.txt_Produto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(372, 37);
            this.txt_Produto.TabIndex = 14;
            // 
            // label_Produto
            // 
            this.label_Produto.AutoSize = true;
            this.label_Produto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Produto.Location = new System.Drawing.Point(248, 233);
            this.label_Produto.Name = "label_Produto";
            this.label_Produto.Size = new System.Drawing.Size(100, 28);
            this.label_Produto.TabIndex = 13;
            this.label_Produto.Text = "Produto";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Calcular.ForeColor = System.Drawing.Color.White;
            this.btn_Calcular.Location = new System.Drawing.Point(248, 633);
            this.btn_Calcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(146, 67);
            this.btn_Calcular.TabIndex = 19;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(303, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_Consultar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Imprimir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(229, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 73);
            this.panel1.TabIndex = 21;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.FlatAppearance.BorderSize = 0;
            this.btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Consultar.ForeColor = System.Drawing.Color.White;
            this.btn_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Consultar.Image")));
            this.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Consultar.Location = new System.Drawing.Point(0, 2);
            this.btn_Consultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(234, 65);
            this.btn_Consultar.TabIndex = 24;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(480, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 69);
            this.button1.TabIndex = 23;
            this.button1.Text = "Finalizar Venda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.FlatAppearance.BorderSize = 0;
            this.btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Imprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Imprimir.Image")));
            this.btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Imprimir.Location = new System.Drawing.Point(240, 4);
            this.btn_Imprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(234, 65);
            this.btn_Imprimir.TabIndex = 22;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // Form_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 935);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.label_Quantidade);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.txt_Produto);
            this.Controls.Add(this.label_Produto);
            this.Controls.Add(this.dgv_Vendas);
            this.Controls.Add(this.panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Vendas";
            this.panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vendas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Estoque;
        private System.Windows.Forms.Button btn_Vendas;
        private System.Windows.Forms.Button btn_Produto;
        private System.Windows.Forms.DataGridView dgv_Vendas;
        private System.Windows.Forms.Label label_Quantidade;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.TextBox txt_Produto;
        private System.Windows.Forms.Label label_Produto;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}