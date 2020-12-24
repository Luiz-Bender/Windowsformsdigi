using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.ServiceProcess;
using Microsoft.Win32;
namespace Ferramenta
{
    public partial class Servicos : Form
    {
        string nomeServico = "SincronizadorDigisat";
        string nomeServico2 = "MongoDBDigisat";
        public Servicos()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeServico))
            {
                MessageBox.Show("Informe o nome do serviço", "Nome do Servico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Deseja iniciar o serviço : " + nomeServico2 + " ?", "Iniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ServicosWin.ServicosWin.StartService("MongoDBDigisat");
                    }
                    DialogResult resultado2 = MessageBox.Show("Deseja iniciar o serviço : " + nomeServico  + " ?", "Iniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado2 == DialogResult.Yes)
                    {
                        ServicosWin.ServicosWin.StartService("SincronizadorDigisat");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message + Environment.NewLine + ex.InnerException, "Iniciar Serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeServico))
            {
                MessageBox.Show("Informe o nome do serviço", "Nome do Servico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Deseja parar serviço : " + nomeServico + " ?", "parar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ServicosWin.ServicosWin.StopService("MongoDBDigisat");
                        ServicosWin.ServicosWin.StopService("SincronizadorDigisat");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message + Environment.NewLine + ex.InnerException, "Parar Serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nomeServico))
            {
                MessageBox.Show("Informe o nome do serviço", "Nome do Servico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Deseja resetar serviço : " + nomeServico + " ?", "resetar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ServicosWin.ServicosWin.RestartService("MongoDBDigisat");
                        ServicosWin.ServicosWin.RestartService("SincronizadorDigisat");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message + Environment.NewLine + ex.InnerException, "resetar Serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste");

        }
    


        //Monta Coluna no ListView
        private void MontaColunasListView()
        {
            lvServicos.Columns.Add("Nome", 250, HorizontalAlignment.Left);
            lvServicos.Columns.Add("Status", 100, HorizontalAlignment.Left);
            lvServicos.Columns.Add("Localização", 500, HorizontalAlignment.Left);
            lvServicos.Columns.Add("Descrição", 500, HorizontalAlignment.Left);

        }

        private void lvServicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void lvServicos_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnListarServicos_Click_1(object sender, EventArgs e)
        {
            //Declarando a classe ServiceController e preenchendo um array com todos os serviços 
            //do windows usando o método GetServices()
            ServiceController[] services = ServiceController.GetServices();

            //Criando o cabeçalho com o nome das colunas no ListView
            MontaColunasListView();

            //percorre a relação de serviços e exibe no listview
            foreach (ServiceController service in services)
            {
                try
                {   //cria instância do ListViewItem
                    ListViewItem novoListViewItem = new ListViewItem();

                    //obtendo nome e status do serviço
                    novoListViewItem.Text = service.ServiceName.ToString();
                    novoListViewItem.SubItems.Add(service.Status.ToString());

                    //obtendo detalhes do serviço
                    RegistryKey regKey1 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + service.ServiceName);
                    novoListViewItem.SubItems.Add(regKey1.GetValue("ImagePath").ToString());
                    novoListViewItem.SubItems.Add(regKey1.GetValue("Description").ToString());
                    regKey1.Close();
                    //exibindo as informações
                    lvServicos.Items.Add(novoListViewItem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
