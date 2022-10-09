namespace Ristorante
{
    partial class Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.ordini = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totprice = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredienti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            // 
            // ordini
            // 
            this.ordini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordini.FormattingEnabled = true;
            this.ordini.ItemHeight = 20;
            this.ordini.Location = new System.Drawing.Point(815, 105);
            this.ordini.Name = "ordini";
            this.ordini.Size = new System.Drawing.Size(452, 384);
            this.ordini.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(863, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "RIMUOVI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chartreuse;
            this.button2.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1095, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "ORDINA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(968, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "PREZZO";
            // 
            // totprice
            // 
            this.totprice.AutoSize = true;
            this.totprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totprice.ForeColor = System.Drawing.Color.White;
            this.totprice.Location = new System.Drawing.Point(1081, 507);
            this.totprice.Name = "totprice";
            this.totprice.Size = new System.Drawing.Size(18, 20);
            this.totprice.TabIndex = 13;
            this.totprice.Text = "0";
            // 
            // menu
            // 
            this.menu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.ingredienti,
            this.prezzo});
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.HideSelection = false;
            this.menu.Location = new System.Drawing.Point(29, 105);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(749, 478);
            this.menu.TabIndex = 15;
            this.menu.UseCompatibleStateImageBehavior = false;
            this.menu.View = System.Windows.Forms.View.Details;
            this.menu.SelectedIndexChanged += new System.EventHandler(this.menu_SelectedIndexChanged);
            this.menu.DoubleClick += new System.EventHandler(this.menu_DoubleClick);
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 240;
            // 
            // ingredienti
            // 
            this.ingredienti.Text = "Ingredienti";
            this.ingredienti.Width = 441;
            // 
            // prezzo
            // 
            this.prezzo.Tag = "prezzo";
            this.prezzo.Text = "Prezzo";
            this.prezzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prezzo.Width = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(931, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 55);
            this.label2.TabIndex = 16;
            this.label2.Text = "ORDINI";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1341, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.totprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ordini);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1079, 650);
            this.Name = "Cliente";
            this.Text = "Ristorante";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ordini;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totprice;
        private System.Windows.Forms.ListView menu;
        private System.Windows.Forms.ColumnHeader prezzo;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader ingredienti;
        private System.Windows.Forms.Label label2;
    }
}