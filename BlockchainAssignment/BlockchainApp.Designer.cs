namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.reciever = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(16, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(875, 386);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(368, 427);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(422, 22);
            this.publicKey.TabIndex = 3;
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(368, 455);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(422, 22);
            this.privateKey.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Private Key";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(796, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 53);
            this.button3.TabIndex = 8;
            this.button3.Text = "Validate Key";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(796, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 58);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generate Wallet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 520);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 60);
            this.button4.TabIndex = 9;
            this.button4.Text = "Create Transaction";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // reciever
            // 
            this.reciever.Location = new System.Drawing.Point(412, 561);
            this.reciever.Name = "reciever";
            this.reciever.Size = new System.Drawing.Size(209, 22);
            this.reciever.TabIndex = 16;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(187, 528);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(125, 22);
            this.amount.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Reciever Key";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(170, 429);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 24);
            this.button6.TabIndex = 22;
            this.button6.Text = "Read All";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 57);
            this.button5.TabIndex = 23;
            this.button5.Text = "Generate Block";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(145, 459);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 57);
            this.button7.TabIndex = 24;
            this.button7.Text = "Read Pending Transactions";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(662, 483);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 24);
            this.button8.TabIndex = 25;
            this.button8.Text = "Check Balance";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(695, 513);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 70);
            this.button9.TabIndex = 26;
            this.button9.Text = "Full Blockchain Validation";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fee";
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(187, 561);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(125, 22);
            this.fee.TabIndex = 28;
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 592);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.reciever);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox reciever;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fee;
    }
}

