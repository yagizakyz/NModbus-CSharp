namespace NModbusExamples
{
    partial class ReadHoldingRegisterForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.readHoldRegBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.readHoldRegBTN);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "READ HOLDING REGISTER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESULT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(815, 185);
            this.textBox1.TabIndex = 1;
            // 
            // readHoldRegBTN
            // 
            this.readHoldRegBTN.Location = new System.Drawing.Point(319, 270);
            this.readHoldRegBTN.Name = "readHoldRegBTN";
            this.readHoldRegBTN.Size = new System.Drawing.Size(201, 75);
            this.readHoldRegBTN.TabIndex = 2;
            this.readHoldRegBTN.Text = "Read Holding Register";
            this.readHoldRegBTN.UseVisualStyleBackColor = true;
            this.readHoldRegBTN.Click += new System.EventHandler(this.readHoldRegBTN_Click);
            // 
            // ReadHoldingRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 397);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReadHoldingRegisterForm";
            this.Text = "MODBUS RTU EXAMPLE";
            this.Load += new System.EventHandler(this.ReadHoldingRegisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button readHoldRegBTN;
        private TextBox textBox1;
        private Label label1;
    }
}