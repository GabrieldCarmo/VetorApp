namespace VetorApp
{
    partial class frmprograma1
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
            txtnum = new TextBox();
            txtA = new TextBox();
            lblnum = new Label();
            lblA = new Label();
            lblB = new Label();
            txtB = new TextBox();
            btnsair = new Button();
            btnlimpar = new Button();
            SuspendLayout();
            // 
            // txtnum
            // 
            txtnum.Location = new Point(254, 62);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(150, 23);
            txtnum.TabIndex = 0;
            txtnum.KeyDown += txtnum_KeyDown;
            // 
            // txtA
            // 
            txtA.Location = new Point(49, 159);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.ReadOnly = true;
            txtA.ScrollBars = ScrollBars.Vertical;
            txtA.Size = new Size(248, 256);
            txtA.TabIndex = 1;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnum.Location = new Point(49, 60);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(183, 21);
            lblnum.TabIndex = 2;
            lblnum.Text = "Adicione os elementos";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblA.Location = new Point(49, 112);
            lblA.Name = "lblA";
            lblA.Size = new Size(66, 21);
            lblA.TabIndex = 3;
            lblA.Text = "Vetor A";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblB.Location = new Point(353, 112);
            lblB.Name = "lblB";
            lblB.Size = new Size(65, 21);
            lblB.TabIndex = 5;
            lblB.Text = "Vetor B";
            // 
            // txtB
            // 
            txtB.Location = new Point(353, 159);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.ReadOnly = true;
            txtB.ScrollBars = ScrollBars.Vertical;
            txtB.Size = new Size(248, 256);
            txtB.TabIndex = 4;
            // 
            // btnsair
            // 
            btnsair.Location = new Point(642, 274);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(119, 35);
            btnsair.TabIndex = 6;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(642, 213);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(119, 35);
            btnlimpar.TabIndex = 7;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // frmprograma1
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
            Name = "frmprograma1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programa 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnum;
        private TextBox txtA;
        private Label lblnum;
        private Label lblA;
        private Label lblB;
        private TextBox txtB;
        private Button btnsair;
        private Button btnlimpar;
    }
}