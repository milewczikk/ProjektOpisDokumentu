namespace Biblioteka
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
            this.CreateXML = new System.Windows.Forms.Button();
            this.ReadXML = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateXML
            // 
            this.CreateXML.Location = new System.Drawing.Point(30, 18);
            this.CreateXML.Name = "CreateXML";
            this.CreateXML.Size = new System.Drawing.Size(171, 63);
            this.CreateXML.TabIndex = 0;
            this.CreateXML.Text = "Utwórz XML";
            this.CreateXML.UseVisualStyleBackColor = true;
            this.CreateXML.Click += new System.EventHandler(this.CreateXML_Click);
            // 
            // ReadXML
            // 
            this.ReadXML.Location = new System.Drawing.Point(259, 18);
            this.ReadXML.Name = "ReadXML";
            this.ReadXML.Size = new System.Drawing.Size(171, 63);
            this.ReadXML.TabIndex = 1;
            this.ReadXML.Text = "Odczytaj dane z XML";
            this.ReadXML.UseVisualStyleBackColor = true;
            this.ReadXML.Click += new System.EventHandler(this.ReadXML_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 287);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReadXML);
            this.Controls.Add(this.CreateXML);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateXML;
        private System.Windows.Forms.Button ReadXML;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

