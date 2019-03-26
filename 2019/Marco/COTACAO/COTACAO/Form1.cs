using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COTACAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //https://www3.bcb.gov.br/sgspub/JSP/sgsgeral/FachadaWSSGS.wsdl

            var service = new Moeda.FachadaWSSGSClient();
            var cotacao = service.getUltimoValorVO(10813);
            string valor = (cotacao.ultimoValor.svalor).ToString();
            MessageBox.Show(valor);
        }
    }
}
