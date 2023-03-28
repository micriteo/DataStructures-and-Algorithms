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
            components = new System.ComponentModel.Container();
            labelTitle = new Label();
            mergeSortCheck = new RadioButton();
            quickSortCheck = new RadioButton();
            jumpSearchCheck = new RadioButton();
            binarrySearchCheck = new RadioButton();
            labelInput = new Label();
            labelOutput = new Label();
            textBoxInputText = new TextBox();
            buttonGenerate = new Button();
            buttonInsert = new Button();
            labelExecutionTime = new Label();
            labelSelectSortAlgr = new Label();
            labelSelectSearchAlgr = new Label();
            menuStrip1 = new MenuStrip();
            infoToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            cSVToolStripMenuItem = new ToolStripMenuItem();
            comboBoxCollectionType = new ComboBox();
            label1 = new Label();
            buttonBTInOrder = new Button();
            buttonBTPreOrder = new Button();
            buttonBTPostOrder = new Button();
            textBoxOutput = new RichTextBox();
            buttonClear = new Button();
            toolTipInputTextBox = new ToolTip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(40, 24);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(497, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Data Structures and Algorithms Final Assignment";
            // 
            // mergeSortCheck
            // 
            mergeSortCheck.AutoSize = true;
            mergeSortCheck.Enabled = false;
            mergeSortCheck.Location = new Point(433, 86);
            mergeSortCheck.Name = "mergeSortCheck";
            mergeSortCheck.Size = new Size(83, 19);
            mergeSortCheck.TabIndex = 1;
            mergeSortCheck.TabStop = true;
            mergeSortCheck.Text = "Merge Sort";
            mergeSortCheck.UseVisualStyleBackColor = true;
            // 
            // quickSortCheck
            // 
            quickSortCheck.AutoSize = true;
            quickSortCheck.Enabled = false;
            quickSortCheck.Location = new Point(433, 108);
            quickSortCheck.Name = "quickSortCheck";
            quickSortCheck.Size = new Size(80, 19);
            quickSortCheck.TabIndex = 2;
            quickSortCheck.TabStop = true;
            quickSortCheck.Text = "Quick Sort";
            quickSortCheck.UseVisualStyleBackColor = true;
            // 
            // jumpSearchCheck
            // 
            jumpSearchCheck.AutoSize = true;
            jumpSearchCheck.Enabled = false;
            jumpSearchCheck.Location = new Point(433, 155);
            jumpSearchCheck.Name = "jumpSearchCheck";
            jumpSearchCheck.Size = new Size(93, 19);
            jumpSearchCheck.TabIndex = 3;
            jumpSearchCheck.TabStop = true;
            jumpSearchCheck.Text = "Jump-search";
            jumpSearchCheck.UseVisualStyleBackColor = true;
            // 
            // binarrySearchCheck
            // 
            binarrySearchCheck.AutoSize = true;
            binarrySearchCheck.Enabled = false;
            binarrySearchCheck.Location = new Point(433, 178);
            binarrySearchCheck.Name = "binarrySearchCheck";
            binarrySearchCheck.Size = new Size(120, 19);
            binarrySearchCheck.TabIndex = 4;
            binarrySearchCheck.TabStop = true;
            binarrySearchCheck.Text = "Binary Search Tree";
            binarrySearchCheck.UseVisualStyleBackColor = true;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(23, 68);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(35, 15);
            labelInput.TabIndex = 5;
            labelInput.Text = "Input";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(22, 111);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(45, 15);
            labelOutput.TabIndex = 6;
            labelOutput.Text = "Output";
            // 
            // textBoxInputText
            // 
            textBoxInputText.Location = new Point(91, 67);
            textBoxInputText.Name = "textBoxInputText";
            textBoxInputText.Size = new Size(277, 23);
            textBoxInputText.TabIndex = 7;
            // 
            // buttonGenerate
            // 
            buttonGenerate.ImageAlign = ContentAlignment.BottomRight;
            buttonGenerate.Location = new Point(439, 226);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.RightToLeft = RightToLeft.No;
            buttonGenerate.Size = new Size(114, 34);
            buttonGenerate.TabIndex = 10;
            buttonGenerate.Text = "Generate ";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click_1;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(370, 67);
            buttonInsert.Margin = new Padding(1);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(53, 18);
            buttonInsert.TabIndex = 11;
            buttonInsert.Text = "Add";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonAdd_Click;
            // 
            // labelExecutionTime
            // 
            labelExecutionTime.AutoSize = true;
            labelExecutionTime.Location = new Point(91, 273);
            labelExecutionTime.Margin = new Padding(1, 0, 1, 0);
            labelExecutionTime.Name = "labelExecutionTime";
            labelExecutionTime.Size = new Size(91, 15);
            labelExecutionTime.TabIndex = 12;
            labelExecutionTime.Text = "Execution Time:";
            // 
            // labelSelectSortAlgr
            // 
            labelSelectSortAlgr.AutoSize = true;
            labelSelectSortAlgr.Location = new Point(433, 64);
            labelSelectSortAlgr.Margin = new Padding(1, 0, 1, 0);
            labelSelectSortAlgr.Name = "labelSelectSortAlgr";
            labelSelectSortAlgr.Size = new Size(128, 15);
            labelSelectSortAlgr.TabIndex = 13;
            labelSelectSortAlgr.Text = "Select a sort algorthim:";
            // 
            // labelSelectSearchAlgr
            // 
            labelSelectSearchAlgr.AutoSize = true;
            labelSelectSearchAlgr.Location = new Point(433, 138);
            labelSelectSearchAlgr.Margin = new Padding(1, 0, 1, 0);
            labelSelectSearchAlgr.Name = "labelSelectSearchAlgr";
            labelSelectSearchAlgr.Size = new Size(142, 15);
            labelSelectSearchAlgr.TabIndex = 14;
            labelSelectSearchAlgr.Text = "Select a search algorthim:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, importToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(1, 0, 0, 0);
            menuStrip1.Size = new Size(615, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 24);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cSVToolStripMenuItem });
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(55, 24);
            importToolStripMenuItem.Text = "Import";
            // 
            // cSVToolStripMenuItem
            // 
            cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            cSVToolStripMenuItem.Size = new Size(95, 22);
            cSVToolStripMenuItem.Text = "CSV";
            cSVToolStripMenuItem.Click += cSVToolStripMenuItem_Click;
            // 
            // comboBoxCollectionType
            // 
            comboBoxCollectionType.FormattingEnabled = true;
            comboBoxCollectionType.Items.AddRange(new object[] { "LinkedList", "BinaryTree", "ArrayList" });
            comboBoxCollectionType.Location = new Point(91, 89);
            comboBoxCollectionType.Margin = new Padding(1);
            comboBoxCollectionType.Name = "comboBoxCollectionType";
            comboBoxCollectionType.Size = new Size(334, 23);
            comboBoxCollectionType.TabIndex = 16;
            comboBoxCollectionType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 91);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 17;
            label1.Text = "Collection";
            // 
            // buttonBTInOrder
            // 
            buttonBTInOrder.Location = new Point(91, 238);
            buttonBTInOrder.Name = "buttonBTInOrder";
            buttonBTInOrder.Size = new Size(110, 23);
            buttonBTInOrder.TabIndex = 18;
            buttonBTInOrder.Text = "In Order";
            buttonBTInOrder.UseVisualStyleBackColor = true;
            buttonBTInOrder.Visible = false;
            buttonBTInOrder.Click += buttonBTInOrder_Click;
            // 
            // buttonBTPreOrder
            // 
            buttonBTPreOrder.Location = new Point(207, 238);
            buttonBTPreOrder.Name = "buttonBTPreOrder";
            buttonBTPreOrder.Size = new Size(108, 22);
            buttonBTPreOrder.TabIndex = 19;
            buttonBTPreOrder.Text = "Pre Order";
            buttonBTPreOrder.UseVisualStyleBackColor = true;
            buttonBTPreOrder.Visible = false;
            buttonBTPreOrder.Click += buttonBTPreOrder_Click;
            // 
            // buttonBTPostOrder
            // 
            buttonBTPostOrder.Location = new Point(320, 238);
            buttonBTPostOrder.Name = "buttonBTPostOrder";
            buttonBTPostOrder.Size = new Size(103, 22);
            buttonBTPostOrder.TabIndex = 20;
            buttonBTPostOrder.Text = "Post Order";
            buttonBTPostOrder.UseVisualStyleBackColor = true;
            buttonBTPostOrder.Visible = false;
            buttonBTPostOrder.Click += buttonBTPostOrder_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(91, 111);
            textBoxOutput.Margin = new Padding(1);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(334, 125);
            textBoxOutput.TabIndex = 21;
            textBoxOutput.Text = "";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(439, 268);
            buttonClear.Margin = new Padding(1);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(126, 25);
            buttonClear.TabIndex = 22;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 322);
            Controls.Add(buttonClear);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonBTPostOrder);
            Controls.Add(buttonBTPreOrder);
            Controls.Add(buttonBTInOrder);
            Controls.Add(label1);
            Controls.Add(comboBoxCollectionType);
            Controls.Add(labelSelectSearchAlgr);
            Controls.Add(labelSelectSortAlgr);
            Controls.Add(labelExecutionTime);
            Controls.Add(buttonInsert);
            Controls.Add(buttonGenerate);
            Controls.Add(textBoxInputText);
            Controls.Add(labelOutput);
            Controls.Add(labelInput);
            Controls.Add(binarrySearchCheck);
            Controls.Add(jumpSearchCheck);
            Controls.Add(quickSortCheck);
            Controls.Add(mergeSortCheck);
            Controls.Add(labelTitle);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MaximumSize = new Size(631, 361);
            MinimumSize = new Size(631, 361);
            Name = "MainForm";
            Text = "Data Structures Final Assignment";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button buttonInsert;
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