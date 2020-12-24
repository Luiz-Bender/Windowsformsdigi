namespace Ferramenta
{
    partial class Tela1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sincronizaPDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandosServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaSincronizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDVToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pDVToolStripMenuItem
            // 
            this.pDVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sincronizaPDVToolStripMenuItem});
            this.pDVToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.pDVToolStripMenuItem.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            this.pDVToolStripMenuItem.Size = new System.Drawing.Size(72, 35);
            this.pDVToolStripMenuItem.Text = "PDV";
            // 
            // sincronizaPDVToolStripMenuItem
            // 
            this.sincronizaPDVToolStripMenuItem.Name = "sincronizaPDVToolStripMenuItem";
            this.sincronizaPDVToolStripMenuItem.Size = new System.Drawing.Size(273, 38);
            this.sincronizaPDVToolStripMenuItem.Text = "Sincroniza PDV";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandosServiçosToolStripMenuItem,
            this.testaSincronizadorToolStripMenuItem});
            this.serviçosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.serviçosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(116, 35);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // comandosServiçosToolStripMenuItem
            // 
            this.comandosServiçosToolStripMenuItem.Name = "comandosServiçosToolStripMenuItem";
            this.comandosServiçosToolStripMenuItem.Size = new System.Drawing.Size(331, 38);
            this.comandosServiçosToolStripMenuItem.Text = "Comandos serviços";
            this.comandosServiçosToolStripMenuItem.Click += new System.EventHandler(this.comandosServiçosToolStripMenuItem_Click);
            // 
            // testaSincronizadorToolStripMenuItem
            // 
            this.testaSincronizadorToolStripMenuItem.Name = "testaSincronizadorToolStripMenuItem";
            this.testaSincronizadorToolStripMenuItem.Size = new System.Drawing.Size(331, 38);
            this.testaSincronizadorToolStripMenuItem.Text = "Testar sincronizador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Ferramenta.Properties.Resources.logomarca__1_;
            this.pictureBox1.Location = new System.Drawing.Point(267, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Tela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Tela1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramentas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDVToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem comandosServiçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaSincronizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sincronizaPDVToolStripMenuItem;
    }
}

