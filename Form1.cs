using Microsoft.VisualBasic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Exercicio1_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private string variation( int lastYear,  int currentYear)
        {
            return (currentYear - lastYear).ToString();
        }

        private string evoluiton( int lastYear,  int variation)
        {
            return (lastYear / variation).ToString();
        }

        private void operation(string year)
        {



            var rows = dgvFinancialResults.Rows;

            var cellVolumeDeNegocio =  int.Parse(rows[0].Cells[year].Value.ToString());

            var cellCMVMC = int.Parse(rows[1].Cells[year].Value.ToString());
            var cellPessoal =  int.Parse(rows[2].Cells[year].Value.ToString());
            var cellFST =  int.Parse(rows[3].Cells[year].Value.ToString());
            var somaEbitda = cellVolumeDeNegocio + cellCMVMC + cellPessoal + cellFST;
            var cellEbitDA = rows[4].Cells[year];
            cellEbitDA.Value = somaEbitda.ToString();

            var MargemEBITDA = cellVolumeDeNegocio / somaEbitda + "%";

            var cellMargemEBITDA = rows[5].Cells[year];
            cellMargemEBITDA.Value = MargemEBITDA;

            var resultExtra = rows[6].Cells[year];

            var somaEBITDAAjustado = somaEbitda +  int.Parse(resultExtra.Value.ToString());
            rows[7].Cells[year].Value = somaEBITDAAjustado;
            var somaEbit = somaEbitda -  int.Parse(rows[8].Cells[year].Value.ToString());

            rows[9].Cells[year].Value = somaEbit.ToString();

            var somaMargemEbit = somaEbitda / somaEbit;

            rows[10].Cells[year].Value = somaMargemEbit.ToString();


            var somaEbit1T =  int.Parse(rows[11].Cells[year].Value.ToString()) + somaEbit;

            rows[12].Cells[year].Value = somaEbit1T;

            var somaMarginEbit1T = somaEbit1T / somaEbitda;

            rows[13].Cells[year].Value = somaMarginEbit1T;

            var somaRLI = (0 + somaEbit) -  int.Parse(rows[14].Cells[year].Value.ToString());

            rows[15].Cells[year].Value = somaRLI.ToString();

            rows[16].Cells[year].Value = ( int.Parse(rows[8].Cells[year].Value.ToString()) + somaRLI).ToString();







        }


        private void getValuesOfData()
        {

            operation("2022");
            operation("2021");
            var rows = dgvFinancialResults.Rows;
            for (int i = 0; i <= 17; i++)
            {
                var valueOfCurrentYear =  int.Parse(rows[i].Cells["2022"].Value.ToString().Replace("%", ""));
                var valueOfLastYear =  int.Parse(rows[i].Cells["2021"].Value.ToString().Replace("%", ""));
                var variationResult = variation(valueOfLastYear, valueOfCurrentYear);
                rows[i].Cells["Variação"].Value = variationResult;
                rows[i].Cells["Evolução %"].Value = evoluiton(valueOfLastYear,  int.Parse(variationResult));
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dgvFinancialResults.ColumnCount = 5;

            dgvFinancialResults.Columns[0].Name = "Rúbrica";
            dgvFinancialResults.Columns[1].Name = "2022";
            dgvFinancialResults.Columns[2].Name = "2021";
            dgvFinancialResults.Columns[3].Name = "Variação";
            dgvFinancialResults.Columns[4].Name = "Evolução %";

            //dgvFinancialResults.Columns[0].ReadOnly = true;
            //dgvFinancialResults.Columns[1].ReadOnly = true;
            //dgvFinancialResults.Columns[2].ReadOnly = true;
            //dgvFinancialResults.Columns[3].ReadOnly = true;
            //dgvFinancialResults.Columns[4].ReadOnly = true;

            dgvFinancialResults.Rows.Add("Volume de Negócio", "2709694189,96", "1562919606,74", "", "");
            dgvFinancialResults.Rows.Add("CMVMC", "0", "1000", "0", "");
            dgvFinancialResults.Rows.Add("Pessoal", "585000", "399800", "", "");
            dgvFinancialResults.Rows.Add("FST", "1890616862,1", "1519124567,19", "", "");
            dgvFinancialResults.Rows.Add("EBITDA", "0", "1000", "0", "");
            dgvFinancialResults.Rows.Add("Margem EBITDA", "0", "0", "", "");
            dgvFinancialResults.Rows.Add("Resultado Não Operacional e extraordinário", "0", "0", "", "");
            dgvFinancialResults.Rows.Add("EBITDA ajustado", "0", "0", "", "");
            dgvFinancialResults.Rows.Add("Depreciações", "39386344,77", "6735369,02", "", "");
            dgvFinancialResults.Rows.Add("EBIT", "0", "0", "", "");
            dgvFinancialResults.Rows.Add("Margem Ebit", "0", "0", "", "");
            dgvFinancialResults.Rows.Add("Resultados Financeiros", "-2688203,46", "-1787437,75", "", "");
            dgvFinancialResults.Rows.Add("Ebit 1-T", "0", "0", "", "");
            dgvFinancialResults.Rows.Add("Margem EBIT 1-T", "0", "0", "", "");
            dgvFinancialResults.Rows.Add("Imposto", "190698573,99", "8718108,2", "", "");
            dgvFinancialResults.Rows.Add("RLI", "0", "0", "", "");
            dgvFinancialResults.Rows.Add("CASH FLOW", "0", "0", "", "");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            getValuesOfData();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvFinancialResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ////if (dgvFinancialResults.CurrentCell != null)
            ////{
            ////    int colunaIndex = dgvFinancialResults.CurrentCell.ColumnIndex;
            ////    string nomeColuna = dgvFinancialResults.Columns[colunaIndex].Name;
            ////    var valor = dgvFinancialResults.CurrentCell.Value?.ToString();

            ////    MessageBox.Show($"Coluna: {nomeColuna}\nValor: {valor}");
            ////}
        }

        private void dgvFinancialResults_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {


        }

        private void dgvFinancialResults_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            operation("2022");
        }

    }
}
