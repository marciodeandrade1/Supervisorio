using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Supervisorio
{
    public partial class Principal : Form
    {
        //variável global
        string dados = "";
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //form load
            lblStatus.Text = "Aguardando...";
            AtualizaComunicacao();
            cbbVelocidade.SelectedText = "9600";
            Paridade();
            BitsParada();
            cbbBitsDados.SelectedText = "8";
        }

        private void BitsParada()
        {
            int i = 0;
            cbbBitsParada.Items.Clear();
            foreach (string str in Enum.GetNames(typeof(StopBits)))
            {
                cbbBitsParada.Items.Add(str);

                if (str == "One")
                    cbbBitsParada.SelectedIndex = i;
                i++;
            }
        }

        private void AtualizaComunicacao()
        {
         
                //limpa itens em cbbPorta
                cbbPorta.Items.Clear();
                //preenche combobox com porta 
                foreach (string s in SerialPort.GetPortNames())
                {
                    cbbPorta.Items.Add(s);
                }
            cbbPorta.SelectedIndex = 0;
        }
        private void Paridade()
        {
            int i = 0; //variável de controle
            cbbBitsParidade.Items.Clear(); //Limpa controle 
            //busca e adiciona variável 's' a cada item
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                cbbBitsParidade.Items.Add(s);

                //verifica se o nome recebido é None
                if (s == "None")
                    cbbBitsParidade.SelectedIndex = i;
                i++; //incrementa a variável i
            }
        }

        private void btnAbrirPorta_Click(object sender, EventArgs e)
        {
            if (PortaSerial.IsOpen) PortaSerial.Close();

            PortaSerial.PortName = cbbPorta.Text;
            PortaSerial.BaudRate = Int32.Parse(cbbVelocidade.Text);
            PortaSerial.Parity = (Parity)cbbBitsParidade.SelectedIndex;
            PortaSerial.DataBits = Int32.Parse(cbbBitsDados.Text);
            PortaSerial.StopBits = (StopBits)cbbBitsParada.SelectedIndex;

            try
            {
                PortaSerial.Open();
                btnAbrirPorta.Enabled = false;
                btnFecharPorta.Enabled = true;
                btnSair.Enabled = false;
                lblStatus.Text = "Porta " + cbbPorta.Text + " aberta";
                
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível abrir a porta selecionada", "ATENÇAÕ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Erro na porta";
            }
        }

        private void btnFecharPorta_Click(object sender, EventArgs e)
        {
            PortaSerial.Close();
            btnFecharPorta.Enabled = false;
            btnSair.Enabled = true;
            btnAbrirPorta.Enabled = true;
            lblStatus.Text = "Porta COM fechada";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (PortaSerial.IsOpen) PortaSerial.Close();
            Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(PortaSerial.IsOpen)
            {
                PortaSerial.Write(txtEnviar.Text);
            }
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dados = PortaSerial.ReadExisting();
            this.Invoke(new EventHandler(TrataDadosRecebido));
        }
        private void TrataDadosRecebido(object sender, EventArgs e)
        {
            txtReceber.Text += dados;
        }
    }
}
