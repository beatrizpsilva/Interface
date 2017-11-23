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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bmenu = new System.Windows.Forms.Button();
            this.Balarms = new System.Windows.Forms.Button();
            this.Btransformer = new System.Windows.Forms.Button();
            this.Bcircuitbreaker = new System.Windows.Forms.Button();
            this.Bdisconnector = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Bdisconnector);
            this.panel1.Controls.Add(this.Bcircuitbreaker);
            this.panel1.Controls.Add(this.Btransformer);
            this.panel1.Controls.Add(this.Balarms);
            this.panel1.Controls.Add(this.Bmenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 550);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(160, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 40);
            this.panel2.TabIndex = 1;
            // 
            // Bmenu
            // 
            this.Bmenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Bmenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bmenu.Location = new System.Drawing.Point(0, 78);
            this.Bmenu.Name = "Bmenu";
            this.Bmenu.Size = new System.Drawing.Size(160, 53);
            this.Bmenu.TabIndex = 2;
            this.Bmenu.Text = "Menu";
            this.Bmenu.UseVisualStyleBackColor = false;
            // 
            // Balarms
            // 
            this.Balarms.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Balarms.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balarms.Location = new System.Drawing.Point(0, 128);
            this.Balarms.Name = "Balarms";
            this.Balarms.Size = new System.Drawing.Size(160, 53);
            this.Balarms.TabIndex = 3;
            this.Balarms.Text = "Alarms";
            this.Balarms.UseVisualStyleBackColor = false;
            this.Balarms.Click += new System.EventHandler(this.Balarms_Click);
            // 
            // Btransformer
            // 
            this.Btransformer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btransformer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btransformer.Location = new System.Drawing.Point(0, 178);
            this.Btransformer.Name = "Btransformer";
            this.Btransformer.Size = new System.Drawing.Size(160, 53);
            this.Btransformer.TabIndex = 4;
            this.Btransformer.Text = "Transformer";
            this.Btransformer.UseVisualStyleBackColor = false;
            // 
            // Bcircuitbreaker
            // 
            this.Bcircuitbreaker.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Bcircuitbreaker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcircuitbreaker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bcircuitbreaker.Location = new System.Drawing.Point(1, 227);
            this.Bcircuitbreaker.Name = "Bcircuitbreaker";
            this.Bcircuitbreaker.Size = new System.Drawing.Size(159, 53);
            this.Bcircuitbreaker.TabIndex = 5;
            this.Bcircuitbreaker.Text = "Circuit breaker";
            this.Bcircuitbreaker.UseVisualStyleBackColor = false;
            // 
            // Bdisconnector
            // 
            this.Bdisconnector.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Bdisconnector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdisconnector.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bdisconnector.Location = new System.Drawing.Point(0, 276);
            this.Bdisconnector.Name = "Bdisconnector";
            this.Bdisconnector.Size = new System.Drawing.Size(160, 53);
            this.Bdisconnector.TabIndex = 6;
            this.Bdisconnector.Text = "Disconnector";
            this.Bdisconnector.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btransformer;
        private System.Windows.Forms.Button Balarms;
        private System.Windows.Forms.Button Bmenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bdisconnector;
        private System.Windows.Forms.Button Bcircuitbreaker;
    }
}

