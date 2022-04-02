namespace ProgramZaliczenieSosnowski
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.poleWaga = new System.Windows.Forms.TextBox();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.poleWzrost = new System.Windows.Forms.TextBox();
            this.poleWyjsciowe = new System.Windows.Forms.Label();
            this.jestes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ComboBox();
            this.listawaga = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadz wagę";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // poleWaga
            // 
            this.poleWaga.Location = new System.Drawing.Point(45, 64);
            this.poleWaga.Name = "poleWaga";
            this.poleWaga.Size = new System.Drawing.Size(117, 20);
            this.poleWaga.TabIndex = 1;
            this.poleWaga.TextChanged += new System.EventHandler(this.PoleWejsciowe_TextChanged);
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(67, 213);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 23);
            this.btnOblicz.TabIndex = 2;
            this.btnOblicz.Text = "oblicz bmi";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.BtnOblicz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wprowadz wzrost ";
            // 
            // poleWzrost
            // 
            this.poleWzrost.Location = new System.Drawing.Point(46, 148);
            this.poleWzrost.Name = "poleWzrost";
            this.poleWzrost.Size = new System.Drawing.Size(116, 20);
            this.poleWzrost.TabIndex = 5;
            this.poleWzrost.TextChanged += new System.EventHandler(this.PoleWzrost_TextChanged);
            // 
            // poleWyjsciowe
            // 
            this.poleWyjsciowe.AutoSize = true;
            this.poleWyjsciowe.Location = new System.Drawing.Point(437, 71);
            this.poleWyjsciowe.Name = "poleWyjsciowe";
            this.poleWyjsciowe.Size = new System.Drawing.Size(0, 13);
            this.poleWyjsciowe.TabIndex = 6;
            this.poleWyjsciowe.Click += new System.EventHandler(this.PoleWyjsciowe_Click);
            // 
            // jestes
            // 
            this.jestes.AutoSize = true;
            this.jestes.Location = new System.Drawing.Point(375, 101);
            this.jestes.Name = "jestes";
            this.jestes.Size = new System.Drawing.Size(0, 13);
            this.jestes.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Twoje Bmi wynosi:";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(195, 147);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(95, 21);
            this.lista.TabIndex = 10;
            // 
            // listawaga
            // 
            this.listawaga.FormattingEnabled = true;
            this.listawaga.Location = new System.Drawing.Point(195, 64);
            this.listawaga.Name = "listawaga";
            this.listawaga.Size = new System.Drawing.Size(73, 21);
            this.listawaga.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wprowadz jednostkę";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wprowadz jednostkę";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(354, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "jezeli wybierasz jednostki zmiennoprzecinkowe uzyj przecinka a nie kropki";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 299);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listawaga);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jestes);
            this.Controls.Add(this.poleWyjsciowe);
            this.Controls.Add(this.poleWzrost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.poleWaga);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kalkulator BMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox poleWaga;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poleWzrost;
        private System.Windows.Forms.Label poleWyjsciowe;
        private System.Windows.Forms.Label jestes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lista;
        private System.Windows.Forms.ComboBox listawaga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

