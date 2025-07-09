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


        private void getValuesOfData()
        {
            string regexString = @"^[\p{L}\s]+$";
            int linhasInvalidas = 0;

            foreach (DataGridViewRow row in dgvFinancialResults.Rows)
            {
                if (!row.IsNewRow)
                {
                    var rubric = row.Cells["Rúbrica"].Value?.ToString();
                    var currentYearStr = row.Cells["2022"].Value?.ToString();
                    var lastYearStr = row.Cells["2021"].Value?.ToString();

                    bool validRubric = Regex.IsMatch(rubric ?? "", regexString);
                    bool validCurrentYear = int.TryParse(currentYearStr, out int currentYear);
                    bool validLastYear = int.TryParse(lastYearStr, out int lastYear);

                    if (validRubric && validCurrentYear && validLastYear)
                    {
                        int variation = currentYear - lastYear;
                        double evolution = lastYear != 0 ? ((double)variation / lastYear) * 100 : 0;

                        row.Cells["Variação"].Value = variation.ToString();
                        row.Cells["Evolução %"].Value = evolution.ToString("F2");

                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        linhasInvalidas++;
                    }
                }
            }


            if (linhasInvalidas > 0)
                lblStatus.Text = $"{linhasInvalidas} linha(s) inválida(s) detectada(s).";
            else
                lblStatus.Text = "Todas as linhas são válidas e os cálculos foram atualizados.";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dgvFinancialResults.ColumnCount = 5;

            dgvFinancialResults.Columns[0].Name = "Rúbrica";
            dgvFinancialResults.Columns[1].Name = "2022";
            dgvFinancialResults.Columns[2].Name = "2021";
            dgvFinancialResults.Columns[3].Name = "Variação";
            dgvFinancialResults.Columns[4].Name = "Evolução %";

            dgvFinancialResults.Columns[3].ReadOnly = true;
            dgvFinancialResults.Columns[4].ReadOnly = true;

            lblStatus.Text =
                "Exemplo: Rúbrica='Despesas Gerais', 2022='1000', 2021='800'. Variação e Evolução são calculados.";
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
    }
}
