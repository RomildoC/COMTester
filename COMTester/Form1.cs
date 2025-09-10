using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
    
namespace COMTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           if (serialPort1 != null && serialPort1.IsOpen)
           {
               serialPort1.Close();
           }
        }
        private void PortaSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Lê todos os dados disponíveis no buffer da porta serial
                string dadosRecebidos = serialPort1.ReadExisting();

                // Usa Invoke para atualizar o TextBox a partir de outra thread (a da porta serial)
                // Isso é CRUCIAL para evitar exceções de cross-thread.
                this.Invoke(new Action(() =>
                {
                    txtRecebidos.AppendText(dadosRecebidos + Environment.NewLine);
                }));
            }
            catch (Exception ex)
            {
                // É uma boa prática tratar exceções que podem ocorrer se a porta for fechada
                // enquanto os dados estão sendo lidos.
                Console.WriteLine($"Erro ao receber dados: {ex.Message}");
            }
        }


        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cboPorta.Text;
                serialPort1.BaudRate = int.Parse(cboBaudRate.Text);
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.DataBits = 8;
                serialPort1.Handshake = Handshake.None;

                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(PortaSerial_DataReceived);
                AtualizarEstadoControles(true);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AtualizarEstadoControles(false);
            }
        }

    


        private void timerAtualizaPortas_Tick(object sender, EventArgs e)
        {
            // Salva a porta que está selecionada no momento (se houver alguma)
            string portaSelecionada = null;
            if (cboPorta.SelectedItem != null)
            {
                portaSelecionada = cboPorta.SelectedItem.ToString();
            }

            // Busca a lista atual de portas COM disponíveis
            string[] ports = SerialPort.GetPortNames();

            // Limpa a lista de itens do ComboBox antes de adicionar os novos
            cboPorta.Items.Clear();

            // Adiciona as portas encontradas ao ComboBox
            cboPorta.Items.AddRange(ports);

            // Se uma porta estava selecionada antes, e ela ainda existe na nova lista,
            // seleciona ela novamente para não atrapalhar o usuário.
            if (portaSelecionada != null && cboPorta.Items.Contains(portaSelecionada))
            {
                cboPorta.SelectedItem = portaSelecionada;
            }
            // Se não havia nada selecionado, ou a porta selecionada sumiu,
            // seleciona a primeira da lista (se a lista não estiver vazia)
            else if (cboPorta.Items.Count > 0)
            {
                cboPorta.SelectedIndex = 0;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1 != null && serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                AtualizarEstadoControles(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao desconectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarEstadoControles(bool conectado)
        {
            // Grupo de Configuração
            cboPorta.Enabled = !conectado;
            cboBaudRate.Enabled = !conectado;
            btnConectar.Enabled = !conectado;

            // Botão Desconectar
            btnDesconectar.Enabled = conectado;

            // Grupo de Envio de Dados
            txtEnviar.Enabled = conectado;
            btnEnviarDados.Enabled = conectado;
        }

        private void btnEnviarDados_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1 != null && serialPort1.IsOpen)
                {
                    serialPort1.Write(txtEnviar.Text);
                    txtEnviar.Clear(); // Limpa a caixa de texto após o envio
                }
                else
                {
                    MessageBox.Show("A porta não está conectada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRecebidos.Clear();
        }
    }
}
