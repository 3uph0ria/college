namespace LR_5_6.forms
{
    partial class task3
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
            this.button_result = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.input_dx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_xk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_x0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_a = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(95, 290);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(75, 23);
            this.button_result.TabIndex = 29;
            this.button_result.Text = "вычислить";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(9, 116);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.result.Size = new System.Drawing.Size(253, 156);
            this.result.TabIndex = 28;
            // 
            // input_dx
            // 
            this.input_dx.Location = new System.Drawing.Point(50, 64);
            this.input_dx.Name = "input_dx";
            this.input_dx.Size = new System.Drawing.Size(212, 20);
            this.input_dx.TabIndex = 25;
            this.input_dx.Text = "0,2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Dx";
            // 
            // input_xk
            // 
            this.input_xk.Location = new System.Drawing.Point(50, 38);
            this.input_xk.Name = "input_xk";
            this.input_xk.Size = new System.Drawing.Size(212, 20);
            this.input_xk.TabIndex = 23;
            this.input_xk.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Xk";
            // 
            // input_x0
            // 
            this.input_x0.Location = new System.Drawing.Point(50, 12);
            this.input_x0.Name = "input_x0";
            this.input_x0.Size = new System.Drawing.Size(212, 20);
            this.input_x0.TabIndex = 21;
            this.input_x0.Text = "-2,4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "X0";
            // 
            // input_a
            // 
            this.input_a.Location = new System.Drawing.Point(50, 90);
            this.input_a.Name = "input_a";
            this.input_a.Size = new System.Drawing.Size(212, 20);
            this.input_a.TabIndex = 31;
            this.input_a.Text = "2,5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "b";
            // 
            // task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 319);
            this.Controls.Add(this.input_a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.result);
            this.Controls.Add(this.input_dx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_xk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_x0);
            this.Controls.Add(this.label1);
            this.Name = "task3";
            this.Text = "task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox input_dx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_xk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_x0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_a;
        private System.Windows.Forms.Label label4;
    }
}