namespace Encryptor
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
            this.hashTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hashButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hashOutput = new System.Windows.Forms.RichTextBox();
            this.cleartextInput = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clearButton = new System.Windows.Forms.Button();
            this.hashTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hashTab
            // 
            this.hashTab.Controls.Add(this.tabPage1);
            this.hashTab.Controls.Add(this.tabPage2);
            this.hashTab.Controls.Add(this.tabPage3);
            this.hashTab.Location = new System.Drawing.Point(8, 8);
            this.hashTab.Name = "hashTab";
            this.hashTab.SelectedIndex = 0;
            this.hashTab.Size = new System.Drawing.Size(832, 592);
            this.hashTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clearButton);
            this.tabPage1.Controls.Add(this.hashButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.hashOutput);
            this.tabPage1.Controls.Add(this.cleartextInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hashing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hashButton
            // 
            this.hashButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hashButton.Location = new System.Drawing.Point(592, 96);
            this.hashButton.Name = "hashButton";
            this.hashButton.Size = new System.Drawing.Size(104, 40);
            this.hashButton.TabIndex = 6;
            this.hashButton.Text = "Hash";
            this.hashButton.UseVisualStyleBackColor = true;
            this.hashButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Algorithm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hash";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hashOutput
            // 
            this.hashOutput.Location = new System.Drawing.Point(112, 200);
            this.hashOutput.Name = "hashOutput";
            this.hashOutput.Size = new System.Drawing.Size(456, 144);
            this.hashOutput.TabIndex = 1;
            this.hashOutput.Text = "";
            // 
            // cleartextInput
            // 
            this.cleartextInput.Location = new System.Drawing.Point(112, 80);
            this.cleartextInput.Name = "cleartextInput";
            this.cleartextInput.Size = new System.Drawing.Size(456, 80);
            this.cleartextInput.TabIndex = 0;
            this.cleartextInput.Text = "";
            this.cleartextInput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Symmetric Encryption";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(824, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asymmetric Encrpytion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(592, 248);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 40);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 618);
            this.Controls.Add(this.hashTab);
            this.Name = "Form1";
            this.Text = "Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hashTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl hashTab;
        private TabPage tabPage1;
        private Label label1;
        private RichTextBox hashOutput;
        private RichTextBox cleartextInput;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button hashButton;
        private Button clearButton;
    }
}