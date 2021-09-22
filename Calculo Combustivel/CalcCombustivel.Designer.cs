namespace WindowsFormsApplication1
{
    partial class FormCombustível
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoCombustivel = new System.Windows.Forms.ComboBox();
            this.qtdLitros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Preço_Litro_SemDesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Qtd_Total_Litros = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Preço_Litro_ComDesc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Preco_Total_Comb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a quantidade de litros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escolha o tipo de combustível";
            // 
            // tipoCombustivel
            // 
            this.tipoCombustivel.FormattingEnabled = true;
            this.tipoCombustivel.Items.AddRange(new object[] {
            "Álcool",
            "Gasolina"});
            this.tipoCombustivel.Location = new System.Drawing.Point(31, 125);
            this.tipoCombustivel.Name = "tipoCombustivel";
            this.tipoCombustivel.Size = new System.Drawing.Size(201, 21);
            this.tipoCombustivel.TabIndex = 7;
            // 
            // qtdLitros
            // 
            this.qtdLitros.Location = new System.Drawing.Point(34, 200);
            this.qtdLitros.Name = "qtdLitros";
            this.qtdLitros.Size = new System.Drawing.Size(201, 20);
            this.qtdLitros.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(65, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 33);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Preço do litro sem desconto: R$";
            // 
            // lbl_Preço_Litro_SemDesc
            // 
            this.lbl_Preço_Litro_SemDesc.AutoSize = true;
            this.lbl_Preço_Litro_SemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preço_Litro_SemDesc.Location = new System.Drawing.Point(515, 144);
            this.lbl_Preço_Litro_SemDesc.Name = "lbl_Preço_Litro_SemDesc";
            this.lbl_Preço_Litro_SemDesc.Size = new System.Drawing.Size(36, 16);
            this.lbl_Preço_Litro_SemDesc.TabIndex = 11;
            this.lbl_Preço_Litro_SemDesc.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Preço total:";
            // 
            // lbl_Qtd_Total_Litros
            // 
            this.lbl_Qtd_Total_Litros.AutoSize = true;
            this.lbl_Qtd_Total_Litros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qtd_Total_Litros.Location = new System.Drawing.Point(472, 201);
            this.lbl_Qtd_Total_Litros.Name = "lbl_Qtd_Total_Litros";
            this.lbl_Qtd_Total_Litros.Size = new System.Drawing.Size(36, 16);
            this.lbl_Qtd_Total_Litros.TabIndex = 13;
            this.lbl_Qtd_Total_Litros.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Qtd de litros abastecidos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Preço do litro com desconto: R$";
            // 
            // lbl_Preço_Litro_ComDesc
            // 
            this.lbl_Preço_Litro_ComDesc.AutoSize = true;
            this.lbl_Preço_Litro_ComDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preço_Litro_ComDesc.Location = new System.Drawing.Point(515, 174);
            this.lbl_Preço_Litro_ComDesc.Name = "lbl_Preço_Litro_ComDesc";
            this.lbl_Preço_Litro_ComDesc.Size = new System.Drawing.Size(36, 16);
            this.lbl_Preço_Litro_ComDesc.TabIndex = 17;
            this.lbl_Preço_Litro_ComDesc.Text = "0,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(392, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Calculador do preço da gasolina";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(293, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 30);
            this.panel1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(123, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Valores";
            // 
            // lbl_Preco_Total_Comb
            // 
            this.lbl_Preco_Total_Comb.BackColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Preco_Total_Comb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Preco_Total_Comb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preco_Total_Comb.ForeColor = System.Drawing.Color.Red;
            this.lbl_Preco_Total_Comb.Location = new System.Drawing.Point(293, 255);
            this.lbl_Preco_Total_Comb.Name = "lbl_Preco_Total_Comb";
            this.lbl_Preco_Total_Comb.Size = new System.Drawing.Size(112, 31);
            this.lbl_Preco_Total_Comb.TabIndex = 20;
            this.lbl_Preco_Total_Comb.Text = "0,00";
            this.lbl_Preco_Total_Comb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormCombustível
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 307);
            this.Controls.Add(this.lbl_Preco_Total_Comb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Preço_Litro_ComDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Qtd_Total_Litros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Preço_Litro_SemDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.qtdLitros);
            this.Controls.Add(this.tipoCombustivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormCombustível";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posto 5 Estrelas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCombustível_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipoCombustivel;
        private System.Windows.Forms.TextBox qtdLitros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Preço_Litro_SemDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Qtd_Total_Litros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Preço_Litro_ComDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lbl_Preco_Total_Comb;
    }
}

