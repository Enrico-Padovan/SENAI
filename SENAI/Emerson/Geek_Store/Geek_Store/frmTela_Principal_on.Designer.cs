namespace Geek_Store
{
    partial class frmTela_Principal_on
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxMaisVendidos = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxCarrinho = new System.Windows.Forms.PictureBox();
            this.pbxCadastroProduto = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadsatroDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARRINHOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstrativoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaisVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastroProduto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(742, 613);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "SAIR";
            // 
            // pbxSair
            // 
            this.pbxSair.Image = global::Geek_Store.Properties.Resources.icons8_desligar_100;
            this.pbxSair.Location = new System.Drawing.Point(709, 510);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(100, 100);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 20;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click_1);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(46, 303);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(606, 316);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "MAIS VENDIDOS";
            // 
            // pbxMaisVendidos
            // 
            this.pbxMaisVendidos.Image = global::Geek_Store.Properties.Resources.icons8_mais_vendidos_100;
            this.pbxMaisVendidos.Location = new System.Drawing.Point(502, 112);
            this.pbxMaisVendidos.Name = "pbxMaisVendidos";
            this.pbxMaisVendidos.Size = new System.Drawing.Size(150, 150);
            this.pbxMaisVendidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMaisVendidos.TabIndex = 17;
            this.pbxMaisVendidos.TabStop = false;
            this.pbxMaisVendidos.Click += new System.EventHandler(this.pbxMaisVendidos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "COMPRAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "CADASTRO DE PRODUTO";
            // 
            // pbxCarrinho
            // 
            this.pbxCarrinho.Image = global::Geek_Store.Properties.Resources.icons8_cesto_de_compras_2_100;
            this.pbxCarrinho.Location = new System.Drawing.Point(278, 112);
            this.pbxCarrinho.Name = "pbxCarrinho";
            this.pbxCarrinho.Size = new System.Drawing.Size(150, 150);
            this.pbxCarrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCarrinho.TabIndex = 14;
            this.pbxCarrinho.TabStop = false;
            this.pbxCarrinho.Click += new System.EventHandler(this.pbxCarrinho_Click);
            // 
            // pbxCadastroProduto
            // 
            this.pbxCadastroProduto.Image = global::Geek_Store.Properties.Resources.icons8_movimento_de_estoque_100;
            this.pbxCadastroProduto.Location = new System.Drawing.Point(46, 112);
            this.pbxCadastroProduto.Name = "pbxCadastroProduto";
            this.pbxCadastroProduto.Size = new System.Drawing.Size(150, 150);
            this.pbxCadastroProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCadastroProduto.TabIndex = 13;
            this.pbxCadastroProduto.TabStop = false;
            this.pbxCadastroProduto.Click += new System.EventHandler(this.pbxCadastroProduto_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadsatroDeProdutoToolStripMenuItem,
            this.cARRINHOToolStripMenuItem,
            this.demonstrativoDeVendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 99);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadsatroDeProdutoToolStripMenuItem
            // 
            this.cadsatroDeProdutoToolStripMenuItem.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadsatroDeProdutoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadsatroDeProdutoToolStripMenuItem.Image = global::Geek_Store.Properties.Resources.icons8_movimento_de_estoque_30;
            this.cadsatroDeProdutoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadsatroDeProdutoToolStripMenuItem.Name = "cadsatroDeProdutoToolStripMenuItem";
            this.cadsatroDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(243, 95);
            this.cadsatroDeProdutoToolStripMenuItem.Text = "CADASTRO DE PRODUTOS";
            this.cadsatroDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadsatroDeProdutoToolStripMenuItem_Click);
            // 
            // cARRINHOToolStripMenuItem
            // 
            this.cARRINHOToolStripMenuItem.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cARRINHOToolStripMenuItem.Image = global::Geek_Store.Properties.Resources.icons8_cesto_de_compras_2_30;
            this.cARRINHOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cARRINHOToolStripMenuItem.Name = "cARRINHOToolStripMenuItem";
            this.cARRINHOToolStripMenuItem.Size = new System.Drawing.Size(127, 95);
            this.cARRINHOToolStripMenuItem.Text = "COMPRAR";
            this.cARRINHOToolStripMenuItem.Click += new System.EventHandler(this.cARRINHOToolStripMenuItem_Click);
            // 
            // demonstrativoDeVendasToolStripMenuItem
            // 
            this.demonstrativoDeVendasToolStripMenuItem.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demonstrativoDeVendasToolStripMenuItem.Image = global::Geek_Store.Properties.Resources.icons8_mais_vendidos_30;
            this.demonstrativoDeVendasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.demonstrativoDeVendasToolStripMenuItem.Name = "demonstrativoDeVendasToolStripMenuItem";
            this.demonstrativoDeVendasToolStripMenuItem.Size = new System.Drawing.Size(166, 95);
            this.demonstrativoDeVendasToolStripMenuItem.Text = "MAIS VENDIDOS";
            this.demonstrativoDeVendasToolStripMenuItem.Click += new System.EventHandler(this.demonstrativoDeVendasToolStripMenuItem_Click);
            // 
            // frmTela_Principal_on
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 631);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxMaisVendidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxCarrinho);
            this.Controls.Add(this.pbxCadastroProduto);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmTela_Principal_on";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEEK STORE";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaisVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastroProduto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxMaisVendidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxCarrinho;
        private System.Windows.Forms.PictureBox pbxCadastroProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadsatroDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARRINHOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstrativoDeVendasToolStripMenuItem;
    }
}