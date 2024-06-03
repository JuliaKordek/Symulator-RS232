
namespace WindowsFormsApp1
{
    partial class RS232
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
            this.NadajnikInput = new System.Windows.Forms.TextBox();
            this.NadajnikOutput = new System.Windows.Forms.TextBox();
            this.OdbiornikInput = new System.Windows.Forms.TextBox();
            this.OdbiornikOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NadajnikKonwertuj = new System.Windows.Forms.Button();
            this.Wyślij = new System.Windows.Forms.Button();
            this.OdbiornikKonwertuj = new System.Windows.Forms.Button();
            this.CenzuraCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // NadajnikInput
            // 
            this.NadajnikInput.Location = new System.Drawing.Point(34, 122);
            this.NadajnikInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NadajnikInput.Multiline = true;
            this.NadajnikInput.Name = "NadajnikInput";
            this.NadajnikInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NadajnikInput.Size = new System.Drawing.Size(283, 106);
            this.NadajnikInput.TabIndex = 0;
            // 
            // NadajnikOutput
            // 
            this.NadajnikOutput.Location = new System.Drawing.Point(34, 372);
            this.NadajnikOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NadajnikOutput.Multiline = true;
            this.NadajnikOutput.Name = "NadajnikOutput";
            this.NadajnikOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NadajnikOutput.Size = new System.Drawing.Size(283, 106);
            this.NadajnikOutput.TabIndex = 1;
            this.NadajnikOutput.TextChanged += new System.EventHandler(this.NadajnikBinaryTextBox_TextChanged);
            // 
            // OdbiornikInput
            // 
            this.OdbiornikInput.Location = new System.Drawing.Point(459, 122);
            this.OdbiornikInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OdbiornikInput.Multiline = true;
            this.OdbiornikInput.Name = "OdbiornikInput";
            this.OdbiornikInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OdbiornikInput.Size = new System.Drawing.Size(283, 106);
            this.OdbiornikInput.TabIndex = 2;
            // 
            // OdbiornikOutput
            // 
            this.OdbiornikOutput.Location = new System.Drawing.Point(459, 372);
            this.OdbiornikOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OdbiornikOutput.Multiline = true;
            this.OdbiornikOutput.Name = "OdbiornikOutput";
            this.OdbiornikOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OdbiornikOutput.Size = new System.Drawing.Size(283, 106);
            this.OdbiornikOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(100, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "NADAJNIK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(507, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "ODBIORNIK";
            // 
            // NadajnikKonwertuj
            // 
            this.NadajnikKonwertuj.Location = new System.Drawing.Point(132, 295);
            this.NadajnikKonwertuj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NadajnikKonwertuj.Name = "NadajnikKonwertuj";
            this.NadajnikKonwertuj.Size = new System.Drawing.Size(112, 35);
            this.NadajnikKonwertuj.TabIndex = 6;
            this.NadajnikKonwertuj.Text = "konwertuj";
            this.NadajnikKonwertuj.UseVisualStyleBackColor = true;
            this.NadajnikKonwertuj.Click += new System.EventHandler(this.NadajnikKonwertuj_Click);
            // 
            // Wyślij
            // 
            this.Wyślij.Location = new System.Drawing.Point(132, 511);
            this.Wyślij.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Wyślij.Name = "Wyślij";
            this.Wyślij.Size = new System.Drawing.Size(112, 35);
            this.Wyślij.TabIndex = 7;
            this.Wyślij.Text = "wyślij";
            this.Wyślij.UseVisualStyleBackColor = true;
            this.Wyślij.Click += new System.EventHandler(this.Wyślij_Click);
            // 
            // OdbiornikKonwertuj
            // 
            this.OdbiornikKonwertuj.Location = new System.Drawing.Point(556, 295);
            this.OdbiornikKonwertuj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OdbiornikKonwertuj.Name = "OdbiornikKonwertuj";
            this.OdbiornikKonwertuj.Size = new System.Drawing.Size(112, 35);
            this.OdbiornikKonwertuj.TabIndex = 8;
            this.OdbiornikKonwertuj.Text = "konwertuj";
            this.OdbiornikKonwertuj.UseVisualStyleBackColor = true;
            this.OdbiornikKonwertuj.Click += new System.EventHandler(this.OdbiornikKonwertuj_Click);
            // 
            // CenzuraCheckBox
            // 
            this.CenzuraCheckBox.AutoSize = true;
            this.CenzuraCheckBox.Location = new System.Drawing.Point(648, 511);
            this.CenzuraCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CenzuraCheckBox.Name = "CenzuraCheckBox";
            this.CenzuraCheckBox.Size = new System.Drawing.Size(92, 24);
            this.CenzuraCheckBox.TabIndex = 9;
            this.CenzuraCheckBox.Text = "cenzura";
            this.CenzuraCheckBox.UseVisualStyleBackColor = true;
            this.CenzuraCheckBox.CheckedChanged += new System.EventHandler(this.CenzuraCheckBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RS232
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(880, 640);
            this.Controls.Add(this.CenzuraCheckBox);
            this.Controls.Add(this.OdbiornikKonwertuj);
            this.Controls.Add(this.Wyślij);
            this.Controls.Add(this.NadajnikKonwertuj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OdbiornikOutput);
            this.Controls.Add(this.OdbiornikInput);
            this.Controls.Add(this.NadajnikOutput);
            this.Controls.Add(this.NadajnikInput);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RS232";
            this.Text = "RS232";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NadajnikInput;
        private System.Windows.Forms.TextBox NadajnikOutput;
        private System.Windows.Forms.TextBox OdbiornikInput;
        private System.Windows.Forms.TextBox OdbiornikOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NadajnikKonwertuj;
        private System.Windows.Forms.Button Wyślij;
        private System.Windows.Forms.Button OdbiornikKonwertuj;
        private System.Windows.Forms.CheckBox CenzuraCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

