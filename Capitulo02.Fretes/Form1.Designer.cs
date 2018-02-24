namespace Capitulo02.Fretes
{
    partial class fretesForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.clienteLabel = new System.Windows.Forms.Label();
            this.valorLabel = new System.Windows.Forms.Label();
            this.ufLabel = new System.Windows.Forms.Label();
            this.freteLabel = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.freteTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(24, 16);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(39, 13);
            this.clienteLabel.TabIndex = 0;
            this.clienteLabel.Text = "&Cliente";
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(29, 54);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(34, 13);
            this.valorLabel.TabIndex = 2;
            this.valorLabel.Text = "&Valor:";
            // 
            // ufLabel
            // 
            this.ufLabel.AutoSize = true;
            this.ufLabel.Location = new System.Drawing.Point(39, 92);
            this.ufLabel.Name = "ufLabel";
            this.ufLabel.Size = new System.Drawing.Size(24, 13);
            this.ufLabel.TabIndex = 4;
            this.ufLabel.Text = "&UF:";
            // 
            // freteLabel
            // 
            this.freteLabel.AutoSize = true;
            this.freteLabel.Location = new System.Drawing.Point(18, 130);
            this.freteLabel.Name = "freteLabel";
            this.freteLabel.Size = new System.Drawing.Size(45, 13);
            this.freteLabel.TabIndex = 7;
            this.freteLabel.Text = "% &Frete:";
            // 
            // calcularButton
            // 
            this.calcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularButton.Location = new System.Drawing.Point(72, 200);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(273, 40);
            this.calcularButton.TabIndex = 6;
            this.calcularButton.Text = "CALCULAR FRETE";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoTextBox.Location = new System.Drawing.Point(72, 248);
            this.resultadoTextBox.Multiline = true;
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.ReadOnly = true;
            this.resultadoTextBox.Size = new System.Drawing.Size(273, 40);
            this.resultadoTextBox.TabIndex = 10;
            this.resultadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(72, 13);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(261, 20);
            this.clienteTextBox.TabIndex = 1;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(72, 47);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(140, 20);
            this.valorTextBox.TabIndex = 3;
            // 
            // ufComboBox
            // 
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "AM",
            "MG",
            "RJ",
            "SP",
            "Outros"});
            this.ufComboBox.Location = new System.Drawing.Point(72, 89);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(140, 21);
            this.ufComboBox.TabIndex = 5;
            // 
            // freteTextBox
            // 
            this.freteTextBox.Location = new System.Drawing.Point(71, 127);
            this.freteTextBox.Name = "freteTextBox";
            this.freteTextBox.ReadOnly = true;
            this.freteTextBox.Size = new System.Drawing.Size(141, 20);
            this.freteTextBox.TabIndex = 8;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 260);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 13);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "TOTAL:";
            // 
            // fretesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 328);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.freteTextBox);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.freteLabel);
            this.Controls.Add(this.ufLabel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.clienteLabel);
            this.Name = "fretesForm";
            this.Text = "Fretes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.Label ufLabel;
        private System.Windows.Forms.Label freteLabel;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.TextBox resultadoTextBox;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.TextBox freteTextBox;
        private System.Windows.Forms.Label totalLabel;
    }
}

