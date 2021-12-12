
namespace Supervisorio
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.pnlConfiguracao = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbBitsParidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbBitsParada = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbBitsDados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbVelocidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPorta = new System.Windows.Forms.ComboBox();
            this.btnAbrirPorta = new System.Windows.Forms.Button();
            this.btnFecharPorta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.PortaSerial = new System.IO.Ports.SerialPort(this.components);
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.txtReceber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlConfiguracao.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConfiguracao
            // 
            this.pnlConfiguracao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConfiguracao.Controls.Add(this.label5);
            this.pnlConfiguracao.Controls.Add(this.cbbBitsParidade);
            this.pnlConfiguracao.Controls.Add(this.label4);
            this.pnlConfiguracao.Controls.Add(this.cbbBitsParada);
            this.pnlConfiguracao.Controls.Add(this.label3);
            this.pnlConfiguracao.Controls.Add(this.cbbBitsDados);
            this.pnlConfiguracao.Controls.Add(this.label2);
            this.pnlConfiguracao.Controls.Add(this.cbbVelocidade);
            this.pnlConfiguracao.Controls.Add(this.label1);
            this.pnlConfiguracao.Controls.Add(this.cbbPorta);
            this.pnlConfiguracao.Location = new System.Drawing.Point(12, 12);
            this.pnlConfiguracao.Name = "pnlConfiguracao";
            this.pnlConfiguracao.Size = new System.Drawing.Size(576, 99);
            this.pnlConfiguracao.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Paridade";
            // 
            // cbbBitsParidade
            // 
            this.cbbBitsParidade.FormattingEnabled = true;
            this.cbbBitsParidade.Location = new System.Drawing.Point(462, 35);
            this.cbbBitsParidade.Name = "cbbBitsParidade";
            this.cbbBitsParidade.Size = new System.Drawing.Size(99, 21);
            this.cbbBitsParidade.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bits Parada";
            // 
            // cbbBitsParada
            // 
            this.cbbBitsParada.FormattingEnabled = true;
            this.cbbBitsParada.Location = new System.Drawing.Point(346, 35);
            this.cbbBitsParada.Name = "cbbBitsParada";
            this.cbbBitsParada.Size = new System.Drawing.Size(99, 21);
            this.cbbBitsParada.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bits Dados";
            // 
            // cbbBitsDados
            // 
            this.cbbBitsDados.FormattingEnabled = true;
            this.cbbBitsDados.Location = new System.Drawing.Point(233, 35);
            this.cbbBitsDados.Name = "cbbBitsDados";
            this.cbbBitsDados.Size = new System.Drawing.Size(99, 21);
            this.cbbBitsDados.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidade";
            // 
            // cbbVelocidade
            // 
            this.cbbVelocidade.FormattingEnabled = true;
            this.cbbVelocidade.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbbVelocidade.Location = new System.Drawing.Point(122, 35);
            this.cbbVelocidade.Name = "cbbVelocidade";
            this.cbbVelocidade.Size = new System.Drawing.Size(99, 21);
            this.cbbVelocidade.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Porta";
            // 
            // cbbPorta
            // 
            this.cbbPorta.FormattingEnabled = true;
            this.cbbPorta.Location = new System.Drawing.Point(12, 35);
            this.cbbPorta.Name = "cbbPorta";
            this.cbbPorta.Size = new System.Drawing.Size(99, 21);
            this.cbbPorta.TabIndex = 0;
            // 
            // btnAbrirPorta
            // 
            this.btnAbrirPorta.Location = new System.Drawing.Point(594, 12);
            this.btnAbrirPorta.Name = "btnAbrirPorta";
            this.btnAbrirPorta.Size = new System.Drawing.Size(88, 23);
            this.btnAbrirPorta.TabIndex = 1;
            this.btnAbrirPorta.Text = "Abrir Porta";
            this.btnAbrirPorta.UseVisualStyleBackColor = true;
            // 
            // btnFecharPorta
            // 
            this.btnFecharPorta.Location = new System.Drawing.Point(594, 49);
            this.btnFecharPorta.Name = "btnFecharPorta";
            this.btnFecharPorta.Size = new System.Drawing.Size(88, 23);
            this.btnFecharPorta.TabIndex = 1;
            this.btnFecharPorta.Text = "Fechar Porta";
            this.btnFecharPorta.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(594, 88);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(88, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Controls.Add(this.label6);
            this.pnlStatus.Location = new System.Drawing.Point(476, 126);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(206, 85);
            this.pnlStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(17, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status";
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(26, 149);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(433, 20);
            this.txtEnviar.TabIndex = 3;
            // 
            // txtReceber
            // 
            this.txtReceber.Location = new System.Drawing.Point(26, 192);
            this.txtReceber.Name = "txtReceber";
            this.txtReceber.Size = new System.Drawing.Size(433, 20);
            this.txtReceber.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Enviar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Receber";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 253);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReceber);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFecharPorta);
            this.Controls.Add(this.btnAbrirPorta);
            this.Controls.Add(this.pnlConfiguracao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisório";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnlConfiguracao.ResumeLayout(false);
            this.pnlConfiguracao.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfiguracao;
        private System.Windows.Forms.Button btnAbrirPorta;
        private System.Windows.Forms.Button btnFecharPorta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbBitsParidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbBitsParada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbBitsDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbVelocidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPorta;
        private System.IO.Ports.SerialPort PortaSerial;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.TextBox txtReceber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

