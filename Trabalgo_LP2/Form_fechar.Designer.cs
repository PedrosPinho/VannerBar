﻿namespace Trabalgo_LP2
{
    partial class Form_fechar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_fechar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_fechar = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_div_contas = new System.Windows.Forms.Label();
            this.txt_div_conta = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_val_final = new System.Windows.Forms.Label();
            this.txt_val_final = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_nao_cadastrado = new System.Windows.Forms.Button();
            this.lbl_pergunta = new System.Windows.Forms.Label();
            this.btn_cadastrado = new System.Windows.Forms.Button();
            this.lbl_cpf_fechar = new System.Windows.Forms.Label();
            this.txt_cpf_fechar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_fechar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox_logo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 104);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Trabalgo_LP2.Properties.Resources.logo;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 7);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(109, 97);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 1;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(233, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_fechar
            // 
            this.lbl_fechar.AutoSize = true;
            this.lbl_fechar.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechar.Location = new System.Drawing.Point(287, 29);
            this.lbl_fechar.Name = "lbl_fechar";
            this.lbl_fechar.Size = new System.Drawing.Size(130, 41);
            this.lbl_fechar.TabIndex = 4;
            this.lbl_fechar.Text = "Fechar";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(12, 151);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(124, 57);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.Green;
            this.txt_total.Location = new System.Drawing.Point(129, 145);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(223, 63);
            this.txt_total.TabIndex = 2;
            // 
            // lbl_div_contas
            // 
            this.lbl_div_contas.AutoSize = true;
            this.lbl_div_contas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_div_contas.Location = new System.Drawing.Point(17, 240);
            this.lbl_div_contas.Name = "lbl_div_contas";
            this.lbl_div_contas.Size = new System.Drawing.Size(245, 25);
            this.lbl_div_contas.TabIndex = 3;
            this.lbl_div_contas.Text = "Dividir conta (nº de pessoas):";
            // 
            // txt_div_conta
            // 
            this.txt_div_conta.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_div_conta.Location = new System.Drawing.Point(22, 268);
            this.txt_div_conta.Name = "txt_div_conta";
            this.txt_div_conta.Size = new System.Drawing.Size(189, 32);
            this.txt_div_conta.TabIndex = 4;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calcular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.White;
            this.btn_calcular.Location = new System.Drawing.Point(263, 268);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(89, 32);
            this.btn_calcular.TabIndex = 10;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            // 
            // lbl_val_final
            // 
            this.lbl_val_final.AutoSize = true;
            this.lbl_val_final.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_val_final.Location = new System.Drawing.Point(12, 340);
            this.lbl_val_final.Name = "lbl_val_final";
            this.lbl_val_final.Size = new System.Drawing.Size(212, 57);
            this.lbl_val_final.TabIndex = 11;
            this.lbl_val_final.Text = "Valor final:";
            // 
            // txt_val_final
            // 
            this.txt_val_final.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_val_final.ForeColor = System.Drawing.Color.Green;
            this.txt_val_final.Location = new System.Drawing.Point(218, 334);
            this.txt_val_final.Name = "txt_val_final";
            this.txt_val_final.Size = new System.Drawing.Size(134, 63);
            this.txt_val_final.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(432, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 315);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(405, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 315);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 315);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel5.Controls.Add(this.txt_cpf_fechar);
            this.panel5.Controls.Add(this.lbl_cpf_fechar);
            this.panel5.Controls.Add(this.btn_cadastrado);
            this.panel5.Controls.Add(this.lbl_pergunta);
            this.panel5.Controls.Add(this.btn_nao_cadastrado);
            this.panel5.Location = new System.Drawing.Point(389, 145);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(199, 252);
            this.panel5.TabIndex = 13;
            // 
            // btn_nao_cadastrado
            // 
            this.btn_nao_cadastrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_nao_cadastrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nao_cadastrado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nao_cadastrado.ForeColor = System.Drawing.Color.White;
            this.btn_nao_cadastrado.Location = new System.Drawing.Point(44, 189);
            this.btn_nao_cadastrado.Name = "btn_nao_cadastrado";
            this.btn_nao_cadastrado.Size = new System.Drawing.Size(112, 34);
            this.btn_nao_cadastrado.TabIndex = 10;
            this.btn_nao_cadastrado.Text = "Não Cadastrado";
            this.btn_nao_cadastrado.UseVisualStyleBackColor = false;
            // 
            // lbl_pergunta
            // 
            this.lbl_pergunta.AutoSize = true;
            this.lbl_pergunta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pergunta.Location = new System.Drawing.Point(-3, 0);
            this.lbl_pergunta.Name = "lbl_pergunta";
            this.lbl_pergunta.Size = new System.Drawing.Size(10, 46);
            this.lbl_pergunta.TabIndex = 11;
            this.lbl_pergunta.Text = "\r\n\r\n";
            // 
            // btn_cadastrado
            // 
            this.btn_cadastrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_cadastrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cadastrado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrado.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrado.Location = new System.Drawing.Point(44, 138);
            this.btn_cadastrado.Name = "btn_cadastrado";
            this.btn_cadastrado.Size = new System.Drawing.Size(112, 34);
            this.btn_cadastrado.TabIndex = 12;
            this.btn_cadastrado.Text = " Cadastrado";
            this.btn_cadastrado.UseVisualStyleBackColor = false;
            // 
            // lbl_cpf_fechar
            // 
            this.lbl_cpf_fechar.AutoSize = true;
            this.lbl_cpf_fechar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf_fechar.Location = new System.Drawing.Point(23, 50);
            this.lbl_cpf_fechar.Name = "lbl_cpf_fechar";
            this.lbl_cpf_fechar.Size = new System.Drawing.Size(51, 25);
            this.lbl_cpf_fechar.TabIndex = 14;
            this.lbl_cpf_fechar.Text = "CPF:\r\n";
            this.lbl_cpf_fechar.Click += new System.EventHandler(this.lbl_cpf_fechar_Click);
            // 
            // txt_cpf_fechar
            // 
            this.txt_cpf_fechar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf_fechar.Location = new System.Drawing.Point(28, 78);
            this.txt_cpf_fechar.Name = "txt_cpf_fechar";
            this.txt_cpf_fechar.Size = new System.Drawing.Size(144, 32);
            this.txt_cpf_fechar.TabIndex = 14;
            // 
            // Form_fechar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(612, 437);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_val_final);
            this.Controls.Add(this.lbl_val_final);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_div_conta);
            this.Controls.Add(this.lbl_div_contas);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form_fechar";
            this.Text = "Form_fechar";
            this.Load += new System.EventHandler(this.Form_fechar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_fechar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_div_contas;
        private System.Windows.Forms.TextBox txt_div_conta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_val_final;
        private System.Windows.Forms.TextBox txt_val_final;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_cpf_fechar;
        private System.Windows.Forms.Button btn_cadastrado;
        private System.Windows.Forms.Label lbl_pergunta;
        private System.Windows.Forms.Button btn_nao_cadastrado;
        private System.Windows.Forms.TextBox txt_cpf_fechar;
    }
}