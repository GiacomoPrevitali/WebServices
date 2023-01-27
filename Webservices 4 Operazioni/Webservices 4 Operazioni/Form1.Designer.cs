namespace Webservices_4_Operazioni
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Risultato = new System.Windows.Forms.TextBox();
            this.nUD = new System.Windows.Forms.NumericUpDown();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.btn_Conferma = new Client.RJButtons();
            this.btn_elimina = new Client.RJButtons();
            this.btn_modifica = new Client.RJButtons();
            this.Btn_Aggiungi = new Client.RJButtons();
            this.Btn_Leggi = new Client.RJButtons();
            this.lbl_NUP = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUD)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Risultato
            // 
            this.txt_Risultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Risultato.Location = new System.Drawing.Point(260, 86);
            this.txt_Risultato.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Risultato.Multiline = true;
            this.txt_Risultato.Name = "txt_Risultato";
            this.txt_Risultato.Size = new System.Drawing.Size(673, 385);
            this.txt_Risultato.TabIndex = 4;
            // 
            // nUD
            // 
            this.nUD.Location = new System.Drawing.Point(479, 27);
            this.nUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD.Name = "nUD";
            this.nUD.Size = new System.Drawing.Size(43, 20);
            this.nUD.TabIndex = 5;
            this.nUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD.Visible = false;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(787, 26);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(146, 20);
            this.txt_Title.TabIndex = 8;
            this.txt_Title.Visible = false;
            // 
            // btn_Conferma
            // 
            this.btn_Conferma.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Conferma.FlatAppearance.BorderSize = 0;
            this.btn_Conferma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conferma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Conferma.ForeColor = System.Drawing.Color.White;
            this.btn_Conferma.Location = new System.Drawing.Point(29, 398);
            this.btn_Conferma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Conferma.Name = "btn_Conferma";
            this.btn_Conferma.Size = new System.Drawing.Size(175, 40);
            this.btn_Conferma.TabIndex = 9;
            this.btn_Conferma.Text = "Conferma";
            this.btn_Conferma.UseVisualStyleBackColor = false;
            this.btn_Conferma.Click += new System.EventHandler(this.btn_Conferma_Click);
            // 
            // btn_elimina
            // 
            this.btn_elimina.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_elimina.FlatAppearance.BorderSize = 0;
            this.btn_elimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elimina.ForeColor = System.Drawing.Color.White;
            this.btn_elimina.Location = new System.Drawing.Point(29, 223);
            this.btn_elimina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_elimina.Name = "btn_elimina";
            this.btn_elimina.Size = new System.Drawing.Size(175, 40);
            this.btn_elimina.TabIndex = 3;
            this.btn_elimina.Text = "Elimina";
            this.btn_elimina.UseVisualStyleBackColor = false;
            this.btn_elimina.Click += new System.EventHandler(this.btn_elimina_Click);
            // 
            // btn_modifica
            // 
            this.btn_modifica.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_modifica.FlatAppearance.BorderSize = 0;
            this.btn_modifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifica.ForeColor = System.Drawing.Color.White;
            this.btn_modifica.Location = new System.Drawing.Point(29, 177);
            this.btn_modifica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.Size = new System.Drawing.Size(175, 40);
            this.btn_modifica.TabIndex = 2;
            this.btn_modifica.Text = "Modifica";
            this.btn_modifica.UseVisualStyleBackColor = false;
            this.btn_modifica.Click += new System.EventHandler(this.btn_modifica_Click);
            // 
            // Btn_Aggiungi
            // 
            this.Btn_Aggiungi.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Aggiungi.FlatAppearance.BorderSize = 0;
            this.Btn_Aggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aggiungi.ForeColor = System.Drawing.Color.White;
            this.Btn_Aggiungi.Location = new System.Drawing.Point(29, 131);
            this.Btn_Aggiungi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Aggiungi.Name = "Btn_Aggiungi";
            this.Btn_Aggiungi.Size = new System.Drawing.Size(175, 40);
            this.Btn_Aggiungi.TabIndex = 1;
            this.Btn_Aggiungi.Text = "Aggiungi";
            this.Btn_Aggiungi.UseVisualStyleBackColor = false;
            this.Btn_Aggiungi.Click += new System.EventHandler(this.Btn_Aggiungi_Click);
            // 
            // Btn_Leggi
            // 
            this.Btn_Leggi.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Leggi.FlatAppearance.BorderSize = 0;
            this.Btn_Leggi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Leggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Leggi.ForeColor = System.Drawing.Color.White;
            this.Btn_Leggi.Location = new System.Drawing.Point(29, 86);
            this.Btn_Leggi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Leggi.Name = "Btn_Leggi";
            this.Btn_Leggi.Size = new System.Drawing.Size(175, 40);
            this.Btn_Leggi.TabIndex = 0;
            this.Btn_Leggi.Text = "Leggi";
            this.Btn_Leggi.UseVisualStyleBackColor = false;
            this.Btn_Leggi.Click += new System.EventHandler(this.Btn_Leggi_Click);
            // 
            // lbl_NUP
            // 
            this.lbl_NUP.AutoSize = true;
            this.lbl_NUP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NUP.ForeColor = System.Drawing.Color.White;
            this.lbl_NUP.Location = new System.Drawing.Point(244, 29);
            this.lbl_NUP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NUP.Name = "lbl_NUP";
            this.lbl_NUP.Size = new System.Drawing.Size(227, 13);
            this.lbl_NUP.TabIndex = 10;
            this.lbl_NUP.Text = "Inserire il numero dell\'album desiderato";
            this.lbl_NUP.Visible = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(543, 29);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(236, 13);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "Inserire il titolo dell\'album da aggiungere";
            this.lbl_Title.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(969, 505);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_NUP);
            this.Controls.Add(this.btn_Conferma);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.nUD);
            this.Controls.Add(this.txt_Risultato);
            this.Controls.Add(this.btn_elimina);
            this.Controls.Add(this.btn_modifica);
            this.Controls.Add(this.Btn_Aggiungi);
            this.Controls.Add(this.Btn_Leggi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Client.RJButtons Btn_Leggi;
        private Client.RJButtons Btn_Aggiungi;
        private Client.RJButtons btn_modifica;
        private Client.RJButtons btn_elimina;
        private System.Windows.Forms.TextBox txt_Risultato;
        private System.Windows.Forms.NumericUpDown nUD;
        private System.Windows.Forms.TextBox txt_Title;
        private Client.RJButtons btn_Conferma;
        private System.Windows.Forms.Label lbl_NUP;
        private System.Windows.Forms.Label lbl_Title;
    }
}

