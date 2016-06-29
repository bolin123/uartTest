namespace uartTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uartComboBox = new System.Windows.Forms.ComboBox();
            this.baudComboBox = new System.Windows.Forms.ComboBox();
            this.openUartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.broadcastButton = new System.Windows.Forms.Button();
            this.selfcheckButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.controlTextBox = new System.Windows.Forms.TextBox();
            this.addrTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uartComboBox
            // 
            this.uartComboBox.FormattingEnabled = true;
            this.uartComboBox.Location = new System.Drawing.Point(95, 39);
            this.uartComboBox.Name = "uartComboBox";
            this.uartComboBox.Size = new System.Drawing.Size(121, 20);
            this.uartComboBox.TabIndex = 0;
            // 
            // baudComboBox
            // 
            this.baudComboBox.FormattingEnabled = true;
            this.baudComboBox.Location = new System.Drawing.Point(290, 39);
            this.baudComboBox.Name = "baudComboBox";
            this.baudComboBox.Size = new System.Drawing.Size(121, 20);
            this.baudComboBox.TabIndex = 0;
            // 
            // openUartButton
            // 
            this.openUartButton.Location = new System.Drawing.Point(433, 37);
            this.openUartButton.Name = "openUartButton";
            this.openUartButton.Size = new System.Drawing.Size(75, 23);
            this.openUartButton.TabIndex = 1;
            this.openUartButton.Text = "打开";
            this.openUartButton.UseVisualStyleBackColor = true;
            this.openUartButton.Click += new System.EventHandler(this.openUartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "串口号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率：";
            // 
            // broadcastButton
            // 
            this.broadcastButton.Location = new System.Drawing.Point(75, 109);
            this.broadcastButton.Name = "broadcastButton";
            this.broadcastButton.Size = new System.Drawing.Size(75, 23);
            this.broadcastButton.TabIndex = 3;
            this.broadcastButton.Text = "广播";
            this.broadcastButton.UseVisualStyleBackColor = true;
            this.broadcastButton.Click += new System.EventHandler(this.broadcastButton_Click);
            // 
            // selfcheckButton
            // 
            this.selfcheckButton.Location = new System.Drawing.Point(412, 109);
            this.selfcheckButton.Name = "selfcheckButton";
            this.selfcheckButton.Size = new System.Drawing.Size(75, 23);
            this.selfcheckButton.TabIndex = 3;
            this.selfcheckButton.Text = "自检";
            this.selfcheckButton.UseVisualStyleBackColor = true;
            this.selfcheckButton.Click += new System.EventHandler(this.selfcheckButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.controlTextBox);
            this.groupBox1.Location = new System.Drawing.Point(51, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 274);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自定义";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(348, 223);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "发送";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // controlTextBox
            // 
            this.controlTextBox.Location = new System.Drawing.Point(24, 33);
            this.controlTextBox.Multiline = true;
            this.controlTextBox.Name = "controlTextBox";
            this.controlTextBox.Size = new System.Drawing.Size(412, 169);
            this.controlTextBox.TabIndex = 0;
            // 
            // addrTextBox
            // 
            this.addrTextBox.Location = new System.Drawing.Point(296, 111);
            this.addrTextBox.Name = "addrTextBox";
            this.addrTextBox.Size = new System.Drawing.Size(100, 21);
            this.addrTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "地址：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addrTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selfcheckButton);
            this.Controls.Add(this.broadcastButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openUartButton);
            this.Controls.Add(this.baudComboBox);
            this.Controls.Add(this.uartComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selfcheckButton;
        private System.Windows.Forms.Button broadcastButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openUartButton;
        private System.Windows.Forms.ComboBox baudComboBox;
        private System.Windows.Forms.ComboBox uartComboBox;
        private System.Windows.Forms.TextBox controlTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addrTextBox;
        private System.Windows.Forms.Label label3;
    }
}

