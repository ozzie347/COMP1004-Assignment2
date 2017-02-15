namespace WindowsFormsAssignment2
{
    partial class AutoCenterForm
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
            this.additionalItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.computerNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.leatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.stereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.exteriorFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.customizedDetailingRadioButton = new System.Windows.Forms.RadioButton();
            this.pearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftSansSerifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicSansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basePriceTextBox = new System.Windows.Forms.TextBox();
            this.additionalOptionsTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.tradeInAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.amountDueTextBox = new System.Windows.Forms.TextBox();
            this.basePriceLabel = new System.Windows.Forms.Label();
            this.additionalOptionsLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tradeInAllowanceLabel = new System.Windows.Forms.Label();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.additionalItemsGroupBox.SuspendLayout();
            this.exteriorFinishGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // additionalItemsGroupBox
            // 
            this.additionalItemsGroupBox.Controls.Add(this.computerNavigationCheckBox);
            this.additionalItemsGroupBox.Controls.Add(this.leatherInteriorCheckBox);
            this.additionalItemsGroupBox.Controls.Add(this.stereoSystemCheckBox);
            this.additionalItemsGroupBox.Location = new System.Drawing.Point(270, 69);
            this.additionalItemsGroupBox.Name = "additionalItemsGroupBox";
            this.additionalItemsGroupBox.Size = new System.Drawing.Size(200, 150);
            this.additionalItemsGroupBox.TabIndex = 0;
            this.additionalItemsGroupBox.TabStop = false;
            this.additionalItemsGroupBox.Text = "Additional Items";
            // 
            // computerNavigationCheckBox
            // 
            this.computerNavigationCheckBox.AutoSize = true;
            this.computerNavigationCheckBox.Location = new System.Drawing.Point(7, 110);
            this.computerNavigationCheckBox.Name = "computerNavigationCheckBox";
            this.computerNavigationCheckBox.Size = new System.Drawing.Size(162, 21);
            this.computerNavigationCheckBox.TabIndex = 2;
            this.computerNavigationCheckBox.Text = "Computer Navigation";
            this.computerNavigationCheckBox.UseVisualStyleBackColor = true;
            this.computerNavigationCheckBox.CheckedChanged += new System.EventHandler(this.computerNavigationCheckBox_CheckedChanged);
            // 
            // leatherInteriorCheckBox
            // 
            this.leatherInteriorCheckBox.AutoSize = true;
            this.leatherInteriorCheckBox.Location = new System.Drawing.Point(7, 72);
            this.leatherInteriorCheckBox.Name = "leatherInteriorCheckBox";
            this.leatherInteriorCheckBox.Size = new System.Drawing.Size(127, 21);
            this.leatherInteriorCheckBox.TabIndex = 1;
            this.leatherInteriorCheckBox.Text = "Leather Interior";
            this.leatherInteriorCheckBox.UseVisualStyleBackColor = true;
            this.leatherInteriorCheckBox.CheckedChanged += new System.EventHandler(this.leatherInteriorCheckBox_CheckedChanged);
            // 
            // stereoSystemCheckBox
            // 
            this.stereoSystemCheckBox.AutoSize = true;
            this.stereoSystemCheckBox.Location = new System.Drawing.Point(6, 34);
            this.stereoSystemCheckBox.Name = "stereoSystemCheckBox";
            this.stereoSystemCheckBox.Size = new System.Drawing.Size(122, 21);
            this.stereoSystemCheckBox.TabIndex = 0;
            this.stereoSystemCheckBox.Text = "Stereo System";
            this.stereoSystemCheckBox.UseVisualStyleBackColor = true;
            this.stereoSystemCheckBox.CheckedChanged += new System.EventHandler(this.stereoSystemCheckBox_CheckedChanged);
            // 
            // exteriorFinishGroupBox
            // 
            this.exteriorFinishGroupBox.Controls.Add(this.customizedDetailingRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.pearlizedRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.standardRadioButton);
            this.exteriorFinishGroupBox.Location = new System.Drawing.Point(270, 225);
            this.exteriorFinishGroupBox.Name = "exteriorFinishGroupBox";
            this.exteriorFinishGroupBox.Size = new System.Drawing.Size(200, 150);
            this.exteriorFinishGroupBox.TabIndex = 1;
            this.exteriorFinishGroupBox.TabStop = false;
            this.exteriorFinishGroupBox.Text = "Exterior Finish";
            // 
            // customizedDetailingRadioButton
            // 
            this.customizedDetailingRadioButton.AutoSize = true;
            this.customizedDetailingRadioButton.Location = new System.Drawing.Point(7, 115);
            this.customizedDetailingRadioButton.Name = "customizedDetailingRadioButton";
            this.customizedDetailingRadioButton.Size = new System.Drawing.Size(161, 21);
            this.customizedDetailingRadioButton.TabIndex = 2;
            this.customizedDetailingRadioButton.TabStop = true;
            this.customizedDetailingRadioButton.Text = "Customized Detailing";
            this.customizedDetailingRadioButton.UseVisualStyleBackColor = true;
            this.customizedDetailingRadioButton.CheckedChanged += new System.EventHandler(this.customizedDetailingRadioButton_CheckedChanged);
            // 
            // pearlizedRadioButton
            // 
            this.pearlizedRadioButton.AutoSize = true;
            this.pearlizedRadioButton.Location = new System.Drawing.Point(7, 72);
            this.pearlizedRadioButton.Name = "pearlizedRadioButton";
            this.pearlizedRadioButton.Size = new System.Drawing.Size(88, 21);
            this.pearlizedRadioButton.TabIndex = 1;
            this.pearlizedRadioButton.TabStop = true;
            this.pearlizedRadioButton.Text = "Pearlized";
            this.pearlizedRadioButton.UseVisualStyleBackColor = true;
            this.pearlizedRadioButton.CheckedChanged += new System.EventHandler(this.pearlizedRadioButton_CheckedChanged);
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Checked = true;
            this.standardRadioButton.Location = new System.Drawing.Point(7, 32);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(87, 21);
            this.standardRadioButton.TabIndex = 0;
            this.standardRadioButton.TabStop = true;
            this.standardRadioButton.Text = "Standard";
            this.standardRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 401);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 40);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(206, 401);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 40);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(395, 401);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(482, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "F̲ile";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Ex̲it";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "E̲dit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.calculateToolStripMenuItem.Text = "C̲alculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.clearToolStripMenuItem.Text = "Cl̲ear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microsoftSansSerifToolStripMenuItem,
            this.timesNewRomanToolStripMenuItem,
            this.comicSansToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.fontToolStripMenuItem.Text = "F̲ont";
            // 
            // microsoftSansSerifToolStripMenuItem
            // 
            this.microsoftSansSerifToolStripMenuItem.Name = "microsoftSansSerifToolStripMenuItem";
            this.microsoftSansSerifToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.microsoftSansSerifToolStripMenuItem.Text = "Microsoft Sans Serif";
            this.microsoftSansSerifToolStripMenuItem.Click += new System.EventHandler(this.microsoftSansSerifToolStripMenuItem_Click);
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click);
            // 
            // comicSansToolStripMenuItem
            // 
            this.comicSansToolStripMenuItem.Name = "comicSansToolStripMenuItem";
            this.comicSansToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.comicSansToolStripMenuItem.Text = "Comic Sans";
            this.comicSansToolStripMenuItem.Click += new System.EventHandler(this.comicSansToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.redToolStripMenuItem});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.colourToolStripMenuItem.Text = "Co̲lour";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "H̲elp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "A̲bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // basePriceTextBox
            // 
            this.basePriceTextBox.Location = new System.Drawing.Point(164, 69);
            this.basePriceTextBox.Name = "basePriceTextBox";
            this.basePriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.basePriceTextBox.TabIndex = 7;
            this.basePriceTextBox.Leave += new System.EventHandler(this.basePriceTextBox_Leave);
            // 
            // additionalOptionsTextBox
            // 
            this.additionalOptionsTextBox.Location = new System.Drawing.Point(164, 103);
            this.additionalOptionsTextBox.Name = "additionalOptionsTextBox";
            this.additionalOptionsTextBox.ReadOnly = true;
            this.additionalOptionsTextBox.Size = new System.Drawing.Size(100, 22);
            this.additionalOptionsTextBox.TabIndex = 8;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(164, 141);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.subTotalTextBox.TabIndex = 9;
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Location = new System.Drawing.Point(164, 179);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.ReadOnly = true;
            this.salesTaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.salesTaxTextBox.TabIndex = 10;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(164, 216);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalTextBox.TabIndex = 11;
            // 
            // tradeInAllowanceTextBox
            // 
            this.tradeInAllowanceTextBox.Location = new System.Drawing.Point(164, 256);
            this.tradeInAllowanceTextBox.Name = "tradeInAllowanceTextBox";
            this.tradeInAllowanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.tradeInAllowanceTextBox.TabIndex = 12;
            this.tradeInAllowanceTextBox.Text = "0";
            this.tradeInAllowanceTextBox.Leave += new System.EventHandler(this.tradeInAllowanceTextBox_Leave);
            // 
            // amountDueTextBox
            // 
            this.amountDueTextBox.Location = new System.Drawing.Point(164, 296);
            this.amountDueTextBox.Name = "amountDueTextBox";
            this.amountDueTextBox.ReadOnly = true;
            this.amountDueTextBox.Size = new System.Drawing.Size(100, 22);
            this.amountDueTextBox.TabIndex = 13;
            // 
            // basePriceLabel
            // 
            this.basePriceLabel.AutoSize = true;
            this.basePriceLabel.Location = new System.Drawing.Point(78, 72);
            this.basePriceLabel.Name = "basePriceLabel";
            this.basePriceLabel.Size = new System.Drawing.Size(80, 17);
            this.basePriceLabel.TabIndex = 14;
            this.basePriceLabel.Text = "Base Price:";
            // 
            // additionalOptionsLabel
            // 
            this.additionalOptionsLabel.AutoSize = true;
            this.additionalOptionsLabel.Location = new System.Drawing.Point(31, 106);
            this.additionalOptionsLabel.Name = "additionalOptionsLabel";
            this.additionalOptionsLabel.Size = new System.Drawing.Size(127, 17);
            this.additionalOptionsLabel.TabIndex = 15;
            this.additionalOptionsLabel.Text = "Additional Options:";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(89, 142);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(69, 17);
            this.subTotalLabel.TabIndex = 16;
            this.subTotalLabel.Text = "SubTotal:";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(46, 182);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(112, 17);
            this.salesTaxLabel.TabIndex = 17;
            this.salesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(114, 219);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 17);
            this.totalLabel.TabIndex = 18;
            this.totalLabel.Text = "Total:";
            // 
            // tradeInAllowanceLabel
            // 
            this.tradeInAllowanceLabel.AutoSize = true;
            this.tradeInAllowanceLabel.Location = new System.Drawing.Point(25, 259);
            this.tradeInAllowanceLabel.Name = "tradeInAllowanceLabel";
            this.tradeInAllowanceLabel.Size = new System.Drawing.Size(133, 17);
            this.tradeInAllowanceLabel.TabIndex = 19;
            this.tradeInAllowanceLabel.Text = "Trade-in Allowance:";
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Location = new System.Drawing.Point(68, 299);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(90, 17);
            this.amountDueLabel.TabIndex = 20;
            this.amountDueLabel.Text = "Amount Due:";
            // 
            // AutoCenterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.amountDueLabel);
            this.Controls.Add(this.tradeInAllowanceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.additionalOptionsLabel);
            this.Controls.Add(this.basePriceLabel);
            this.Controls.Add(this.amountDueTextBox);
            this.Controls.Add(this.tradeInAllowanceTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.salesTaxTextBox);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(this.additionalOptionsTextBox);
            this.Controls.Add(this.basePriceTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exteriorFinishGroupBox);
            this.Controls.Add(this.additionalItemsGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AutoCenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Center";
            this.additionalItemsGroupBox.ResumeLayout(false);
            this.additionalItemsGroupBox.PerformLayout();
            this.exteriorFinishGroupBox.ResumeLayout(false);
            this.exteriorFinishGroupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox additionalItemsGroupBox;
        private System.Windows.Forms.CheckBox computerNavigationCheckBox;
        private System.Windows.Forms.CheckBox leatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox stereoSystemCheckBox;
        private System.Windows.Forms.GroupBox exteriorFinishGroupBox;
        private System.Windows.Forms.RadioButton customizedDetailingRadioButton;
        private System.Windows.Forms.RadioButton pearlizedRadioButton;
        private System.Windows.Forms.RadioButton standardRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox basePriceTextBox;
        private System.Windows.Forms.TextBox additionalOptionsTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox tradeInAllowanceTextBox;
        private System.Windows.Forms.TextBox amountDueTextBox;
        private System.Windows.Forms.Label basePriceLabel;
        private System.Windows.Forms.Label additionalOptionsLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tradeInAllowanceLabel;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftSansSerifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comicSansToolStripMenuItem;
    }
}

