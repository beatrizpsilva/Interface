﻿namespace Interface
{
    partial class interface_transformer
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label Transformer;
            this.lifetime = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_result1 = new System.Windows.Forms.Label();
            Transformer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Transformer
            // 
            Transformer.AutoSize = true;
            Transformer.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Transformer.ForeColor = System.Drawing.SystemColors.ControlText;
            Transformer.Location = new System.Drawing.Point(327, 54);
            Transformer.Name = "Transformer";
            Transformer.Size = new System.Drawing.Size(205, 37);
            Transformer.TabIndex = 0;
            Transformer.Text = "Transformer";
            // 
            // lifetime
            // 
            this.lifetime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lifetime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifetime.Location = new System.Drawing.Point(374, 304);
            this.lifetime.Name = "lifetime";
            this.lifetime.Size = new System.Drawing.Size(104, 40);
            this.lifetime.TabIndex = 1;
            this.lifetime.Text = "lifetime";
            this.lifetime.UseVisualStyleBackColor = false;
            this.lifetime.Click += new System.EventHandler(this.lifetime_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_result1
            // 
            this.label_result1.AutoSize = true;
            this.label_result1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result1.Location = new System.Drawing.Point(389, 358);
            this.label_result1.Name = "label_result1";
            this.label_result1.Size = new System.Drawing.Size(68, 22);
            this.label_result1.TabIndex = 5;
            this.label_result1.Text = "Result";
            // 
            // interface_transformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_result1);
            this.Controls.Add(this.lifetime);
            this.Controls.Add(Transformer);
            this.Name = "interface_transformer";
            this.Size = new System.Drawing.Size(940, 510);
            this.Load += new System.EventHandler(this.interface_transformer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lifetime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_result1;
    }
}
