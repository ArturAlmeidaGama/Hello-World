
namespace Hello_World
{
    partial class Fornecedor
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
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.chkcondesp = new System.Windows.Forms.CheckBox();
            this.rdomasc = new System.Windows.Forms.RadioButton();
            this.rdofem = new System.Windows.Forms.RadioButton();
            this.rdooutro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AM",
            "AL",
            "CE",
            "ES",
            "GO",
            "MA",
            "PA",
            "PB",
            "RO",
            "RR",
            "SE",
            "PE",
            "BA",
            "SP",
            "MG",
            "MS",
            "MT",
            "RJ",
            "PR",
            "RS",
            "PI",
            "AP",
            "RM",
            "SC",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(12, 23);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(45, 21);
            this.cboEstado.TabIndex = 0;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chkcondesp
            // 
            this.chkcondesp.AutoSize = true;
            this.chkcondesp.Location = new System.Drawing.Point(12, 61);
            this.chkcondesp.Name = "chkcondesp";
            this.chkcondesp.Size = new System.Drawing.Size(124, 17);
            this.chkcondesp.TabIndex = 1;
            this.chkcondesp.Text = "Condições Especiais";
            this.chkcondesp.UseVisualStyleBackColor = true;
            this.chkcondesp.CheckedChanged += new System.EventHandler(this.chkcondesp_CheckedChanged);
            // 
            // rdomasc
            // 
            this.rdomasc.AutoSize = true;
            this.rdomasc.Location = new System.Drawing.Point(12, 84);
            this.rdomasc.Name = "rdomasc";
            this.rdomasc.Size = new System.Drawing.Size(72, 17);
            this.rdomasc.TabIndex = 2;
            this.rdomasc.TabStop = true;
            this.rdomasc.Text = "masculino";
            this.rdomasc.UseVisualStyleBackColor = true;
            this.rdomasc.CheckedChanged += new System.EventHandler(this.rdomasc_CheckedChanged);
            // 
            // rdofem
            // 
            this.rdofem.AutoSize = true;
            this.rdofem.Location = new System.Drawing.Point(90, 84);
            this.rdofem.Name = "rdofem";
            this.rdofem.Size = new System.Drawing.Size(64, 17);
            this.rdofem.TabIndex = 3;
            this.rdofem.TabStop = true;
            this.rdofem.Text = "feminino";
            this.rdofem.UseVisualStyleBackColor = true;
            this.rdofem.CheckedChanged += new System.EventHandler(this.rdofem_CheckedChanged);
            // 
            // rdooutro
            // 
            this.rdooutro.AutoSize = true;
            this.rdooutro.Location = new System.Drawing.Point(160, 84);
            this.rdooutro.Name = "rdooutro";
            this.rdooutro.Size = new System.Drawing.Size(49, 17);
            this.rdooutro.TabIndex = 4;
            this.rdooutro.TabStop = true;
            this.rdooutro.Text = "outro";
            this.rdooutro.UseVisualStyleBackColor = true;
            this.rdooutro.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cidade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Departamento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Produto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Zelador",
            "Fornecedor",
            "Entregador",
            "Administrador",
            "RH"});
            this.cboCargo.Location = new System.Drawing.Point(12, 136);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(124, 21);
            this.cboCargo.TabIndex = 13;
            this.cboCargo.SelectedIndexChanged += new System.EventHandler(this.cboCargo_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Solicitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(273, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fornecimento de serviços";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 220);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(485, 254);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdooutro);
            this.Controls.Add(this.rdofem);
            this.Controls.Add(this.rdomasc);
            this.Controls.Add(this.chkcondesp);
            this.Controls.Add(this.cboEstado);
            this.Name = "Fornecedor";
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.Fornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.CheckBox chkcondesp;
        private System.Windows.Forms.RadioButton rdomasc;
        private System.Windows.Forms.RadioButton rdofem;
        private System.Windows.Forms.RadioButton rdooutro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
    }
}