namespace Projeto1
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
            this.btnMickey = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbPront = new System.Windows.Forms.TextBox();
            this.lblPront = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMickey
            // 
            this.btnMickey.BackColor = System.Drawing.Color.Coral;
            this.btnMickey.BackgroundImage = global::Projeto1.Properties.Resources._250px_Mickey_Mouse;
            this.btnMickey.ForeColor = System.Drawing.Color.Crimson;
            this.btnMickey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMickey.Location = new System.Drawing.Point(263, 74);
            this.btnMickey.Name = "btnMickey";
            this.btnMickey.Size = new System.Drawing.Size(507, 251);
            this.btnMickey.TabIndex = 0;
            this.btnMickey.Text = "mickey";
            this.btnMickey.UseVisualStyleBackColor = false;
            this.btnMickey.Click += new System.EventHandler(this.btnMickey_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(42, 74);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(117, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Você gosta da Disney?";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(39, 90);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 2;
            // 
            // txbPront
            // 
            this.txbPront.Location = new System.Drawing.Point(45, 265);
            this.txbPront.Name = "txbPront";
            this.txbPront.Size = new System.Drawing.Size(100, 20);
            this.txbPront.TabIndex = 3;
            // 
            // lblPront
            // 
            this.lblPront.AutoSize = true;
            this.lblPront.Location = new System.Drawing.Point(42, 249);
            this.lblPront.Name = "lblPront";
            this.lblPront.Size = new System.Drawing.Size(119, 13);
            this.lblPront.TabIndex = 4;
            this.lblPront.Text = "Você gosta do Mickey?";
            this.lblPront.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPront);
            this.Controls.Add(this.txbPront);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnMickey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMickey;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbPront;
        private System.Windows.Forms.Label lblPront;
    }
}

