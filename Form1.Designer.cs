namespace WindowsFormsApplication7
{
    partial class Form1
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
            this.textBoxPrinciple = new System.Windows.Forms.TextBox();
            this.textBoxIntrestRate = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelIntrestRate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPrinciple = new System.Windows.Forms.Label();
            this.buttonCalculateIntrest = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPrinciple
            // 
            this.textBoxPrinciple.Location = new System.Drawing.Point(145, 48);
            this.textBoxPrinciple.Name = "textBoxPrinciple";
            this.textBoxPrinciple.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrinciple.TabIndex = 0;
            this.textBoxPrinciple.Tag = "";
            this.textBoxPrinciple.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxIntrestRate
            // 
            this.textBoxIntrestRate.Location = new System.Drawing.Point(145, 123);
            this.textBoxIntrestRate.Name = "textBoxIntrestRate";
            this.textBoxIntrestRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxIntrestRate.TabIndex = 1;
            this.textBoxIntrestRate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(145, 85);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTime.TabIndex = 2;
            this.textBoxTime.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelIntrestRate
            // 
            this.labelIntrestRate.AutoSize = true;
            this.labelIntrestRate.Location = new System.Drawing.Point(23, 130);
            this.labelIntrestRate.Name = "labelIntrestRate";
            this.labelIntrestRate.Size = new System.Drawing.Size(68, 13);
            this.labelIntrestRate.TabIndex = 3;
            this.labelIntrestRate.Text = "Intrest Rate :";
            this.labelIntrestRate.UseMnemonic = false;
            this.labelIntrestRate.Click += new System.EventHandler(this.labelIntrestRate_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(23, 92);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(70, 13);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time (years) :";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // labelPrinciple
            // 
            this.labelPrinciple.AutoSize = true;
            this.labelPrinciple.Location = new System.Drawing.Point(23, 55);
            this.labelPrinciple.Name = "labelPrinciple";
            this.labelPrinciple.Size = new System.Drawing.Size(53, 13);
            this.labelPrinciple.TabIndex = 5;
            this.labelPrinciple.Text = "Principle :";
            this.labelPrinciple.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonCalculateIntrest
            // 
            this.buttonCalculateIntrest.Location = new System.Drawing.Point(145, 167);
            this.buttonCalculateIntrest.Name = "buttonCalculateIntrest";
            this.buttonCalculateIntrest.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateIntrest.TabIndex = 6;
            this.buttonCalculateIntrest.Text = "Calculate ";
            this.buttonCalculateIntrest.UseVisualStyleBackColor = true;
            this.buttonCalculateIntrest.Click += new System.EventHandler(this.buttonCalculateIntrest_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(100, 224);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculateIntrest);
            this.Controls.Add(this.labelPrinciple);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelIntrestRate);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxIntrestRate);
            this.Controls.Add(this.textBoxPrinciple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrinciple;
        private System.Windows.Forms.TextBox textBoxIntrestRate;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelIntrestRate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPrinciple;
        private System.Windows.Forms.Button buttonCalculateIntrest;
        private System.Windows.Forms.Label labelResult;
    }
}

