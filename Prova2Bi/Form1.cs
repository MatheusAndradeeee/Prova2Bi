namespace Prova2Bi
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            tx_taxa.Text = "";
             tx_total.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tx_matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string matricula = tx_matricula.Text;
            string cpf2 = cpf.Text;
            string funcao1 = tx_funcao.Text;
            double sala= Convert.ToDouble(tx_salario.Text);

            double total1 = 0;
            double taxa1= 0;
            double descontoTaxa = 0;
            
            if (funcao1 == "Médico")
            {
                
                total1 = sala + (sala*0.20);
                tx_total.Text = Convert.ToString(total1.ToString());
               

            }
            else if (funcao1 == "TI")
            {
                
                total1 = sala + 5600;
                tx_total.Text = Convert.ToString(total1.ToString());
            }

            else if (funcao1 == "ADM")
            {
                
                total1 = sala +(sala*0.15) + 200;
                tx_total.Text = Convert.ToString(total1.ToString());
            }
            if(total1 > 5000)
            {
                taxa1 = total1 * 0.17;
                descontoTaxa = total1 - taxa1;
                tx_total.Text = Convert.ToString(descontoTaxa.ToString());
                tx_taxa.Text = Convert.ToString(taxa1.ToString());
            }
            else { tx_taxa.Text = ""; }

        }

        private void tx_salario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}