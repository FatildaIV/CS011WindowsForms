namespace CS011WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vystupLabel = new System.Windows.Forms.Label();
            this.Zpracovat = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vystupLabel
            // 
            this.vystupLabel.AutoSize = true;
            this.vystupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.vystupLabel.Location = new System.Drawing.Point(27, 167);
            this.vystupLabel.Name = "vystupLabel";
            this.vystupLabel.Size = new System.Drawing.Size(103, 26);
            this.vystupLabel.TabIndex = 0;
            this.vystupLabel.Text = "Výstup: ?";
            this.vystupLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Zpracovat
            // 
            this.Zpracovat.Location = new System.Drawing.Point(135, 139);
            this.Zpracovat.Name = "Zpracovat";
            this.Zpracovat.Size = new System.Drawing.Size(75, 23);
            this.Zpracovat.TabIndex = 1;
            this.Zpracovat.Text = "Zpracovat";
            this.Zpracovat.UseVisualStyleBackColor = true;
            this.Zpracovat.Click += new System.EventHandler(this.Zpracovat_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(62, 84);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(214, 20);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_1);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(123, 110);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Váš počítač byl napaden virem!\r\nZadejte heslo pro jeho záchranu.";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Zpracovat);
            this.Controls.Add(this.vystupLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Windows Defender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vystupLabel;
        private System.Windows.Forms.Button Zpracovat;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
    }
}

