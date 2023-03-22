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
            labelTitle = new Label();
            quickSortCheck = new RadioButton();
            insertSortCheck = new RadioButton();
            jumpSearchCheck = new RadioButton();
            binarrySearchCheck = new RadioButton();
            labelInput = new Label();
            labelOutput = new Label();
            textBoxInputText = new TextBox();
            textBoxOutput = new TextBox();
            generateBtn = new Button();
            buttonInsert = new Button();
            labelExecutionTime = new Label();
            labelSelectSortAlgr = new Label();
            labelSelectSearchAlgr = new Label();
            menuStrip1 = new MenuStrip();
            infoToolStripMenuItem = new ToolStripMenuItem();
            comboBoxCollectionType = new ComboBox();
            label1 = new Label();
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
            // quickSortCheck
            // 
            quickSortCheck.AutoSize = true;
            quickSortCheck.Enabled = false;
            quickSortCheck.Location = new Point(433, 86);
            quickSortCheck.Name = "quickSortCheck";
            quickSortCheck.Size = new Size(80, 19);
            quickSortCheck.TabIndex = 1;
            quickSortCheck.TabStop = true;
            quickSortCheck.Text = "Quick Sort";
            quickSortCheck.UseVisualStyleBackColor = true;
            // 
            // insertSortCheck
            // 
            insertSortCheck.AutoSize = true;
            insertSortCheck.Enabled = false;
            insertSortCheck.Location = new Point(433, 108);
            insertSortCheck.Name = "insertSortCheck";
            insertSortCheck.Size = new Size(71, 19);
            insertSortCheck.TabIndex = 2;
            insertSortCheck.TabStop = true;
            insertSortCheck.Text = "Add Sort";
            insertSortCheck.UseVisualStyleBackColor = true;
            // 
            // jumpSearchCheck
            // 
            jumpSearchCheck.AutoSize = true;
            jumpSearchCheck.Enabled = false;
            jumpSearchCheck.Location = new Point(433, 152);
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
            binarrySearchCheck.Location = new Point(433, 175);
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
            textBoxInputText.Location = new Point(91, 64);
            textBoxInputText.Multiline = true;
            textBoxInputText.Name = "textBoxInputText";
            textBoxInputText.Size = new Size(277, 23);
            textBoxInputText.TabIndex = 7;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(91, 111);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(334, 123);
            textBoxOutput.TabIndex = 8;
            // 
            // generateBtn
            // 
            generateBtn.Location = new Point(454, 198);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(114, 34);
            generateBtn.TabIndex = 10;
            generateBtn.Text = "Generate ";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(370, 64);
            buttonInsert.Margin = new Padding(1);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(53, 21);
            buttonInsert.TabIndex = 11;
            buttonInsert.Text = "Add";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // labelExecutionTime
            // 
            labelExecutionTime.AutoSize = true;
            labelExecutionTime.Location = new Point(91, 244);
            labelExecutionTime.Margin = new Padding(1, 0, 1, 0);
            labelExecutionTime.Name = "labelExecutionTime";
            labelExecutionTime.Size = new Size(89, 15);
            labelExecutionTime.TabIndex = 12;
            labelExecutionTime.Text = "Execution time:";
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
            labelSelectSearchAlgr.Location = new Point(433, 135);
            labelSelectSearchAlgr.Margin = new Padding(1, 0, 1, 0);
            labelSelectSearchAlgr.Name = "labelSelectSearchAlgr";
            labelSelectSearchAlgr.Size = new Size(142, 15);
            labelSelectSearchAlgr.TabIndex = 14;
            labelSelectSearchAlgr.Text = "Select a search algorthim:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(607, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 22);
            infoToolStripMenuItem.Text = "Info";
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 276);
            Controls.Add(label1);
            Controls.Add(comboBoxCollectionType);
            Controls.Add(labelSelectSearchAlgr);
            Controls.Add(labelSelectSortAlgr);
            Controls.Add(labelExecutionTime);
            Controls.Add(buttonInsert);
            Controls.Add(generateBtn);
            Controls.Add(textBoxOutput);
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
        private TextBox textBoxOutput;
        private Button generateBtn;
        private Button buttonInsert;
        private Label labelExecutionTime;
        private Label labelSelectSortAlgr;
        private Label labelSelectSearchAlgr;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ComboBox comboBoxCollectionType;
        private Label label1;
    }
}