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
            this.MenuAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuComponents = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDisconnectors = new System.Windows.Forms.ToolStripMenuItem();
            this.DropCircuitBreakers = new System.Windows.Forms.ToolStripMenuItem();
            this.DropTransformers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAlarm,
            this.MenuComponents});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAlarm
            // 
            this.MenuAlarm.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAlarm.Name = "MenuAlarm";
            this.MenuAlarm.Size = new System.Drawing.Size(89, 46);
            this.MenuAlarm.Text = "Alarms";
            // 
            // MenuComponents
            // 
            this.MenuComponents.AutoSize = false;
            this.MenuComponents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDisconnectors,
            this.DropCircuitBreakers,
            this.DropTransformers});
            this.MenuComponents.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuComponents.Name = "MenuComponents";
            this.MenuComponents.Size = new System.Drawing.Size(130, 30);
            this.MenuComponents.Text = "Components";
            // 
            // DropDisconnectors
            // 
            this.DropDisconnectors.BackColor = System.Drawing.Color.CadetBlue;
            this.DropDisconnectors.Name = "DropDisconnectors";
            this.DropDisconnectors.Size = new System.Drawing.Size(228, 30);
            this.DropDisconnectors.Text = "Disconnectors";
            this.DropDisconnectors.Click += new System.EventHandler(this.transformersToolStripMenuItem_Click);
            // 
            // DropCircuitBreakers
            // 
            this.DropCircuitBreakers.BackColor = System.Drawing.Color.CadetBlue;
            this.DropCircuitBreakers.Name = "DropCircuitBreakers";
            this.DropCircuitBreakers.Size = new System.Drawing.Size(228, 30);
            this.DropCircuitBreakers.Text = "Circuit breakers";
            // 
            // DropTransformers
            // 
            this.DropTransformers.BackColor = System.Drawing.Color.CadetBlue;
            this.DropTransformers.Name = "DropTransformers";
            this.DropTransformers.Size = new System.Drawing.Size(228, 30);
            this.DropTransformers.Text = "Transformers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 391);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuComponents;
        private System.Windows.Forms.ToolStripMenuItem DropDisconnectors;
        private System.Windows.Forms.ToolStripMenuItem DropCircuitBreakers;
        private System.Windows.Forms.ToolStripMenuItem DropTransformers;
        private System.Windows.Forms.ToolStripMenuItem MenuAlarm;
    }
}

