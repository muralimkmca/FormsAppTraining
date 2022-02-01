namespace FormsAppTraining
{
    partial class MultipleDocInterface
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datasetOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboboxOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textOperationToolStripMenuItem,
            this.datasetOperationToolStripMenuItem,
            this.dialogBoxesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textOperationToolStripMenuItem
            // 
            this.textOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboboxOperationToolStripMenuItem});
            this.textOperationToolStripMenuItem.Name = "textOperationToolStripMenuItem";
            this.textOperationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.textOperationToolStripMenuItem.Text = "TextOperation";
            this.textOperationToolStripMenuItem.Click += new System.EventHandler(this.textOperationToolStripMenuItem_Click);
            // 
            // datasetOperationToolStripMenuItem
            // 
            this.datasetOperationToolStripMenuItem.Name = "datasetOperationToolStripMenuItem";
            this.datasetOperationToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.datasetOperationToolStripMenuItem.Text = "DatasetOperation";
            this.datasetOperationToolStripMenuItem.Click += new System.EventHandler(this.datasetOperationToolStripMenuItem_Click);
            // 
            // comboboxOperationToolStripMenuItem
            // 
            this.comboboxOperationToolStripMenuItem.Name = "comboboxOperationToolStripMenuItem";
            this.comboboxOperationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.comboboxOperationToolStripMenuItem.Text = "ComboboxOperation";
            // 
            // dialogBoxesToolStripMenuItem
            // 
            this.dialogBoxesToolStripMenuItem.Name = "dialogBoxesToolStripMenuItem";
            this.dialogBoxesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.dialogBoxesToolStripMenuItem.Text = "DialogBoxes";
            this.dialogBoxesToolStripMenuItem.Click += new System.EventHandler(this.dialogBoxesToolStripMenuItem_Click);
            // 
            // MultipleDocInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MultipleDocInterface";
            this.Text = "MultipleDocInterface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MultipleDocInterface_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem textOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboboxOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datasetOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialogBoxesToolStripMenuItem;
    }
}