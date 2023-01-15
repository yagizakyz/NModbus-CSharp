namespace NModbusExamples
{
    partial class ReadWordArrayFromModbusSlaveFrom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTXT = new System.Windows.Forms.TextBox();
            this.readHoldRegBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.readHoldRegBTN);
            this.groupBox1.Controls.Add(this.resultTXT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "READ WORD ARRAY FROM MOBUS SLAVE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESULT";
            // 
            // resultTXT
            // 
            this.resultTXT.Location = new System.Drawing.Point(14, 70);
            this.resultTXT.Multiline = true;
            this.resultTXT.Name = "resultTXT";
            this.resultTXT.Size = new System.Drawing.Size(756, 281);
            this.resultTXT.TabIndex = 1;
            // 
            // readHoldRegBTN
            // 
            this.readHoldRegBTN.Location = new System.Drawing.Point(271, 357);
            this.readHoldRegBTN.Name = "readHoldRegBTN";
            this.readHoldRegBTN.Size = new System.Drawing.Size(233, 45);
            this.readHoldRegBTN.TabIndex = 2;
            this.readHoldRegBTN.Text = "Read Holding Register";
            this.readHoldRegBTN.UseVisualStyleBackColor = true;
            this.readHoldRegBTN.Click += new System.EventHandler(this.readHoldRegBTN_Click);
            // 
            // ReadWordArrayFromModbusSlaveFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReadWordArrayFromModbusSlaveFrom";
            this.Text = "MODBUS RTU EXAMPLE";
            this.Load += new System.EventHandler(this.ReadWordArrayFromModbusSlaveFrom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button readHoldRegBTN;
        private TextBox resultTXT;
        private Label label1;
    }
}