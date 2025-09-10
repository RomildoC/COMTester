using System;

namespace COMTester
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.cboPorta = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEnviarDados = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRecebidos = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerAtualizaPortas = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboBaudRate.Location = new System.Drawing.Point(554, 48);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(89, 21);
            this.cboBaudRate.TabIndex = 1;
            this.cboBaudRate.Text = "BaudRate";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(564, 127);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(75, 23);
            this.btnDesconectar.TabIndex = 2;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // cboPorta
            // 
            this.cboPorta.FormattingEnabled = true;
            this.cboPorta.Items.AddRange(new object[] {
            "Porta"});
            this.cboPorta.Location = new System.Drawing.Point(442, 48);
            this.cboPorta.Name = "cboPorta";
            this.cboPorta.Size = new System.Drawing.Size(86, 21);
            this.cboPorta.TabIndex = 4;
            this.cboPorta.Text = "Porta";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(448, 127);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(453, 334);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEnviarDados
            // 
            this.btnEnviarDados.Location = new System.Drawing.Point(351, 336);
            this.btnEnviarDados.Name = "btnEnviarDados";
            this.btnEnviarDados.Size = new System.Drawing.Size(83, 23);
            this.btnEnviarDados.TabIndex = 10;
            this.btnEnviarDados.Text = "Enviar Dados";
            this.btnEnviarDados.UseVisualStyleBackColor = true;
            this.btnEnviarDados.Click += new System.EventHandler(this.btnEnviarDados_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(40, 336);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(281, 20);
            this.txtEnviar.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRecebidos);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 229);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtRecebidos
            // 
            this.txtRecebidos.Location = new System.Drawing.Point(3, 16);
            this.txtRecebidos.Multiline = true;
            this.txtRecebidos.Name = "txtRecebidos";
            this.txtRecebidos.Size = new System.Drawing.Size(367, 190);
            this.txtRecebidos.TabIndex = 0;
            // 
            // timerAtualizaPortas
            // 
            this.timerAtualizaPortas.Enabled = true;
            this.timerAtualizaPortas.Interval = 5000;
            this.timerAtualizaPortas.Tick += new System.EventHandler(this.timerAtualizaPortas_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.btnEnviarDados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cboPorta);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBaudRate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cboPorta_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.ComboBox cboPorta;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEnviarDados;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRecebidos;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerAtualizaPortas;
    }
}

