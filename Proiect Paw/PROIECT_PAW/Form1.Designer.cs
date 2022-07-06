namespace PROIECT_PAW
{
    partial class Form1
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
            this.lbTitlu1 = new System.Windows.Forms.Label();
            this.lbSubTitlu1 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbParola1 = new System.Windows.Forms.Label();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btInainte = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitlu1
            // 
            this.lbTitlu1.AutoSize = true;
            this.lbTitlu1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitlu1.Location = new System.Drawing.Point(62, 45);
            this.lbTitlu1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitlu1.Name = "lbTitlu1";
            this.lbTitlu1.Size = new System.Drawing.Size(302, 26);
            this.lbTitlu1.TabIndex = 3;
            this.lbTitlu1.Text = "Conectați-vă la contul dvs. personal,";
            // 
            // lbSubTitlu1
            // 
            this.lbSubTitlu1.AutoSize = true;
            this.lbSubTitlu1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTitlu1.Location = new System.Drawing.Point(91, 72);
            this.lbSubTitlu1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSubTitlu1.Name = "lbSubTitlu1";
            this.lbSubTitlu1.Size = new System.Drawing.Size(266, 23);
            this.lbSubTitlu1.TabIndex = 4;
            this.lbSubTitlu1.Text = "pentru a vă putea gestiona portofoliul.";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(68, 165);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(157, 23);
            this.lbUser.TabIndex = 5;
            this.lbUser.Text = "Nume/Email/Telefon: ";
            // 
            // lbParola1
            // 
            this.lbParola1.AutoSize = true;
            this.lbParola1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParola1.Location = new System.Drawing.Point(154, 216);
            this.lbParola1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbParola1.Name = "lbParola1";
            this.lbParola1.Size = new System.Drawing.Size(63, 23);
            this.lbParola1.TabIndex = 6;
            this.lbParola1.Text = "Parolă: ";
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(215, 216);
            this.tbParola.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbParola.Multiline = true;
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(175, 25);
            this.tbParola.TabIndex = 1;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(65, 284);
            this.btRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(124, 57);
            this.btRegister.TabIndex = 2;
            this.btRegister.Text = "Cont nou";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btInainte
            // 
            this.btInainte.Location = new System.Drawing.Point(215, 284);
            this.btInainte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInainte.Name = "btInainte";
            this.btInainte.Size = new System.Drawing.Size(124, 57);
            this.btInainte.TabIndex = 3;
            this.btInainte.Text = "Înainte";
            this.btInainte.UseVisualStyleBackColor = true;
            this.btInainte.Click += new System.EventHandler(this.btInainte_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(215, 162);
            this.tbUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(175, 25);
            this.tbUser.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 366);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btInainte);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.lbParola1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbSubTitlu1);
            this.Controls.Add(this.lbTitlu1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Gestiune portofoliu de acţiuni  -  Autentificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitlu1;
        private System.Windows.Forms.Label lbSubTitlu1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbParola1;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btInainte;
        private System.Windows.Forms.TextBox tbUser;
    }
}

