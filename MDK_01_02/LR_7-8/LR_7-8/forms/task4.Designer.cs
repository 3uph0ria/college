namespace LR_7_8.forms
{
    partial class task4
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
            this.logs = new System.Windows.Forms.TextBox();
            this.add_item_panel = new System.Windows.Forms.Button();
            this.add_item_form = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(294, 24);
            this.logs.Multiline = true;
            this.logs.Name = "logs";
            this.logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logs.Size = new System.Drawing.Size(216, 152);
            this.logs.TabIndex = 7;
            // 
            // add_item_panel
            // 
            this.add_item_panel.Location = new System.Drawing.Point(156, 24);
            this.add_item_panel.Name = "add_item_panel";
            this.add_item_panel.Size = new System.Drawing.Size(118, 57);
            this.add_item_panel.TabIndex = 6;
            this.add_item_panel.Text = "Добавить элемент на панель";
            this.add_item_panel.UseVisualStyleBackColor = true;
            this.add_item_panel.Click += new System.EventHandler(this.add_item_panel_Click);
            // 
            // add_item_form
            // 
            this.add_item_form.Location = new System.Drawing.Point(32, 24);
            this.add_item_form.Name = "add_item_form";
            this.add_item_form.Size = new System.Drawing.Size(118, 57);
            this.add_item_form.TabIndex = 5;
            this.add_item_form.Text = "Добавить элемент на форму";
            this.add_item_form.UseVisualStyleBackColor = true;
            this.add_item_form.Click += new System.EventHandler(this.add_item_form_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(516, 9);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(250, 250);
            this.panel.TabIndex = 4;
            // 
            // task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.add_item_panel);
            this.Controls.Add(this.add_item_form);
            this.Controls.Add(this.panel);
            this.Name = "task4";
            this.Text = "task4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logs;
        private System.Windows.Forms.Button add_item_panel;
        private System.Windows.Forms.Button add_item_form;
        private System.Windows.Forms.Panel panel;
    }
}