namespace Exercicio1_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvFinancialResults = new DataGridView();
            label1 = new Label();
            btnSalvar = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFinancialResults).BeginInit();
            SuspendLayout();
            // 
            // dgvFinancialResults
            // 
            dgvFinancialResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinancialResults.Dock = DockStyle.Bottom;
            dgvFinancialResults.Location = new Point(0, 144);
            dgvFinancialResults.Name = "dgvFinancialResults";
            dgvFinancialResults.RowTemplate.Height = 25;
            dgvFinancialResults.Size = new Size(663, 306);
            dgvFinancialResults.TabIndex = 0;
            dgvFinancialResults.CellContentClick += dgvFinancialResults_CellContentClick;
            dgvFinancialResults.CellValueChanged += dgvFinancialResults_CellValueChanged;
            dgvFinancialResults.CellValueNeeded += dgvFinancialResults_CellValueNeeded;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(542, 37);
            label1.TabIndex = 1;
            label1.Text = "Demonstração de Resultados Financeiros";
            label1.Click += label1_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(544, 115);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(119, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "recarregar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(31, 74);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(97, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "                              ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(lblStatus);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(dgvFinancialResults);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFinancialResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFinancialResults;
        private Label label1;
        private Button btnSalvar;
        private Label lblStatus;
    }
}