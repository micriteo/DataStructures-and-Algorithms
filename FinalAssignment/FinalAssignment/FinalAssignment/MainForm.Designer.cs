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
            quickSortCheck = new RadioButton();
            insertSortCheck = new RadioButton();
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
            richTextBoxOutput = new RichTextBox();
            buttonClear = new Button();
            toolTipInputTextBox = new ToolTip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(86, 59);
            labelTitle.Margin = new Padding(6, 0, 6, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1142, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Data Structures and Algorithms Final Assignment";
            // 
            // quickSortCheck
            // 
            quickSortCheck.AutoSize = true;
            quickSortCheck.Enabled = false;
            quickSortCheck.Location = new Point(928, 212);
            quickSortCheck.Margin = new Padding(6, 7, 6, 7);
            quickSortCheck.Name = "quickSortCheck";
            quickSortCheck.Size = new Size(170, 41);
            quickSortCheck.TabIndex = 1;
            quickSortCheck.TabStop = true;
            quickSortCheck.Text = "Quick Sort";
            quickSortCheck.UseVisualStyleBackColor = true;
            // 
            // insertSortCheck
            // 
            insertSortCheck.AutoSize = true;
            insertSortCheck.Enabled = false;
            insertSortCheck.Location = new Point(928, 266);
            insertSortCheck.Margin = new Padding(6, 7, 6, 7);
            insertSortCheck.Name = "insertSortCheck";
            insertSortCheck.Size = new Size(152, 41);
            insertSortCheck.TabIndex = 2;
            insertSortCheck.TabStop = true;
            insertSortCheck.Text = "Add Sort";
            insertSortCheck.UseVisualStyleBackColor = true;
            // 
            // jumpSearchCheck
            // 
            jumpSearchCheck.AutoSize = true;
            jumpSearchCheck.Enabled = false;
            jumpSearchCheck.Location = new Point(928, 382);
            jumpSearchCheck.Margin = new Padding(6, 7, 6, 7);
            jumpSearchCheck.Name = "jumpSearchCheck";
            jumpSearchCheck.Size = new Size(198, 41);
            jumpSearchCheck.TabIndex = 3;
            jumpSearchCheck.TabStop = true;
            jumpSearchCheck.Text = "Jump-search";
            jumpSearchCheck.UseVisualStyleBackColor = true;
            // 
            // binarrySearchCheck
            // 
            binarrySearchCheck.AutoSize = true;
            binarrySearchCheck.Enabled = false;
            binarrySearchCheck.Location = new Point(928, 439);
            binarrySearchCheck.Margin = new Padding(6, 7, 6, 7);
            binarrySearchCheck.Name = "binarrySearchCheck";
            binarrySearchCheck.Size = new Size(262, 41);
            binarrySearchCheck.TabIndex = 4;
            binarrySearchCheck.TabStop = true;
            binarrySearchCheck.Text = "Binary Search Tree";
            binarrySearchCheck.UseVisualStyleBackColor = true;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(49, 168);
            labelInput.Margin = new Padding(6, 0, 6, 0);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(79, 37);
            labelInput.TabIndex = 5;
            labelInput.Text = "Input";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(47, 274);
            labelOutput.Margin = new Padding(6, 0, 6, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(101, 37);
            labelOutput.TabIndex = 6;
            labelOutput.Text = "Output";
            // 
            // textBoxInputText
            // 
            textBoxInputText.Location = new Point(196, 165);
            textBoxInputText.Margin = new Padding(6, 7, 6, 7);
            textBoxInputText.Name = "textBoxInputText";
            textBoxInputText.Size = new Size(589, 43);
            textBoxInputText.TabIndex = 7;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(957, 587);
            buttonGenerate.Margin = new Padding(13, 17, 13, 17);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(271, 123);
            buttonGenerate.TabIndex = 10;
            buttonGenerate.Text = "Generate ";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(793, 165);
            buttonInsert.Margin = new Padding(2);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(113, 45);
            buttonInsert.TabIndex = 11;
            buttonInsert.Text = "Add";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonAdd_Click;
            // 
            // labelExecutionTime
            // 
            labelExecutionTime.AutoSize = true;
            labelExecutionTime.Location = new Point(195, 673);
            labelExecutionTime.Margin = new Padding(2, 0, 2, 0);
            labelExecutionTime.Name = "labelExecutionTime";
            labelExecutionTime.Size = new Size(202, 37);
            labelExecutionTime.TabIndex = 12;
            labelExecutionTime.Text = "Execution Time:";
            // 
            // labelSelectSortAlgr
            // 
            labelSelectSortAlgr.AutoSize = true;
            labelSelectSortAlgr.Location = new Point(928, 158);
            labelSelectSortAlgr.Margin = new Padding(2, 0, 2, 0);
            labelSelectSortAlgr.Name = "labelSelectSortAlgr";
            labelSelectSortAlgr.Size = new Size(289, 37);
            labelSelectSortAlgr.TabIndex = 13;
            labelSelectSortAlgr.Text = "Select a sort algorthim:";
            // 
            // labelSelectSearchAlgr
            // 
            labelSelectSearchAlgr.AutoSize = true;
            labelSelectSearchAlgr.Location = new Point(928, 340);
            labelSelectSearchAlgr.Margin = new Padding(2, 0, 2, 0);
            labelSelectSearchAlgr.Name = "labelSelectSearchAlgr";
            labelSelectSearchAlgr.Size = new Size(319, 37);
            labelSelectSearchAlgr.TabIndex = 14;
            labelSelectSearchAlgr.Text = "Select a search algorthim:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, importToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1306, 45);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(85, 41);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cSVToolStripMenuItem });
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(119, 41);
            importToolStripMenuItem.Text = "Import";
            // 
            // cSVToolStripMenuItem
            // 
            cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            cSVToolStripMenuItem.Size = new Size(215, 48);
            cSVToolStripMenuItem.Text = "CSV";
            cSVToolStripMenuItem.Click += cSVToolStripMenuItem_Click;
            // 
            // comboBoxCollectionType
            // 
            comboBoxCollectionType.FormattingEnabled = true;
            comboBoxCollectionType.Items.AddRange(new object[] { "LinkedList", "BinaryTree", "ArrayList" });
            comboBoxCollectionType.Location = new Point(195, 220);
            comboBoxCollectionType.Margin = new Padding(2);
            comboBoxCollectionType.Name = "comboBoxCollectionType";
            comboBoxCollectionType.Size = new Size(711, 45);
            comboBoxCollectionType.TabIndex = 16;
            comboBoxCollectionType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 224);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 17;
            label1.Text = "Collection";
            // 
            // buttonBTInOrder
            // 
            buttonBTInOrder.Location = new Point(195, 586);
            buttonBTInOrder.Margin = new Padding(6, 7, 6, 7);
            buttonBTInOrder.Name = "buttonBTInOrder";
            buttonBTInOrder.Size = new Size(236, 56);
            buttonBTInOrder.TabIndex = 18;
            buttonBTInOrder.Text = "In Order";
            buttonBTInOrder.UseVisualStyleBackColor = true;
            buttonBTInOrder.Visible = false;
            buttonBTInOrder.Click += buttonBTInOrder_Click;
            // 
            // buttonBTPreOrder
            // 
            buttonBTPreOrder.Location = new Point(443, 587);
            buttonBTPreOrder.Margin = new Padding(6, 7, 6, 7);
            buttonBTPreOrder.Name = "buttonBTPreOrder";
            buttonBTPreOrder.Size = new Size(231, 54);
            buttonBTPreOrder.TabIndex = 19;
            buttonBTPreOrder.Text = "Pre Order";
            buttonBTPreOrder.UseVisualStyleBackColor = true;
            buttonBTPreOrder.Visible = false;
            buttonBTPreOrder.Click += buttonBTPreOrder_Click;
            // 
            // buttonBTPostOrder
            // 
            buttonBTPostOrder.Location = new Point(686, 588);
            buttonBTPostOrder.Margin = new Padding(6, 7, 6, 7);
            buttonBTPostOrder.Name = "buttonBTPostOrder";
            buttonBTPostOrder.Size = new Size(220, 54);
            buttonBTPostOrder.TabIndex = 20;
            buttonBTPostOrder.Text = "Post Order";
            buttonBTPostOrder.UseVisualStyleBackColor = true;
            buttonBTPostOrder.Visible = false;
            buttonBTPostOrder.Click += buttonBTPostOrder_Click;
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.Location = new Point(195, 274);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.ReadOnly = true;
            richTextBoxOutput.Size = new Size(711, 303);
            richTextBoxOutput.TabIndex = 21;
            richTextBoxOutput.Text = "";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(957, 515);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(271, 62);
            buttonClear.TabIndex = 22;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 754);
            Controls.Add(buttonClear);
            Controls.Add(richTextBoxOutput);
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
            Controls.Add(insertSortCheck);
            Controls.Add(quickSortCheck);
            Controls.Add(labelTitle);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(13, 17, 13, 17);
            MaximizeBox = false;
            MaximumSize = new Size(1334, 833);
            MinimumSize = new Size(1334, 833);
            Name = "MainForm";
            Text = "Data Structures Final Assignment";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private RadioButton quickSortCheck;
        private RadioButton insertSortCheck;
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
        private RichTextBox richTextBoxOutput;
        private Button buttonClear;
        private ToolTip toolTipInputTextBox;
    }
}