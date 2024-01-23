using System.Linq.Expressions;

namespace calculadora
{
    public partial class Form1 : Form
    {
        private Operacao operacaoSelecionada { get; set; }

        public decimal resultado { get; set; }
        public decimal valor {  get; set; }
        
        
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao

        }
        public Form1()
        {
            InitializeComponent();

        }
        

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "0";
        
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
          
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
           
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";
           
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";
            
            
        }

        private void btnadicao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Adicao;
            valor = Convert.ToDecimal(txtresultado.Text);
            lblvalorprimario.Text = Convert.ToString(value: valor);
            txtresultado.Text = "";
            lbloperacao.Text = "+";
          
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Subtracao;
            valor = Convert.ToDecimal(txtresultado.Text);
            lblvalorprimario.Text = Convert.ToString(value: valor);
            txtresultado.Text = "";
            lbloperacao.Text = "-";
            
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Multiplicacao;
            valor = Convert.ToDecimal(txtresultado.Text);
            lblvalorprimario.Text = Convert.ToString(value: valor);
            txtresultado.Text = "";
            lbloperacao.Text = "x";
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Divisao;
            valor = Convert.ToDecimal(txtresultado.Text);
            lblvalorprimario.Text = Convert.ToString(value: valor);
            txtresultado.Text = "";
            lbloperacao.Text = "÷";


        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            lbloperacao.Text = "";
            lblvalorprimario.Text = "";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                MessageBox.Show("sem valores");
            }
            else
            {
                switch (operacaoSelecionada)
                {
                    case Operacao.Adicao:
                        resultado = valor + Convert.ToDecimal(txtresultado.Text);
                        lblvalorprimario.Text = "";
                        break;
                    case Operacao.Subtracao:
                        resultado = valor - Convert.ToDecimal(txtresultado.Text);
                        lblvalorprimario.Text = "";
                        break;
                    case Operacao.Divisao:
                        resultado = valor / Convert.ToDecimal(txtresultado.Text);
                        lblvalorprimario.Text = "";
                        break;
                    case Operacao.Multiplicacao:
                        resultado = valor * Convert.ToDecimal(txtresultado.Text);
                        lblvalorprimario.Text = "";
                        break;
                }
                lbloperacao.Text = "=";
                txtresultado.Text = Convert.ToString(resultado);

            }
        }
    }
}
