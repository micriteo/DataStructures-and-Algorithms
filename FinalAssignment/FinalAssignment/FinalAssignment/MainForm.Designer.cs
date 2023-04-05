namespace FinalAssignment
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.mergeSortCheck = new System.Windows.Forms.RadioButton();
            this.quickSortCheck = new System.Windows.Forms.RadioButton();
            this.jumpSearchCheck = new System.Windows.Forms.RadioButton();
            this.binarrySearchCheck = new System.Windows.Forms.RadioButton();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelExecutionTime = new System.Windows.Forms.Label();
            this.labelSelectSortAlgr = new System.Windows.Forms.Label();
            this.labelSelectSearchAlgr = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxCollectionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBTInOrder = new System.Windows.Forms.Button();
            this.buttonBTPreOrder = new System.Windows.Forms.Button();
            this.buttonBTPostOrder = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.toolTipInputTextBox = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(40, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(497, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Data Structures and Algorithms Final Assignment";
            // 
            // mergeSortCheck
            // 
            this.mergeSortCheck.AutoSize = true;
            this.mergeSortCheck.Enabled = false;
            this.mergeSortCheck.Location = new System.Drawing.Point(433, 86);
            this.mergeSortCheck.Name = "mergeSortCheck";
            this.mergeSortCheck.Size = new System.Drawing.Size(83, 19);
            this.mergeSortCheck.TabIndex = 1;
            this.mergeSortCheck.TabStop = true;
            this.mergeSortCheck.Text = "Merge Sort";
            this.mergeSortCheck.UseVisualStyleBackColor = true;
            // 
            // quickSortCheck
            // 
            this.quickSortCheck.AutoSize = true;
            this.quickSortCheck.Enabled = false;
            this.quickSortCheck.Location = new System.Drawing.Point(433, 108);
            this.quickSortCheck.Name = "quickSortCheck";
            this.quickSortCheck.Size = new System.Drawing.Size(80, 19);
            this.quickSortCheck.TabIndex = 2;
            this.quickSortCheck.TabStop = true;
            this.quickSortCheck.Text = "Quick Sort";
            this.quickSortCheck.UseVisualStyleBackColor = true;
            // 
            // jumpSearchCheck
            // 
            this.jumpSearchCheck.AutoSize = true;
            this.jumpSearchCheck.Enabled = false;
            this.jumpSearchCheck.Location = new System.Drawing.Point(433, 155);
            this.jumpSearchCheck.Name = "jumpSearchCheck";
            this.jumpSearchCheck.Size = new System.Drawing.Size(93, 19);
            this.jumpSearchCheck.TabIndex = 3;
            this.jumpSearchCheck.TabStop = true;
            this.jumpSearchCheck.Text = "Jump-search";
            this.jumpSearchCheck.UseVisualStyleBackColor = true;
            // 
            // binarrySearchCheck
            // 
            this.binarrySearchCheck.AutoSize = true;
            this.binarrySearchCheck.Enabled = false;
            this.binarrySearchCheck.Location = new System.Drawing.Point(433, 178);
            this.binarrySearchCheck.Name = "binarrySearchCheck";
            this.binarrySearchCheck.Size = new System.Drawing.Size(120, 19);
            this.binarrySearchCheck.TabIndex = 4;
            this.binarrySearchCheck.TabStop = true;
            this.binarrySearchCheck.Text = "Binary Search Tree";
            this.binarrySearchCheck.UseVisualStyleBackColor = true;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(23, 68);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(35, 15);
            this.labelInput.TabIndex = 5;
            this.labelInput.Text = "Input";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(22, 111);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(45, 15);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Output";
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.Location = new System.Drawing.Point(91, 67);
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.Size = new System.Drawing.Size(277, 23);
            this.textBoxInputText.TabIndex = 7;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonGenerate.Location = new System.Drawing.Point(439, 226);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGenerate.Size = new System.Drawing.Size(114, 34);
            this.buttonGenerate.TabIndex = 10;
            this.buttonGenerate.Text = "Generate ";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click_2);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(370, 67);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(53, 18);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // labelExecutionTime
            // 
            this.labelExecutionTime.AutoSize = true;
            this.labelExecutionTime.Location = new System.Drawing.Point(91, 273);
            this.labelExecutionTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelExecutionTime.Name = "labelExecutionTime";
            this.labelExecutionTime.Size = new System.Drawing.Size(91, 15);
            this.labelExecutionTime.TabIndex = 12;
            this.labelExecutionTime.Text = "Execution Time:";
            // 
            // labelSelectSortAlgr
            // 
            this.labelSelectSortAlgr.AutoSize = true;
            this.labelSelectSortAlgr.Location = new System.Drawing.Point(433, 64);
            this.labelSelectSortAlgr.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSelectSortAlgr.Name = "labelSelectSortAlgr";
            this.labelSelectSortAlgr.Size = new System.Drawing.Size(128, 15);
            this.labelSelectSortAlgr.TabIndex = 13;
            this.labelSelectSortAlgr.Text = "Select a sort algorthim:";
            // 
            // labelSelectSearchAlgr
            // 
            this.labelSelectSearchAlgr.AutoSize = true;
            this.labelSelectSearchAlgr.Location = new System.Drawing.Point(433, 138);
            this.labelSelectSearchAlgr.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSelectSearchAlgr.Name = "labelSelectSearchAlgr";
            this.labelSelectSearchAlgr.Size = new System.Drawing.Size(142, 15);
            this.labelSelectSearchAlgr.TabIndex = 14;
            this.labelSelectSearchAlgr.Text = "Select a search algorthim:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            // 
            // comboBoxCollectionType
            // 
            this.comboBoxCollectionType.FormattingEnabled = true;
            this.comboBoxCollectionType.Items.AddRange(new object[] {
            "LinkedList",
            "BinaryTree",
            "ArrayList"});
            this.comboBoxCollectionType.Location = new System.Drawing.Point(91, 89);
            this.comboBoxCollectionType.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxCollectionType.Name = "comboBoxCollectionType";
            this.comboBoxCollectionType.Size = new System.Drawing.Size(334, 23);
            this.comboBoxCollectionType.TabIndex = 16;
            this.comboBoxCollectionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCollectionType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Collection";
            // 
            // buttonBTInOrder
            // 
            this.buttonBTInOrder.Location = new System.Drawing.Point(91, 238);
            this.buttonBTInOrder.Name = "buttonBTInOrder";
            this.buttonBTInOrder.Size = new System.Drawing.Size(110, 23);
            this.buttonBTInOrder.TabIndex = 18;
            this.buttonBTInOrder.Text = "In Order";
            this.buttonBTInOrder.UseVisualStyleBackColor = true;
            this.buttonBTInOrder.Visible = false;
            // 
            // buttonBTPreOrder
            // 
            this.buttonBTPreOrder.Location = new System.Drawing.Point(207, 238);
            this.buttonBTPreOrder.Name = "buttonBTPreOrder";
            this.buttonBTPreOrder.Size = new System.Drawing.Size(108, 22);
            this.buttonBTPreOrder.TabIndex = 19;
            this.buttonBTPreOrder.Text = "Pre Order";
            this.buttonBTPreOrder.UseVisualStyleBackColor = true;
            this.buttonBTPreOrder.Visible = false;
            // 
            // buttonBTPostOrder
            // 
            this.buttonBTPostOrder.Location = new System.Drawing.Point(320, 238);
            this.buttonBTPostOrder.Name = "buttonBTPostOrder";
            this.buttonBTPostOrder.Size = new System.Drawing.Size(103, 22);
            this.buttonBTPostOrder.TabIndex = 20;
            this.buttonBTPostOrder.Text = "Post Order";
            this.buttonBTPostOrder.UseVisualStyleBackColor = true;
            this.buttonBTPostOrder.Visible = false;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(91, 111);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(334, 125);
            this.textBoxOutput.TabIndex = 21;
            this.textBoxOutput.Text = "";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(439, 268);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(126, 25);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 322);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonBTPostOrder);
            this.Controls.Add(this.buttonBTPreOrder);
            this.Controls.Add(this.buttonBTInOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCollectionType);
            this.Controls.Add(this.labelSelectSearchAlgr);
            this.Controls.Add(this.labelSelectSortAlgr);
            this.Controls.Add(this.labelExecutionTime);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxInputText);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.binarrySearchCheck);
            this.Controls.Add(this.jumpSearchCheck);
            this.Controls.Add(this.quickSortCheck);
            this.Controls.Add(this.mergeSortCheck);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(631, 361);
            this.MinimumSize = new System.Drawing.Size(631, 361);
            this.Name = "MainForm";
            this.Text = "Data Structures Final Assignment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private RadioButton mergeSortCheck;
        private RadioButton quickSortCheck;
        private RadioButton jumpSearchCheck;
        private RadioButton binarrySearchCheck;
        private Label labelInput;
        private Label labelOutput;
        private TextBox textBoxInputText;
        private Button buttonGenerate;
        private Button buttonAdd;
        private Label labelExecutionTime;
        private Label labelSelectSortAlgr;
        private Label labelSelectSearchAlgr;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ComboBox comboBoxCollectionType;
        private Label label1;
        private Button buttonBTInOrder;
        private Button buttonBTPreOrder;
        private Button buttonBTPostOrder;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem cSVToolStripMenuItem;
        private RichTextBox textBoxOutput;
        private Button buttonClear;
        private ToolTip toolTipInputTextBox;
    }
}