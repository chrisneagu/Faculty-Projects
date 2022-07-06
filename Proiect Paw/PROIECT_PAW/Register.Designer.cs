namespace PROIECT_PAW
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.btInregistrare = new System.Windows.Forms.Button();
            this.tbParola2 = new System.Windows.Forms.TextBox();
            this.tbParola1 = new System.Windows.Forms.TextBox();
            this.lbParola2 = new System.Windows.Forms.Label();
            this.lbParola1 = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(178, 32);
            this.tbNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNume.Multiline = true;
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(192, 25);
            this.tbNume.TabIndex = 0;
            // 
            // btInregistrare
            // 
            this.btInregistrare.Location = new System.Drawing.Point(68, 296);
            this.btInregistrare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInregistrare.Name = "btInregistrare";
            this.btInregistrare.Size = new System.Drawing.Size(212, 42);
            this.btInregistrare.TabIndex = 5;
            this.btInregistrare.Text = "Înregistrare";
            this.btInregistrare.UseVisualStyleBackColor = true;
            this.btInregistrare.Click += new System.EventHandler(this.btInregistrare_Click);
            // 
            // tbParola2
            // 
            this.tbParola2.Location = new System.Drawing.Point(178, 236);
            this.tbParola2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbParola2.Multiline = true;
            this.tbParola2.Name = "tbParola2";
            this.tbParola2.Size = new System.Drawing.Size(192, 25);
            this.tbParola2.TabIndex = 4;
            // 
            // tbParola1
            // 
            this.tbParola1.Location = new System.Drawing.Point(178, 181);
            this.tbParola1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbParola1.Multiline = true;
            this.tbParola1.Name = "tbParola1";
            this.tbParola1.Size = new System.Drawing.Size(192, 25);
            this.tbParola1.TabIndex = 3;
            // 
            // lbParola2
            // 
            this.lbParola2.AutoSize = true;
            this.lbParola2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParola2.Location = new System.Drawing.Point(8, 241);
            this.lbParola2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbParola2.Name = "lbParola2";
            this.lbParola2.Size = new System.Drawing.Size(174, 19);
            this.lbParola2.TabIndex = 15;
            this.lbParola2.Text = "Reintroduceți parola: ";
            // 
            // lbParola1
            // 
            this.lbParola1.AutoSize = true;
            this.lbParola1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParola1.Location = new System.Drawing.Point(107, 186);
            this.lbParola1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbParola1.Name = "lbParola1";
            this.lbParola1.Size = new System.Drawing.Size(68, 19);
            this.lbParola1.TabIndex = 14;
            this.lbParola1.Text = "Parolă: ";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNume.Location = new System.Drawing.Point(112, 37);
            this.lbNume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(64, 19);
            this.lbNume.TabIndex = 13;
            this.lbNume.Text = "Nume: ";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(178, 89);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(192, 25);
            this.tbEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email: ";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(178, 137);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTelefon.Multiline = true;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(192, 25);
            this.tbTelefon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Telefon: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 366);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.btInregistrare);
            this.Controls.Add(this.tbParola2);
            this.Controls.Add(this.tbParola1);
            this.Controls.Add(this.lbParola2);
            this.Controls.Add(this.lbParola1);
            this.Controls.Add(this.lbNume);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Register";
            this.Text = "Gestiune portofoliu de acţiuni  -  Înregistrare";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Button btInregistrare;
        private System.Windows.Forms.TextBox tbParola2;
        private System.Windows.Forms.TextBox tbParola1;
        private System.Windows.Forms.Label lbParola2;
        private System.Windows.Forms.Label lbParola1;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}