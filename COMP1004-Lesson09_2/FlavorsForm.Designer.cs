namespace COMP1004_Lesson09_2
{
    partial class flavorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flavorsForm));
            this.coffeeComboBox = new System.Windows.Forms.ComboBox();
            this.selectionGroupBox = new System.Windows.Forms.GroupBox();
            this.syrupListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSelectedFlavorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllFlavorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCoffeeFlavorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCoffeeFlavorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCoffeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countCoffeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllDocument = new System.Drawing.Printing.PrintDocument();
            this.printSelectedDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.selectionGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coffeeComboBox
            // 
            this.coffeeComboBox.FormattingEnabled = true;
            this.coffeeComboBox.Items.AddRange(new object[] {
            "",
            "Chocolate Almond",
            "Espresso Roast",
            "Jamaica Blue Mountain",
            "Kona Blend",
            "Vanilla Nut"});
            this.coffeeComboBox.Location = new System.Drawing.Point(6, 45);
            this.coffeeComboBox.Name = "coffeeComboBox";
            this.coffeeComboBox.Size = new System.Drawing.Size(207, 21);
            this.coffeeComboBox.Sorted = true;
            this.coffeeComboBox.TabIndex = 0;
            // 
            // selectionGroupBox
            // 
            this.selectionGroupBox.Controls.Add(this.syrupListBox);
            this.selectionGroupBox.Controls.Add(this.label3);
            this.selectionGroupBox.Controls.Add(this.label2);
            this.selectionGroupBox.Controls.Add(this.coffeeComboBox);
            this.selectionGroupBox.Location = new System.Drawing.Point(12, 47);
            this.selectionGroupBox.Name = "selectionGroupBox";
            this.selectionGroupBox.Size = new System.Drawing.Size(556, 189);
            this.selectionGroupBox.TabIndex = 1;
            this.selectionGroupBox.TabStop = false;
            this.selectionGroupBox.Text = "Select Coffee and Syrup";
            // 
            // syrupListBox
            // 
            this.syrupListBox.FormattingEnabled = true;
            this.syrupListBox.Items.AddRange(new object[] {
            "(None)",
            "Chocolate",
            "Hazelnut",
            "Irish Creme",
            "Orange"});
            this.syrupListBox.Location = new System.Drawing.Point(248, 32);
            this.syrupListBox.Name = "syrupListBox";
            this.syrupListBox.Size = new System.Drawing.Size(291, 147);
            this.syrupListBox.Sorted = true;
            this.syrupListBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Syrup Flavor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Coffee Flavor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coffee and Syrup Selection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSelectedFlavorsToolStripMenuItem,
            this.printAllFlavorsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printSelectedFlavorsToolStripMenuItem
            // 
            this.printSelectedFlavorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSelectedToolStripMenuItem,
            this.previewSelectedToolStripMenuItem});
            this.printSelectedFlavorsToolStripMenuItem.Name = "printSelectedFlavorsToolStripMenuItem";
            this.printSelectedFlavorsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.printSelectedFlavorsToolStripMenuItem.Text = "Print &Selected Flavors";
            // 
            // printSelectedToolStripMenuItem
            // 
            this.printSelectedToolStripMenuItem.Name = "printSelectedToolStripMenuItem";
            this.printSelectedToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.printSelectedToolStripMenuItem.Text = "&Print Selected";
            // 
            // previewSelectedToolStripMenuItem
            // 
            this.previewSelectedToolStripMenuItem.Name = "previewSelectedToolStripMenuItem";
            this.previewSelectedToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.previewSelectedToolStripMenuItem.Text = "Pre&view Selected";
            // 
            // printAllFlavorsToolStripMenuItem
            // 
            this.printAllFlavorsToolStripMenuItem.Name = "printAllFlavorsToolStripMenuItem";
            this.printAllFlavorsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.printAllFlavorsToolStripMenuItem.Text = "Print &All Flavors";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCoffeeFlavorToolStripMenuItem,
            this.removeCoffeeFlavorToolStripMenuItem,
            this.clearCoffeeListToolStripMenuItem,
            this.countCoffeeListToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addCoffeeFlavorToolStripMenuItem
            // 
            this.addCoffeeFlavorToolStripMenuItem.Name = "addCoffeeFlavorToolStripMenuItem";
            this.addCoffeeFlavorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addCoffeeFlavorToolStripMenuItem.Text = "&Add Coffee Flavor";
            // 
            // removeCoffeeFlavorToolStripMenuItem
            // 
            this.removeCoffeeFlavorToolStripMenuItem.Name = "removeCoffeeFlavorToolStripMenuItem";
            this.removeCoffeeFlavorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.removeCoffeeFlavorToolStripMenuItem.Text = "&Remove Coffee Flavor";
            // 
            // clearCoffeeListToolStripMenuItem
            // 
            this.clearCoffeeListToolStripMenuItem.Name = "clearCoffeeListToolStripMenuItem";
            this.clearCoffeeListToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.clearCoffeeListToolStripMenuItem.Text = "&Clear Coffee List";
            // 
            // countCoffeeListToolStripMenuItem
            // 
            this.countCoffeeListToolStripMenuItem.Name = "countCoffeeListToolStripMenuItem";
            this.countCoffeeListToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.countCoffeeListToolStripMenuItem.Text = "Count Coffee &List";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // flavorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectionGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "flavorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R\' and R for Reading and Refreshments";
            this.selectionGroupBox.ResumeLayout(false);
            this.selectionGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox coffeeComboBox;
        private System.Windows.Forms.GroupBox selectionGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox syrupListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSelectedFlavorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAllFlavorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCoffeeFlavorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCoffeeFlavorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCoffeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countCoffeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printAllDocument;
        private System.Drawing.Printing.PrintDocument printSelectedDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

