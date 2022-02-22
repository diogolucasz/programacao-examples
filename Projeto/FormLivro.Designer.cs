namespace ExemploProjeto
{
    partial class FormLivro
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
            this.executarButton = new System.Windows.Forms.Button();
            this.resultado1Label = new System.Windows.Forms.Label();
            this.pegunta1Label = new System.Windows.Forms.Label();
            this.pegunta2Label = new System.Windows.Forms.Label();
            this.resultado2Label = new System.Windows.Forms.Label();
            this.pegunta3Label = new System.Windows.Forms.Label();
            this.resultado3Label = new System.Windows.Forms.Label();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.pergunta4Label = new System.Windows.Forms.Label();
            this.funcaoDLLButton = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // executarButton
            // 
            this.executarButton.Location = new System.Drawing.Point(28, 35);
            this.executarButton.Name = "executarButton";
            this.executarButton.Size = new System.Drawing.Size(85, 28);
            this.executarButton.TabIndex = 0;
            this.executarButton.Text = "Executar";
            this.executarButton.UseVisualStyleBackColor = true;
            this.executarButton.Click += new System.EventHandler(this.executarButton_Click);
            // 
            // resultado1Label
            // 
            this.resultado1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultado1Label.Location = new System.Drawing.Point(252, 88);
            this.resultado1Label.Name = "resultado1Label";
            this.resultado1Label.Size = new System.Drawing.Size(49, 23);
            this.resultado1Label.TabIndex = 1;
            // 
            // pegunta1Label
            // 
            this.pegunta1Label.AutoSize = true;
            this.pegunta1Label.Location = new System.Drawing.Point(31, 88);
            this.pegunta1Label.Name = "pegunta1Label";
            this.pegunta1Label.Size = new System.Drawing.Size(118, 13);
            this.pegunta1Label.TabIndex = 2;
            this.pegunta1Label.Text = "Quantos livros existem?";
            // 
            // pegunta2Label
            // 
            this.pegunta2Label.AutoSize = true;
            this.pegunta2Label.Location = new System.Drawing.Point(31, 122);
            this.pegunta2Label.Name = "pegunta2Label";
            this.pegunta2Label.Size = new System.Drawing.Size(178, 13);
            this.pegunta2Label.TabIndex = 4;
            this.pegunta2Label.Text = "Quantos livros de aventura existem?";
            // 
            // resultado2Label
            // 
            this.resultado2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultado2Label.Location = new System.Drawing.Point(252, 122);
            this.resultado2Label.Name = "resultado2Label";
            this.resultado2Label.Size = new System.Drawing.Size(49, 23);
            this.resultado2Label.TabIndex = 3;
            // 
            // pegunta3Label
            // 
            this.pegunta3Label.AutoSize = true;
            this.pegunta3Label.Location = new System.Drawing.Point(31, 156);
            this.pegunta3Label.Name = "pegunta3Label";
            this.pegunta3Label.Size = new System.Drawing.Size(215, 13);
            this.pegunta3Label.TabIndex = 6;
            this.pegunta3Label.Text = "Quantos livros existem dos ultimos 3 meses?";
            // 
            // resultado3Label
            // 
            this.resultado3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultado3Label.Location = new System.Drawing.Point(252, 156);
            this.resultado3Label.Name = "resultado3Label";
            this.resultado3Label.Size = new System.Drawing.Size(49, 23);
            this.resultado3Label.TabIndex = 5;
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(366, 76);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(215, 199);
            this.resultadoListBox.TabIndex = 7;
            // 
            // pergunta4Label
            // 
            this.pergunta4Label.AutoSize = true;
            this.pergunta4Label.Location = new System.Drawing.Point(363, 60);
            this.pergunta4Label.Name = "pergunta4Label";
            this.pergunta4Label.Size = new System.Drawing.Size(77, 13);
            this.pergunta4Label.TabIndex = 8;
            this.pergunta4Label.Text = "Lista de livros?";
            // 
            // funcaoDLLButton
            // 
            this.funcaoDLLButton.Location = new System.Drawing.Point(26, 252);
            this.funcaoDLLButton.Name = "funcaoDLLButton";
            this.funcaoDLLButton.Size = new System.Drawing.Size(115, 28);
            this.funcaoDLLButton.TabIndex = 9;
            this.funcaoDLLButton.Text = "Função da DLL";
            this.funcaoDLLButton.UseVisualStyleBackColor = true;
            this.funcaoDLLButton.Click += new System.EventHandler(this.funcaoDLLButton_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(26, 226);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(170, 20);
            this.nomeTextBox.TabIndex = 10;
            this.nomeTextBox.Text = "João Francisco Melro";
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.Location = new System.Drawing.Point(28, 286);
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.Size = new System.Drawing.Size(170, 20);
            this.resultadoTextBox.TabIndex = 11;
            // 
            // FormLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 345);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.funcaoDLLButton);
            this.Controls.Add(this.pergunta4Label);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.pegunta3Label);
            this.Controls.Add(this.resultado3Label);
            this.Controls.Add(this.pegunta2Label);
            this.Controls.Add(this.resultado2Label);
            this.Controls.Add(this.pegunta1Label);
            this.Controls.Add(this.resultado1Label);
            this.Controls.Add(this.executarButton);
            this.Name = "FormLivro";
            this.Text = "FormLivro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLivro_FormClosed);
            this.Load += new System.EventHandler(this.FormLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button executarButton;
        private System.Windows.Forms.Label resultado1Label;
        private System.Windows.Forms.Label pegunta1Label;
        private System.Windows.Forms.Label pegunta2Label;
        private System.Windows.Forms.Label resultado2Label;
        private System.Windows.Forms.Label pegunta3Label;
        private System.Windows.Forms.Label resultado3Label;
        private System.Windows.Forms.ListBox resultadoListBox;
        private System.Windows.Forms.Label pergunta4Label;
        private System.Windows.Forms.Button funcaoDLLButton;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox resultadoTextBox;
    }
}