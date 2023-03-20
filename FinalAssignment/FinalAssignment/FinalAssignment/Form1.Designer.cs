namespace FinalAssignment
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkedBtn = new System.Windows.Forms.RadioButton();
            this.mergeBtn = new System.Windows.Forms.RadioButton();
            this.linkBtn = new System.Windows.Forms.RadioButton();
            this.binarryBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Structures and Algorithms Final Assignment";
            // 
            // linkedBtn
            // 
            this.linkedBtn.AutoSize = true;
            this.linkedBtn.Location = new System.Drawing.Point(611, 104);
            this.linkedBtn.Name = "linkedBtn";
            this.linkedBtn.Size = new System.Drawing.Size(81, 19);
            this.linkedBtn.TabIndex = 1;
            this.linkedBtn.TabStop = true;
            this.linkedBtn.Text = "Linked List";
            this.linkedBtn.UseVisualStyleBackColor = true;
            // 
            // mergeBtn
            // 
            this.mergeBtn.AutoSize = true;
            this.mergeBtn.Location = new System.Drawing.Point(611, 167);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(85, 19);
            this.mergeBtn.TabIndex = 2;
            this.mergeBtn.TabStop = true;
            this.mergeBtn.Text = "Merge-Sort";
            this.mergeBtn.UseVisualStyleBackColor = true;
            // 
            // linkBtn
            // 
            this.linkBtn.AutoSize = true;
            this.linkBtn.Location = new System.Drawing.Point(611, 229);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(83, 19);
            this.linkBtn.TabIndex = 3;
            this.linkBtn.TabStop = true;
            this.linkBtn.Text = "Linked-List";
            this.linkBtn.UseVisualStyleBackColor = true;
            // 
            // binarryBtn
            // 
            this.binarryBtn.AutoSize = true;
            this.binarryBtn.Location = new System.Drawing.Point(611, 293);
            this.binarryBtn.Name = "binarryBtn";
            this.binarryBtn.Size = new System.Drawing.Size(120, 19);
            this.binarryBtn.TabIndex = 4;
            this.binarryBtn.TabStop = true;
            this.binarryBtn.Text = "Binary Search Tree";
            this.binarryBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 136);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 309);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 123);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(611, 382);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(114, 34);
            this.generateBtn.TabIndex = 10;
            this.generateBtn.Text = "Generate ";
            this.generateBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.binarryBtn);
            this.Controls.Add(this.linkBtn);
            this.Controls.Add(this.mergeBtn);
            this.Controls.Add(this.linkedBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton linkedBtn;
        private RadioButton mergeBtn;
        private RadioButton linkBtn;
        private RadioButton binarryBtn;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button generateBtn;
    }
}