﻿namespace WindowsFormsTest
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
			this.bigButton = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.bigTextbox = new System.Windows.Forms.TextBox();
			this.smallButton = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bigButton
			// 
			this.bigButton.Location = new System.Drawing.Point(28, 33);
			this.bigButton.Name = "bigButton";
			this.bigButton.Size = new System.Drawing.Size(192, 70);
			this.bigButton.TabIndex = 0;
			this.bigButton.Text = "Big Button";
			this.bigButton.UseVisualStyleBackColor = true;
			this.bigButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(28, 137);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 17);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(28, 161);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(80, 17);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "checkBox2";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// bigTextbox
			// 
			this.bigTextbox.AcceptsReturn = true;
			this.bigTextbox.AcceptsTab = true;
			this.bigTextbox.CausesValidation = false;
			this.bigTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bigTextbox.Location = new System.Drawing.Point(0, 326);
			this.bigTextbox.Multiline = true;
			this.bigTextbox.Name = "bigTextbox";
			this.bigTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.bigTextbox.Size = new System.Drawing.Size(679, 117);
			this.bigTextbox.TabIndex = 3;
			this.bigTextbox.TextChanged += new System.EventHandler(this.bigTextbox_TextChanged);
			// 
			// smallButton
			// 
			this.smallButton.Location = new System.Drawing.Point(357, 57);
			this.smallButton.Name = "smallButton";
			this.smallButton.Size = new System.Drawing.Size(75, 23);
			this.smallButton.TabIndex = 4;
			this.smallButton.Text = "Small Button";
			this.smallButton.UseVisualStyleBackColor = true;
			this.smallButton.Click += new System.EventHandler(this.smallButton_Click);
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.CausesValidation = false;
			this.label.Location = new System.Drawing.Point(357, 161);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(35, 13);
			this.label.TabIndex = 5;
			this.label.Text = "Olaaa";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 443);
			this.Controls.Add(this.label);
			this.Controls.Add(this.smallButton);
			this.Controls.Add(this.bigTextbox);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.bigButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bigButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.TextBox bigTextbox;
		private System.Windows.Forms.Button smallButton;
		private System.Windows.Forms.Label label;
	}
}

