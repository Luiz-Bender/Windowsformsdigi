using System;
using System.Windows.Forms;
using System.Threading;
using System.Security.Principal;
using System.Diagnostics;
using System.Reflection;


namespace Ferramenta
{
    public partial class Tela1 : Form
    {
        Thread t1;
        public Tela1()
        {
            
            rodarComoAdmin();
            InitializeComponent();

        }
        
        private void rodarComoAdmin()
        {
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool administrativeMode = principal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!administrativeMode)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.Verb = "runas";
                startInfo.FileName = Assembly.GetExecutingAssembly().CodeBase;
                try
                {
                    
                   // Process.Start(startInfo);//ta iniciando a segunda aba como adm
                    MessageBox.Show("Você esta executando o projeto com nível de Administrador !", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch
                {
                    throw new Exception("Não foi possível conceder acesso como Admin" + Environment.NewLine + "As operações realizadas poderão ter Acesso Negado !");
                }
            }
        }

        private void comandosServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool administrativeMode = principal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!administrativeMode)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.Verb = "runas";
                startInfo.FileName = Assembly.GetExecutingAssembly().CodeBase;
                Process.Start(startInfo);
                t1 = new Thread(abrirJanelas);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }
        private void abrirJanelas(object obj)
        {
            Application.Run(new Servicos());
        }
    }
}
