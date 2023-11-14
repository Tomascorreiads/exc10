using System.Diagnostics.Eventing.Reader;

namespace exc10
{
    public partial class Form1 : Form
    {
        string corret_pass = "124";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            while (true)
            {
                string pass = Microsoft.VisualBasic.Interaction.InputBox("insira a palavra passe correta", "segurança","*************************");
                if (pass == corret_pass)
                {
                    MessageBox.Show("palavra pass correta");
                    break;

                }
                else
                {
                    MessageBox.Show("Palavra pass incorreta");
                }
            }  


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bem vindo ao C#");
        }
    }
}