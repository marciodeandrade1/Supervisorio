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
        string status = "";
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
    }
}
