namespace PROIECT_PAW
{
    partial class Cont
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
            this.tbDepuneri = new System.Windows.Forms.TextBox();
            this.btRezultat = new System.Windows.Forms.Button();
            this.lbRezultat = new System.Windows.Forms.Label();
            this.lbCont = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaRaportTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideRaportTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaRaportBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideRaportBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deseneazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lvCont = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSell = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btSell = new System.Windows.Forms.Button();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.btCalculeaza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSterge = new System.Windows.Forms.Button();
            this.cumparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDepuneri
            // 
            this.tbDepuneri.Location = new System.Drawing.Point(101, 501);
            this.tbDepuneri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDepuneri.Name = "tbDepuneri";
            this.tbDepuneri.ReadOnly = true;
            this.tbDepuneri.Size = new System.Drawing.Size(124, 22);
            this.tbDepuneri.TabIndex = 5;
            // 
            // btRezultat
            // 
            this.btRezultat.Location = new System.Drawing.Point(37, 436);
            this.btRezultat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRezultat.Name = "btRezultat";
            this.btRezultat.Size = new System.Drawing.Size(159, 47);
            this.btRezultat.TabIndex = 4;
            this.btRezultat.Text = "Afiseaza total depuneri";
            this.btRezultat.UseVisualStyleBackColor = true;
            this.btRezultat.Click += new System.EventHandler(this.btRezultat_Click);
            // 
            // lbRezultat
            // 
            this.lbRezultat.AutoSize = true;
            this.lbRezultat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRezultat.Location = new System.Drawing.Point(15, 498);
            this.lbRezultat.Name = "lbRezultat";
            this.lbRezultat.Size = new System.Drawing.Size(75, 24);
            this.lbRezultat.TabIndex = 3;
            this.lbRezultat.Text = "Depuneri";
            // 
            // lbCont
            // 
            this.lbCont.AutoSize = true;
            this.lbCont.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCont.Location = new System.Drawing.Point(268, 53);
            this.lbCont.Name = "lbCont";
            this.lbCont.Size = new System.Drawing.Size(140, 33);
            this.lbCont.TabIndex = 6;
            this.lbCont.Text = "Contul dvs. :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bDToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1417, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaRaportTxtToolStripMenuItem,
            this.deschideRaportTxtToolStripMenuItem,
            this.salveazaRaportBinarToolStripMenuItem,
            this.deschideRaportBinarToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // salveazaRaportTxtToolStripMenuItem
            // 
            this.salveazaRaportTxtToolStripMenuItem.Name = "salveazaRaportTxtToolStripMenuItem";
            this.salveazaRaportTxtToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.salveazaRaportTxtToolStripMenuItem.Text = "Salveaza Raport Txt";
            this.salveazaRaportTxtToolStripMenuItem.Click += new System.EventHandler(this.salveazaRaportTxtToolStripMenuItem_Click);
            // 
            // deschideRaportTxtToolStripMenuItem
            // 
            this.deschideRaportTxtToolStripMenuItem.Name = "deschideRaportTxtToolStripMenuItem";
            this.deschideRaportTxtToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.deschideRaportTxtToolStripMenuItem.Text = "Deschide Raport Txt";
            this.deschideRaportTxtToolStripMenuItem.Click += new System.EventHandler(this.deschideRaportTxtToolStripMenuItem_Click);
            // 
            // salveazaRaportBinarToolStripMenuItem
            // 
            this.salveazaRaportBinarToolStripMenuItem.Name = "salveazaRaportBinarToolStripMenuItem";
            this.salveazaRaportBinarToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.salveazaRaportBinarToolStripMenuItem.Text = "Salveaza Raport binar";
            this.salveazaRaportBinarToolStripMenuItem.Click += new System.EventHandler(this.salveazaRaportBinarToolStripMenuItem_Click);
            // 
            // deschideRaportBinarToolStripMenuItem
            // 
            this.deschideRaportBinarToolStripMenuItem.Name = "deschideRaportBinarToolStripMenuItem";
            this.deschideRaportBinarToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.deschideRaportBinarToolStripMenuItem.Text = "Deschide Raport binar";
            this.deschideRaportBinarToolStripMenuItem.Click += new System.EventHandler(this.deschideRaportBinarToolStripMenuItem_Click);
            // 
            // bDToolStripMenuItem
            // 
            this.bDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deseneazaToolStripMenuItem,
            this.cumparaToolStripMenuItem});
            this.bDToolStripMenuItem.Name = "bDToolStripMenuItem";
            this.bDToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.bDToolStripMenuItem.Text = "Operatii";
            // 
            // deseneazaToolStripMenuItem
            // 
            this.deseneazaToolStripMenuItem.Name = "deseneazaToolStripMenuItem";
            this.deseneazaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deseneazaToolStripMenuItem.Text = "Deseneaza";
            this.deseneazaToolStripMenuItem.Click += new System.EventHandler(this.deseneazaToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citireToolStripMenuItem,
            this.scriereToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // citireToolStripMenuItem
            // 
            this.citireToolStripMenuItem.Name = "citireToolStripMenuItem";
            this.citireToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.citireToolStripMenuItem.Text = "Citire";
            this.citireToolStripMenuItem.Click += new System.EventHandler(this.citireToolStripMenuItem_Click);
            // 
            // scriereToolStripMenuItem
            // 
            this.scriereToolStripMenuItem.Name = "scriereToolStripMenuItem";
            this.scriereToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.scriereToolStripMenuItem.Text = "Scriere";
            this.scriereToolStripMenuItem.Click += new System.EventHandler(this.scriereToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lvCont
            // 
            this.lvCont.AllowDrop = true;
            this.lvCont.CheckBoxes = true;
            this.lvCont.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvCont.GridLines = true;
            this.lvCont.HideSelection = false;
            this.lvCont.Location = new System.Drawing.Point(12, 100);
            this.lvCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvCont.Name = "lvCont";
            this.lvCont.Size = new System.Drawing.Size(659, 320);
            this.lvCont.TabIndex = 8;
            this.lvCont.UseCompatibleStateImageBehavior = false;
            this.lvCont.View = System.Windows.Forms.View.Details;
            this.lvCont.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvCont_ItemDrag);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Simbol";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Emitent";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantitate";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ultim. Pret";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pret Achizitie";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 91;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Evolutie";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Valoare";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 69;
            // 
            // lvSell
            // 
            this.lvSell.AllowDrop = true;
            this.lvSell.CheckBoxes = true;
            this.lvSell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvSell.GridLines = true;
            this.lvSell.HideSelection = false;
            this.lvSell.Location = new System.Drawing.Point(731, 100);
            this.lvSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvSell.Name = "lvSell";
            this.lvSell.Size = new System.Drawing.Size(659, 320);
            this.lvSell.TabIndex = 9;
            this.lvSell.UseCompatibleStateImageBehavior = false;
            this.lvSell.View = System.Windows.Forms.View.Details;
            this.lvSell.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvSell_DragDrop);
            this.lvSell.DragOver += new System.Windows.Forms.DragEventHandler(this.lvSell_DragOver);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Simbol";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Emitent";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Cantitate";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 73;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ultim. Pret";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 77;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Pret Achizitie";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader12.Width = 91;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Evolutie";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Valoare";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader14.Width = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(968, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Drop here for sale:";
            // 
            // btSell
            // 
            this.btSell.Location = new System.Drawing.Point(1024, 436);
            this.btSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSell.Name = "btSell";
            this.btSell.Size = new System.Drawing.Size(159, 47);
            this.btSell.TabIndex = 11;
            this.btSell.Text = "Vinde actiunile";
            this.btSell.UseVisualStyleBackColor = true;
            this.btSell.Click += new System.EventHandler(this.btSell_Click);
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(483, 501);
            this.tbValoare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.ReadOnly = true;
            this.tbValoare.Size = new System.Drawing.Size(124, 22);
            this.tbValoare.TabIndex = 14;
            // 
            // btCalculeaza
            // 
            this.btCalculeaza.Location = new System.Drawing.Point(252, 436);
            this.btCalculeaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCalculeaza.Name = "btCalculeaza";
            this.btCalculeaza.Size = new System.Drawing.Size(159, 47);
            this.btCalculeaza.TabIndex = 13;
            this.btCalculeaza.Text = "Calculeaza Valoare Portofoliu";
            this.btCalculeaza.UseVisualStyleBackColor = true;
            this.btCalculeaza.Click += new System.EventHandler(this.btCalculeaza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valoare Actiuni Portofoliu";
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(467, 436);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(159, 47);
            this.btnSterge.TabIndex = 15;
            this.btnSterge.Text = "Stergere";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // cumparaToolStripMenuItem
            // 
            this.cumparaToolStripMenuItem.Name = "cumparaToolStripMenuItem";
            this.cumparaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cumparaToolStripMenuItem.Text = "Cumpara";
            this.cumparaToolStripMenuItem.Click += new System.EventHandler(this.cumparaToolStripMenuItem_Click);
            // 
            // Cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 537);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.btCalculeaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSell);
            this.Controls.Add(this.lvCont);
            this.Controls.Add(this.lbCont);
            this.Controls.Add(this.tbDepuneri);
            this.Controls.Add(this.btRezultat);
            this.Controls.Add(this.lbRezultat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cont";
            this.Text = "Gestiune portofoliu de acţiuni  -  Cont";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDepuneri;
        public System.Windows.Forms.Button btRezultat;
        private System.Windows.Forms.Label lbRezultat;
        private System.Windows.Forms.Label lbCont;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaRaportTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideRaportTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaRaportBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideRaportBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView lvCont;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriereToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lvSell;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSell;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.Button btCalculeaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ToolStripMenuItem deseneazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cumparaToolStripMenuItem;
    }
}