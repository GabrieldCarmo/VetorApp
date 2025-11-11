namespace VetorApp
{
    partial class frmprograma2
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
            SuspendLayout();
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(637, 201);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(119, 35);
            btnlimpar.TabIndex = 15;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnsair
            // 
            btnsair.Location = new Point(637, 262);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(119, 35);
            btnsair.TabIndex = 14;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblB.Location = new Point(348, 100);
            lblB.Name = "lblB";
            lblB.Size = new Size(65, 21);
            lblB.TabIndex = 13;
            lblB.Text = "Vetor B";
            // 
            // txtB
            // 
            txtB.Location = new Point(348, 147);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.ReadOnly = true;
            txtB.ScrollBars = ScrollBars.Vertical;
            txtB.Size = new Size(248, 256);
            txtB.TabIndex = 12;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblA.Location = new Point(44, 100);
            lblA.Name = "lblA";
            lblA.Size = new Size(66, 21);
            lblA.TabIndex = 11;
            lblA.Text = "Vetor A";
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnum.Location = new Point(44, 48);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(183, 21);
            lblnum.TabIndex = 10;
            lblnum.Text = "Adicione os elementos";
            // 
            // txtA
            // 
            txtA.Location = new Point(44, 147);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.ReadOnly = true;
            txtA.ScrollBars = ScrollBars.Vertical;
            txtA.Size = new Size(248, 256);
            txtA.TabIndex = 9;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(249, 50);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(150, 23);
            txtnum.TabIndex = 8;
            txtnum.KeyDown += txtnum_KeyDown;
            // 
            // frmprograma2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlimpar);
            Controls.Add(btnsair);
            Controls.Add(lblB);
            Controls.Add(txtB);
            Controls.Add(lblA);
            Controls.Add(lblnum);
            Controls.Add(txtA);
            Controls.Add(txtnum);
            Name = "frmprograma2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programa 2";
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
    }
}