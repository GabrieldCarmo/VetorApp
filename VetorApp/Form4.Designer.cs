namespace VetorApp
{
    partial class frmprograma3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnlimpar = new Button();
            btnsair = new Button();
            lblB = new Label();
            txtB = new TextBox();
            lblA = new Label();
            lblnum = new Label();
            txtA = new TextBox();
            txtnum = new TextBox();
            lblpesquisar = new Label();
            txtpesquisa = new TextBox();
            btnpesquisar = new Button();
            SuspendLayout();
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(640, 169);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(119, 35);
            btnlimpar.TabIndex = 23;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnsair
            // 
            btnsair.Location = new Point(640, 234);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(119, 35);
            btnsair.TabIndex = 22;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblB.Location = new Point(344, 71);
            lblB.Name = "lblB";
            lblB.Size = new Size(65, 21);
            lblB.TabIndex = 21;
            lblB.Text = "Vetor B";
            // 
            // txtB
            // 
            txtB.Location = new Point(344, 110);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.ReadOnly = true;
            txtB.ScrollBars = ScrollBars.Vertical;
            txtB.Size = new Size(248, 256);
            txtB.TabIndex = 20;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblA.Location = new Point(40, 71);
            lblA.Name = "lblA";
            lblA.Size = new Size(66, 21);
            lblA.TabIndex = 19;
            lblA.Text = "Vetor A";
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnum.Location = new Point(40, 36);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(183, 21);
            lblnum.TabIndex = 18;
            lblnum.Text = "Adicione os elementos";
            // 
            // txtA
            // 
            txtA.Location = new Point(40, 110);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.ReadOnly = true;
            txtA.ScrollBars = ScrollBars.Vertical;
            txtA.Size = new Size(248, 256);
            txtA.TabIndex = 17;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(245, 38);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(150, 23);
            txtnum.TabIndex = 16;
            txtnum.KeyDown += txtnum_KeyDown;
            // 
            // lblpesquisar
            // 
            lblpesquisar.AutoSize = true;
            lblpesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpesquisar.Location = new Point(40, 393);
            lblpesquisar.Name = "lblpesquisar";
            lblpesquisar.Size = new Size(83, 21);
            lblpesquisar.TabIndex = 24;
            lblpesquisar.Text = "Pesquisar";
            // 
            // txtpesquisa
            // 
            txtpesquisa.Location = new Point(138, 391);
            txtpesquisa.Name = "txtpesquisa";
            txtpesquisa.Size = new Size(150, 23);
            txtpesquisa.TabIndex = 25;
            // 
            // btnpesquisar
            // 
            btnpesquisar.Location = new Point(306, 391);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(113, 23);
            btnpesquisar.TabIndex = 26;
            btnpesquisar.Text = "Pesquisar";
            btnpesquisar.UseVisualStyleBackColor = true;
            btnpesquisar.Click += btnpesquisar_Click;
            // 
            // frmprograma3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnpesquisar);
            Controls.Add(txtpesquisa);
            Controls.Add(lblpesquisar);
            Controls.Add(btnlimpar);
            Controls.Add(btnsair);
            Controls.Add(lblB);
            Controls.Add(txtB);
            Controls.Add(lblA);
            Controls.Add(lblnum);
            Controls.Add(txtA);
            Controls.Add(txtnum);
            Name = "frmprograma3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programa 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlimpar;
        private Button btnsair;
        private Label lblB;
        private TextBox txtB;
        private Label lblA;
        private Label lblnum;
        private TextBox txtA;
        private TextBox txtnum;
        private Label lblpesquisar;
        private TextBox txtpesquisa;
        private Button btnpesquisar;
    }
}