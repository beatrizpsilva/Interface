namespace Interface
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuitBreakersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.alarmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alarmsToolStripMenuItem,
            this.componentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentsToolStripMenuItem
            // 
            this.componentsToolStripMenuItem.AutoSize = false;
            this.componentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transformersToolStripMenuItem,
            this.circuitBreakersToolStripMenuItem,
            this.transformersToolStripMenuItem1});
            this.componentsToolStripMenuItem.Name = "componentsToolStripMenuItem";
            this.componentsToolStripMenuItem.Size = new System.Drawing.Size(94, 30);
            this.componentsToolStripMenuItem.Text = "Components";
            // 
            // transformersToolStripMenuItem
            // 
            this.transformersToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.transformersToolStripMenuItem.Name = "transformersToolStripMenuItem";
            this.transformersToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.transformersToolStripMenuItem.Text = "Disconnectors";
            this.transformersToolStripMenuItem.Click += new System.EventHandler(this.transformersToolStripMenuItem_Click);
            // 
            // circuitBreakersToolStripMenuItem
            // 
            this.circuitBreakersToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.circuitBreakersToolStripMenuItem.Name = "circuitBreakersToolStripMenuItem";
            this.circuitBreakersToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.circuitBreakersToolStripMenuItem.Text = "Circuit breakers";
            // 
            // transformersToolStripMenuItem1
            // 
            this.transformersToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.transformersToolStripMenuItem1.Name = "transformersToolStripMenuItem1";
            this.transformersToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.transformersToolStripMenuItem1.Text = "Transformers";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(490, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // alarmsToolStripMenuItem
            // 
            this.alarmsToolStripMenuItem.Name = "alarmsToolStripMenuItem";
            this.alarmsToolStripMenuItem.Size = new System.Drawing.Size(56, 46);
            this.alarmsToolStripMenuItem.Text = "Alarms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 391);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuitBreakersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformersToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem alarmsToolStripMenuItem;
    }
}

