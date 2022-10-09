namespace Ristorante
{
    partial class Admin
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
            this.aggiungibox = new System.Windows.Forms.Button();
            this.modificabox = new System.Windows.Forms.Button();
            this.ricercabox = new System.Windows.Forms.Button();
            this.visualizzabox = new System.Windows.Forms.Button();
            this.eliminabox = new System.Windows.Forms.Button();
            this.recuperabox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aggiungibox
            // 
            this.aggiungibox.BackColor = System.Drawing.Color.White;
            this.aggiungibox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aggiungibox.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungibox.Location = new System.Drawing.Point(26, 105);
            this.aggiungibox.Name = "aggiungibox";
            this.aggiungibox.Size = new System.Drawing.Size(160, 38);
            this.aggiungibox.TabIndex = 1;
            this.aggiungibox.Text = "AGGIUNGI";
            this.aggiungibox.UseVisualStyleBackColor = false;
            this.aggiungibox.Click += new System.EventHandler(this.addbox_Click);
            // 
            // modificabox
            // 
            this.modificabox.BackColor = System.Drawing.Color.White;
            this.modificabox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificabox.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificabox.Location = new System.Drawing.Point(222, 105);
            this.modificabox.Name = "modificabox";
            this.modificabox.Size = new System.Drawing.Size(160, 38);
            this.modificabox.TabIndex = 2;
            this.modificabox.Text = "MODIFICA";
            this.modificabox.UseVisualStyleBackColor = false;
            this.modificabox.Click += new System.EventHandler(this.editbox_Click);
            // 
            // ricercabox
            // 
            this.ricercabox.BackColor = System.Drawing.Color.White;
            this.ricercabox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ricercabox.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ricercabox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ricercabox.Location = new System.Drawing.Point(418, 105);
            this.ricercabox.Name = "ricercabox";
            this.ricercabox.Size = new System.Drawing.Size(160, 38);
            this.ricercabox.TabIndex = 3;
            this.ricercabox.Text = "RICERCA";
            this.ricercabox.UseVisualStyleBackColor = false;
            this.ricercabox.Click += new System.EventHandler(this.searchbox_Click);
            // 
            // visualizzabox
            // 
            this.visualizzabox.BackColor = System.Drawing.Color.White;
            this.visualizzabox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualizzabox.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizzabox.Location = new System.Drawing.Point(26, 224);
            this.visualizzabox.Name = "visualizzabox";
            this.visualizzabox.Size = new System.Drawing.Size(160, 38);
            this.visualizzabox.TabIndex = 5;
            this.visualizzabox.Text = "VISUALIZZA";
            this.visualizzabox.UseVisualStyleBackColor = false;
            this.visualizzabox.Click += new System.EventHandler(this.viewbox_Click);
            // 
            // eliminabox
            // 
            this.eliminabox.BackColor = System.Drawing.Color.White;
            this.eliminabox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminabox.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminabox.Location = new System.Drawing.Point(222, 224);
            this.eliminabox.Name = "eliminabox";
            this.eliminabox.Size = new System.Drawing.Size(160, 38);
            this.eliminabox.TabIndex = 6;
            this.eliminabox.Text = "ELIMINA";
            this.eliminabox.UseVisualStyleBackColor = false;
            this.eliminabox.Click += new System.EventHandler(this.deletebox_Click);
            // 
            // recuperabox
            // 
            this.recuperabox.BackColor = System.Drawing.Color.White;
            this.recuperabox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recuperabox.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuperabox.Location = new System.Drawing.Point(418, 224);
            this.recuperabox.Name = "recuperabox";
            this.recuperabox.Size = new System.Drawing.Size(160, 38);
            this.recuperabox.TabIndex = 7;
            this.recuperabox.Text = "RECUPERA";
            this.recuperabox.UseVisualStyleBackColor = false;
            this.recuperabox.Click += new System.EventHandler(this.recoverbox_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(632, 343);
            this.Controls.Add(this.recuperabox);
            this.Controls.Add(this.eliminabox);
            this.Controls.Add(this.visualizzabox);
            this.Controls.Add(this.ricercabox);
            this.Controls.Add(this.modificabox);
            this.Controls.Add(this.aggiungibox);
            this.MinimumSize = new System.Drawing.Size(566, 239);
            this.Name = "Admin";
            this.Text = "Ristorante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Proprietario_FormClosing);
            this.Load += new System.EventHandler(this.Proprietario_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button aggiungibox;
        private System.Windows.Forms.Button modificabox;
        private System.Windows.Forms.Button ricercabox;
        private System.Windows.Forms.Button visualizzabox;
        private System.Windows.Forms.Button eliminabox;
        private System.Windows.Forms.Button recuperabox;
    }
}