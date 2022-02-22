namespace ExemploProjeto
{
    partial class FormInicio
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
            this.projetoButton = new System.Windows.Forms.Button();
            this.lojaButton = new System.Windows.Forms.Button();
            this.comboioButton = new System.Windows.Forms.Button();
            this.livroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projetoButton
            // 
            this.projetoButton.Location = new System.Drawing.Point(18, 28);
            this.projetoButton.Name = "projetoButton";
            this.projetoButton.Size = new System.Drawing.Size(138, 35);
            this.projetoButton.TabIndex = 0;
            this.projetoButton.Text = "Projeto";
            this.projetoButton.UseVisualStyleBackColor = true;
            this.projetoButton.Click += new System.EventHandler(this.projetoButton_Click);
            // 
            // lojaButton
            // 
            this.lojaButton.Location = new System.Drawing.Point(18, 78);
            this.lojaButton.Name = "lojaButton";
            this.lojaButton.Size = new System.Drawing.Size(138, 35);
            this.lojaButton.TabIndex = 1;
            this.lojaButton.Text = "Loja";
            this.lojaButton.UseVisualStyleBackColor = true;
            this.lojaButton.Click += new System.EventHandler(this.lojaButton_Click);
            // 
            // comboioButton
            // 
            this.comboioButton.Location = new System.Drawing.Point(18, 131);
            this.comboioButton.Name = "comboioButton";
            this.comboioButton.Size = new System.Drawing.Size(138, 35);
            this.comboioButton.TabIndex = 2;
            this.comboioButton.Text = "Comboio";
            this.comboioButton.UseVisualStyleBackColor = true;
            this.comboioButton.Click += new System.EventHandler(this.comboioButton_Click);
            // 
            // livroButton
            // 
            this.livroButton.Location = new System.Drawing.Point(18, 185);
            this.livroButton.Name = "livroButton";
            this.livroButton.Size = new System.Drawing.Size(138, 35);
            this.livroButton.TabIndex = 3;
            this.livroButton.Text = "Livro";
            this.livroButton.UseVisualStyleBackColor = true;
            this.livroButton.Click += new System.EventHandler(this.livroButton_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 251);
            this.Controls.Add(this.livroButton);
            this.Controls.Add(this.comboioButton);
            this.Controls.Add(this.lojaButton);
            this.Controls.Add(this.projetoButton);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button projetoButton;
        private System.Windows.Forms.Button lojaButton;
        private System.Windows.Forms.Button comboioButton;
        private System.Windows.Forms.Button livroButton;
    }
}