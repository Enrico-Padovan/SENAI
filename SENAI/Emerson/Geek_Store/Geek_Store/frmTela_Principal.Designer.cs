namespace Geek_Store
{
    partial class frmTela_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.demonstrativoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadatroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadsatroDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadsatroDeProdutoToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.demonstrativoDeVendasToolStripMenuItem,
            this.cadatroToolStripMenuItem,
            this.logarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 99);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // demonstrativoDeVendasToolStripMenuItem
            // 
            this.demonstrativoDeVendasToolStripMenuItem.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demonstrativoDeVendasToolStripMenuItem.Name = "demonstrativoDeVendasToolStripMenuItem";
            this.demonstrativoDeVendasToolStripMenuItem.Size = new System.Drawing.Size(206, 95);
            this.demonstrativoDeVendasToolStripMenuItem.Text = "Demonstrativo de Vendas";
            // 
            // cadatroToolStripMenuItem
            // 
            this.cadatroToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cadatroToolStripMenuItem.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadatroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadatroToolStripMenuItem.Name = "cadatroToolStripMenuItem";
            this.cadatroToolStripMenuItem.Size = new System.Drawing.Size(121, 95);
            this.cadatroToolStripMenuItem.Text = "Cadatrar";
            // 
            // logarToolStripMenuItem
            // 
            this.logarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logarToolStripMenuItem.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logarToolStripMenuItem.Name = "logarToolStripMenuItem";
            this.logarToolStripMenuItem.Size = new System.Drawing.Size(64, 95);
            this.logarToolStripMenuItem.Text = "Logar";
            // 
            // cadsatroDeProdutoToolStripMenuItem
            // 
            this.cadsatroDeProdutoToolStripMenuItem.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadsatroDeProdutoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadsatroDeProdutoToolStripMenuItem.Name = "cadsatroDeProdutoToolStripMenuItem";
            this.cadsatroDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(175, 95);
            this.cadsatroDeProdutoToolStripMenuItem.Text = "Cadsatro de Produto";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.vendasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(73, 95);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // frmTela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTela_Principal";
            this.Text = "Form5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadsatroDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstrativoDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadatroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logarToolStripMenuItem;
    }
}