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
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbPront = new System.Windows.Forms.TextBox();
            this.lblPront = new System.Windows.Forms.Label();
            this.lblQuest = new System.Windows.Forms.Label();
            this.txbQuest = new System.Windows.Forms.TextBox();
            this.txbMusic = new System.Windows.Forms.TextBox();
            this.lblMusic = new System.Windows.Forms.Label();
            this.txbPerson = new System.Windows.Forms.TextBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMickey = new System.Windows.Forms.Button();
            this.lblDisney = new System.Windows.Forms.Label();
            this.txbDisney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.mtxbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxbNumber = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(36, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(117, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Você gosta da Disney?";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(41, 25);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 2;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // txbPront
            // 
            this.txbPront.Location = new System.Drawing.Point(41, 78);
            this.txbPront.Name = "txbPront";
            this.txbPront.Size = new System.Drawing.Size(100, 20);
            this.txbPront.TabIndex = 3;
            // 
            // lblPront
            // 
            this.lblPront.AutoSize = true;
            this.lblPront.Location = new System.Drawing.Point(36, 62);
            this.lblPront.Name = "lblPront";
            this.lblPront.Size = new System.Drawing.Size(119, 13);
            this.lblPront.TabIndex = 4;
            this.lblPront.Text = "Você gosta do Mickey?";
            this.lblPront.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.Location = new System.Drawing.Point(36, 114);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(132, 13);
            this.lblQuest.TabIndex = 5;
            this.lblQuest.Text = "Diga  o seu filme preferido:";
            this.lblQuest.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbQuest
            // 
            this.txbQuest.Location = new System.Drawing.Point(39, 130);
            this.txbQuest.Name = "txbQuest";
            this.txbQuest.Size = new System.Drawing.Size(100, 20);
            this.txbQuest.TabIndex = 6;
            // 
            // txbMusic
            // 
            this.txbMusic.Location = new System.Drawing.Point(41, 180);
            this.txbMusic.Name = "txbMusic";
            this.txbMusic.Size = new System.Drawing.Size(100, 20);
            this.txbMusic.TabIndex = 7;
            this.txbMusic.TextChanged += new System.EventHandler(this.txbMusic_TextChanged);
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Location = new System.Drawing.Point(38, 164);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(126, 13);
            this.lblMusic.TabIndex = 8;
            this.lblMusic.Text = "Diga sua música favorita:";
            // 
            // txbPerson
            // 
            this.txbPerson.Location = new System.Drawing.Point(41, 232);
            this.txbPerson.Name = "txbPerson";
            this.txbPerson.Size = new System.Drawing.Size(100, 20);
            this.txbPerson.TabIndex = 9;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(38, 216);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(156, 13);
            this.lblPerson.TabIndex = 10;
            this.lblPerson.Text = "Digite seu personagem favorito:";
            this.lblPerson.Click += new System.EventHandler(this.lblperson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(514, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUIZ DISNEY!!";
            // 
            // btnMickey
            // 
            this.btnMickey.BackColor = System.Drawing.Color.Coral;
            this.btnMickey.BackgroundImage = global::Projeto1.Properties.Resources.mickeydisney;
            this.btnMickey.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMickey.ForeColor = System.Drawing.Color.Black;
            this.btnMickey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMickey.Location = new System.Drawing.Point(254, 110);
            this.btnMickey.Name = "btnMickey";
            this.btnMickey.Size = new System.Drawing.Size(309, 172);
            this.btnMickey.TabIndex = 0;
            this.btnMickey.Text = "      INSERIR                                      ";
            this.btnMickey.UseVisualStyleBackColor = false;
            this.btnMickey.Click += new System.EventHandler(this.btnMickey_Click);
            // 
            // lblDisney
            // 
            this.lblDisney.AutoSize = true;
            this.lblDisney.Location = new System.Drawing.Point(36, 268);
            this.lblDisney.Name = "lblDisney";
            this.lblDisney.Size = new System.Drawing.Size(116, 13);
            this.lblDisney.TabIndex = 12;
            this.lblDisney.Text = "Você já foi pra Disney?";
            this.lblDisney.Click += new System.EventHandler(this.lblDisney_Click);
            // 
            // txbDisney
            // 
            this.txbDisney.Location = new System.Drawing.Point(39, 284);
            this.txbDisney.Name = "txbDisney";
            this.txbDisney.Size = new System.Drawing.Size(100, 20);
            this.txbDisney.TabIndex = 13;
            this.txbDisney.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 9.75F);
            this.label2.Location = new System.Drawing.Point(38, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Para terminar esse quiz nada suspeito rs, digite as seguintes informações";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(38, 346);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 15;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(38, 399);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(58, 13);
            this.lblNumber.TabIndex = 16;
            this.lblNumber.Text = "NUMERO:";
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // mtxbCpf
            // 
            this.mtxbCpf.Location = new System.Drawing.Point(39, 362);
            this.mtxbCpf.Mask = "000,000,000-00";
            this.mtxbCpf.Name = "mtxbCpf";
            this.mtxbCpf.Size = new System.Drawing.Size(100, 20);
            this.mtxbCpf.TabIndex = 19;
            // 
            // mtxbNumber
            // 
            this.mtxbNumber.Location = new System.Drawing.Point(41, 418);
            this.mtxbNumber.Mask = "(00) 00000-0000";
            this.mtxbNumber.Name = "mtxbNumber";
            this.mtxbNumber.Size = new System.Drawing.Size(100, 20);
            this.mtxbNumber.TabIndex = 20;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(50, 444);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(993, 206);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CPF";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TELEFONE";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "OPINIAO";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "OPINIAO2";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "FILMEPREFE";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MUSICAPREFE";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PERSONAGEMPREFE";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "DISNEY";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Projeto1.Properties.Resources.lgbt;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(903, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 172);
            this.button1.TabIndex = 22;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Projeto1.Properties.Resources.lgbtqia;
            this.button2.Location = new System.Drawing.Point(569, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 167);
            this.button2.TabIndex = 23;
            this.button2.Text = "EXCLUIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto1.Properties.Resources.mickey;
            this.ClientSize = new System.Drawing.Size(1224, 662);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.mtxbNumber);
            this.Controls.Add(this.mtxbCpf);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDisney);
            this.Controls.Add(this.lblDisney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.txbPerson);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.txbMusic);
            this.Controls.Add(this.txbQuest);
            this.Controls.Add(this.lblQuest);
            this.Controls.Add(this.lblPront);
            this.Controls.Add(this.txbPront);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnMickey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMickey;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbPront;
        private System.Windows.Forms.Label lblPront;
        private System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.TextBox txbQuest;
        private System.Windows.Forms.TextBox txbMusic;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.TextBox txbPerson;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisney;
        private System.Windows.Forms.TextBox txbDisney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.MaskedTextBox mtxbCpf;
        private System.Windows.Forms.MaskedTextBox mtxbNumber;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button button2;
    }
}

