﻿namespace FinalAssignment
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
            jumpSearchBtn = new RadioButton();
            binarryBtn = new RadioButton();
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(85, 59);
            labelTitle.Margin = new Padding(6, 0, 6, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1142, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Data Structures and Algorithms Final Assignment";
            // 
            // quickSortCheck
            // 
            quickSortCheck.AutoSize = true;
            quickSortCheck.Location = new Point(927, 211);
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
            insertSortCheck.Location = new Point(927, 266);
            insertSortCheck.Margin = new Padding(6, 7, 6, 7);
            insertSortCheck.Name = "insertSortCheck";
            insertSortCheck.Size = new Size(168, 41);
            insertSortCheck.TabIndex = 2;
            insertSortCheck.TabStop = true;
            insertSortCheck.Text = "Insert Sort";
            insertSortCheck.UseVisualStyleBackColor = true;
            // 
            // jumpSearchBtn
            // 
            jumpSearchBtn.AutoSize = true;
            jumpSearchBtn.Location = new Point(927, 376);
            jumpSearchBtn.Margin = new Padding(6, 7, 6, 7);
            jumpSearchBtn.Name = "jumpSearchBtn";
            jumpSearchBtn.Size = new Size(198, 41);
            jumpSearchBtn.TabIndex = 3;
            jumpSearchBtn.TabStop = true;
            jumpSearchBtn.Text = "Jump-search";
            jumpSearchBtn.UseVisualStyleBackColor = true;
            // 
            // binarryBtn
            // 
            binarryBtn.AutoSize = true;
            binarryBtn.Location = new Point(927, 431);
            binarryBtn.Margin = new Padding(6, 7, 6, 7);
            binarryBtn.Name = "binarryBtn";
            binarryBtn.Size = new Size(262, 41);
            binarryBtn.TabIndex = 4;
            binarryBtn.TabStop = true;
            binarryBtn.Text = "Binary Search Tree";
            binarryBtn.UseVisualStyleBackColor = true;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(49, 167);
            labelInput.Margin = new Padding(6, 0, 6, 0);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(79, 37);
            labelInput.TabIndex = 5;
            labelInput.Text = "Input";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(48, 274);
            labelOutput.Margin = new Padding(6, 0, 6, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(101, 37);
            labelOutput.TabIndex = 6;
            labelOutput.Text = "Output";
            // 
            // textBoxInputText
            // 
            textBoxInputText.Location = new Point(195, 157);
            textBoxInputText.Margin = new Padding(6, 7, 6, 7);
            textBoxInputText.Multiline = true;
            textBoxInputText.Name = "textBoxInputText";
            textBoxInputText.Size = new Size(589, 52);
            textBoxInputText.TabIndex = 7;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(195, 274);
            textBoxOutput.Margin = new Padding(6, 7, 6, 7);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(711, 298);
            textBoxOutput.TabIndex = 8;
            // 
            // generateBtn
            // 
            generateBtn.Location = new Point(1002, 488);
            generateBtn.Margin = new Padding(6, 7, 6, 7);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(244, 84);
            generateBtn.TabIndex = 10;
            generateBtn.Text = "Generate ";
            generateBtn.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(793, 157);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(113, 52);
            buttonInsert.TabIndex = 11;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            // 
            // labelExecutionTime
            // 
            labelExecutionTime.AutoSize = true;
            labelExecutionTime.Location = new Point(195, 602);
            labelExecutionTime.Name = "labelExecutionTime";
            labelExecutionTime.Size = new Size(197, 37);
            labelExecutionTime.TabIndex = 12;
            labelExecutionTime.Text = "Execution time:";
            // 
            // labelSelectSortAlgr
            // 
            labelSelectSortAlgr.AutoSize = true;
            labelSelectSortAlgr.Location = new Point(927, 157);
            labelSelectSortAlgr.Name = "labelSelectSortAlgr";
            labelSelectSortAlgr.Size = new Size(289, 37);
            labelSelectSortAlgr.TabIndex = 13;
            labelSelectSortAlgr.Text = "Select a sort algorthim:";
            // 
            // labelSelectSearchAlgr
            // 
            labelSelectSearchAlgr.AutoSize = true;
            labelSelectSearchAlgr.Location = new Point(927, 332);
            labelSelectSearchAlgr.Name = "labelSelectSearchAlgr";
            labelSelectSearchAlgr.Size = new Size(319, 37);
            labelSelectSearchAlgr.TabIndex = 14;
            labelSelectSearchAlgr.Text = "Select a search algorthim:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1300, 45);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(85, 41);
            infoToolStripMenuItem.Text = "Info";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "LinkedList", "BinaryTree", "ArrayList" });
            comboBox1.Location = new Point(195, 219);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(711, 45);
            comboBox1.TabIndex = 16;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 681);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(labelSelectSearchAlgr);
            Controls.Add(labelSelectSortAlgr);
            Controls.Add(labelExecutionTime);
            Controls.Add(buttonInsert);
            Controls.Add(generateBtn);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxInputText);
            Controls.Add(labelOutput);
            Controls.Add(labelInput);
            Controls.Add(binarryBtn);
            Controls.Add(jumpSearchBtn);
            Controls.Add(insertSortCheck);
            Controls.Add(quickSortCheck);
            Controls.Add(labelTitle);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 7, 6, 7);
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
        private RadioButton jumpSearchBtn;
        private RadioButton binarryBtn;
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
        private ComboBox comboBox1;
        private Label label1;
    }
}