using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Alerta : Form
    {
        public Alerta()
        {
            InitializeComponent();
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Close();;
        }

        public void ShowWindowNitroAlert()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string link_To_Update = $"link para redirecionar p/ atualizar que ainda nao sei :V";
            Process.Start(link_To_Update);
            this.Close();
        }
    }
}
