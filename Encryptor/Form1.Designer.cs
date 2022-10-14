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
            this.clearButton = new System.Windows.Forms.Button();
            this.hashButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hashOutput = new System.Windows.Forms.RichTextBox();
            this.cleartextInput = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.initVector = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.symEncKey = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.symEncClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.symDecrypted = new System.Windows.Forms.RichTextBox();
            this.symDecryptBtn = new System.Windows.Forms.Button();
            this.symEncryptBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.symCipherText = new System.Windows.Forms.RichTextBox();
            this.symEncryptEntry = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.generateSymEncKey = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hashTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hashTab
            // 
            this.hashTab.Controls.Add(this.tabPage2);
            this.hashTab.Controls.Add(this.tabPage1);
            this.hashTab.Controls.Add(this.tabPage3);
            this.hashTab.Location = new System.Drawing.Point(8, 8);
            this.hashTab.Name = "hashTab";
            this.hashTab.SelectedIndex = 0;
            this.hashTab.Size = new System.Drawing.Size(776, 760);
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
            this.tabPage1.Size = new System.Drawing.Size(768, 732);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hashing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(592, 200);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 40);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // hashButton
            // 
            this.hashButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hashButton.Location = new System.Drawing.Point(592, 72);
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
            this.label3.Location = new System.Drawing.Point(24, 16);
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
            this.label2.Location = new System.Drawing.Point(24, 160);
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
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hashOutput
            // 
            this.hashOutput.Location = new System.Drawing.Point(112, 152);
            this.hashOutput.Name = "hashOutput";
            this.hashOutput.Size = new System.Drawing.Size(456, 144);
            this.hashOutput.TabIndex = 1;
            this.hashOutput.Text = "";
            // 
            // cleartextInput
            // 
            this.cleartextInput.Location = new System.Drawing.Point(112, 56);
            this.cleartextInput.Name = "cleartextInput";
            this.cleartextInput.Size = new System.Drawing.Size(456, 80);
            this.cleartextInput.TabIndex = 0;
            this.cleartextInput.Text = "";
            this.cleartextInput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.generateSymEncKey);
            this.tabPage2.Controls.Add(this.initVector);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.symEncKey);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.symEncClear);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.symDecrypted);
            this.tabPage2.Controls.Add(this.symDecryptBtn);
            this.tabPage2.Controls.Add(this.symEncryptBtn);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.symCipherText);
            this.tabPage2.Controls.Add(this.symEncryptEntry);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 732);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Symmetric Encryption";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // initVector
            // 
            this.initVector.Location = new System.Drawing.Point(120, 488);
            this.initVector.Name = "initVector";
            this.initVector.Size = new System.Drawing.Size(456, 48);
            this.initVector.TabIndex = 22;
            this.initVector.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 42);
            this.label9.TabIndex = 21;
            this.label9.Text = "Initialization\r\nVector\r\n";
            // 
            // symEncKey
            // 
            this.symEncKey.Location = new System.Drawing.Point(120, 256);
            this.symEncKey.Name = "symEncKey";
            this.symEncKey.Size = new System.Drawing.Size(456, 48);
            this.symEncKey.TabIndex = 20;
            this.symEncKey.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Key";
            // 
            // symEncClear
            // 
            this.symEncClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.symEncClear.Location = new System.Drawing.Point(600, 568);
            this.symEncClear.Name = "symEncClear";
            this.symEncClear.Size = new System.Drawing.Size(128, 40);
            this.symEncClear.TabIndex = 18;
            this.symEncClear.Text = "Clear";
            this.symEncClear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 42);
            this.label7.TabIndex = 17;
            this.label7.Text = "Original\r\nMessage";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // symDecrypted
            // 
            this.symDecrypted.Location = new System.Drawing.Point(120, 552);
            this.symDecrypted.Name = "symDecrypted";
            this.symDecrypted.Size = new System.Drawing.Size(456, 80);
            this.symDecrypted.TabIndex = 16;
            this.symDecrypted.Text = "";
            this.symDecrypted.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // symDecryptBtn
            // 
            this.symDecryptBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.symDecryptBtn.Location = new System.Drawing.Point(600, 376);
            this.symDecryptBtn.Name = "symDecryptBtn";
            this.symDecryptBtn.Size = new System.Drawing.Size(128, 40);
            this.symDecryptBtn.TabIndex = 15;
            this.symDecryptBtn.Text = "Decrypt";
            this.symDecryptBtn.UseVisualStyleBackColor = true;
            this.symDecryptBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // symEncryptBtn
            // 
            this.symEncryptBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.symEncryptBtn.Location = new System.Drawing.Point(600, 72);
            this.symEncryptBtn.Name = "symEncryptBtn";
            this.symEncryptBtn.Size = new System.Drawing.Size(128, 40);
            this.symEncryptBtn.TabIndex = 14;
            this.symEncryptBtn.Text = "Encrypt";
            this.symEncryptBtn.UseVisualStyleBackColor = true;
            this.symEncryptBtn.Click += new System.EventHandler(this.symEncryptBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Algorithm";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(120, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 23);
            this.comboBox2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cipher Text";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Message";
            // 
            // symCipherText
            // 
            this.symCipherText.Location = new System.Drawing.Point(120, 320);
            this.symCipherText.Name = "symCipherText";
            this.symCipherText.Size = new System.Drawing.Size(456, 152);
            this.symCipherText.TabIndex = 9;
            this.symCipherText.Text = "";
            // 
            // symEncryptEntry
            // 
            this.symEncryptEntry.Location = new System.Drawing.Point(120, 56);
            this.symEncryptEntry.Name = "symEncryptEntry";
            this.symEncryptEntry.Size = new System.Drawing.Size(456, 80);
            this.symEncryptEntry.TabIndex = 8;
            this.symEncryptEntry.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 732);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asymmetric Encrpytion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // generateSymEncKey
            // 
            this.generateSymEncKey.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateSymEncKey.Location = new System.Drawing.Point(600, 160);
            this.generateSymEncKey.Name = "generateSymEncKey";
            this.generateSymEncKey.Size = new System.Drawing.Size(128, 40);
            this.generateSymEncKey.TabIndex = 23;
            this.generateSymEncKey.Text = "Generate Key";
            this.generateSymEncKey.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(120, 152);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(456, 88);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(24, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Key Seed";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 775);
            this.Controls.Add(this.hashTab);
            this.Name = "Form1";
            this.Text = "Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hashTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private Button symDecryptBtn;
        private Button symEncryptBtn;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private RichTextBox symCipherText;
        private RichTextBox symEncryptEntry;
        private Label label7;
        private RichTextBox symDecrypted;
        private Button symEncClear;
        private RichTextBox symEncKey;
        private Label label8;
        private RichTextBox initVector;
        private Label label9;
        private Button generateSymEncKey;
        private RichTextBox richTextBox1;
        private Label label10;
    }
}