namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNom = new TextBox();
            txtAge = new TextBox();
            txtDateNaiss = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(145, 9);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(160, 23);
            txtNom.TabIndex = 0;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(145, 48);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(160, 23);
            txtAge.TabIndex = 1;
            // 
            // txtDateNaiss
            // 
            txtDateNaiss.Location = new Point(145, 91);
            txtDateNaiss.Name = "txtDateNaiss";
            txtDateNaiss.Size = new Size(160, 23);
            txtDateNaiss.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 56);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "Age :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 99);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 5;
            label3.Text = "Date de naissance :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 126);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDateNaiss);
            Controls.Add(txtAge);
            Controls.Add(txtNom);
            Name = "Form1";
            Text = "Informations personnelles";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtAge;
        private TextBox txtDateNaiss;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}