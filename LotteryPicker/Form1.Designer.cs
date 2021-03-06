﻿namespace LotteryPicker
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.generateLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.headerLabel.Location = new System.Drawing.Point(-4, -3);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(500, 119);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Lottery Number Generator";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateButton
            // 
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Dutch801 Rm BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.generateButton.Location = new System.Drawing.Point(170, 218);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(154, 55);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateLabel
            // 
            this.generateLabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.generateLabel.Location = new System.Drawing.Point(-4, 149);
            this.generateLabel.Name = "generateLabel";
            this.generateLabel.Size = new System.Drawing.Size(500, 66);
            this.generateLabel.TabIndex = 2;
            this.generateLabel.Text = "Click to generate winning numbers";
            this.generateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.outputLabel.Location = new System.Drawing.Point(-4, 333);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(500, 66);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(492, 436);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.generateLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.headerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label generateLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

