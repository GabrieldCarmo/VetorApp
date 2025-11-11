namespace VetorApp
{
    partial class frmmenu
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
            menuStrip1 = new MenuStrip();
            programasToolStripMenuItem = new ToolStripMenuItem();
            programa1ToolStripMenuItem = new ToolStripMenuItem();
            programa2ToolStripMenuItem = new ToolStripMenuItem();
            programa3ToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programasToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            programasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { programa1ToolStripMenuItem, programa2ToolStripMenuItem, programa3ToolStripMenuItem });
            programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            programasToolStripMenuItem.Size = new Size(76, 20);
            programasToolStripMenuItem.Text = "Programas";
            // 
            // programa1ToolStripMenuItem
            // 
            programa1ToolStripMenuItem.Name = "programa1ToolStripMenuItem";
            programa1ToolStripMenuItem.Size = new Size(135, 22);
            programa1ToolStripMenuItem.Text = "Programa 1";
            programa1ToolStripMenuItem.Click += programa1ToolStripMenuItem_Click;
            // 
            // programa2ToolStripMenuItem
            // 
            programa2ToolStripMenuItem.Name = "programa2ToolStripMenuItem";
            programa2ToolStripMenuItem.Size = new Size(135, 22);
            programa2ToolStripMenuItem.Text = "Programa 2";
            programa2ToolStripMenuItem.Click += programa2ToolStripMenuItem_Click;
            // 
            // programa3ToolStripMenuItem
            // 
            programa3ToolStripMenuItem.Name = "programa3ToolStripMenuItem";
            programa3ToolStripMenuItem.Size = new Size(135, 22);
            programa3ToolStripMenuItem.Text = "Programa 3";
            programa3ToolStripMenuItem.Click += programa3ToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem programasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem programa1ToolStripMenuItem;
        private ToolStripMenuItem programa2ToolStripMenuItem;
        private ToolStripMenuItem programa3ToolStripMenuItem;
    }
}
