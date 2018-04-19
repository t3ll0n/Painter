namespace Painter
{
    partial class CustomSizeForm
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
            this.customSize_label = new System.Windows.Forms.Label();
            this.customSize_textBox = new System.Windows.Forms.TextBox();
            this.customSize_okButton = new System.Windows.Forms.Button();
            this.customSize_cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customSize_label
            // 
            this.customSize_label.AutoSize = true;
            this.customSize_label.Location = new System.Drawing.Point(12, 31);
            this.customSize_label.Name = "customSize_label";
            this.customSize_label.Size = new System.Drawing.Size(154, 13);
            this.customSize_label.TabIndex = 0;
            this.customSize_label.Text = "Enter a size between 1 and 50:";
            // 
            // customSize_textBox
            // 
            this.customSize_textBox.Location = new System.Drawing.Point(172, 28);
            this.customSize_textBox.Name = "customSize_textBox";
            this.customSize_textBox.Size = new System.Drawing.Size(35, 20);
            this.customSize_textBox.TabIndex = 1;
            // 
            // customSize_okButton
            // 
            this.customSize_okButton.Location = new System.Drawing.Point(135, 115);
            this.customSize_okButton.Name = "customSize_okButton";
            this.customSize_okButton.Size = new System.Drawing.Size(50, 25);
            this.customSize_okButton.TabIndex = 2;
            this.customSize_okButton.Text = "OK";
            this.customSize_okButton.UseVisualStyleBackColor = true;
            this.customSize_okButton.Click += new System.EventHandler(this.customSize_okButton_Click);
            // 
            // customSize_cancelButton
            // 
            this.customSize_cancelButton.Location = new System.Drawing.Point(191, 115);
            this.customSize_cancelButton.Name = "customSize_cancelButton";
            this.customSize_cancelButton.Size = new System.Drawing.Size(60, 25);
            this.customSize_cancelButton.TabIndex = 3;
            this.customSize_cancelButton.Text = "CANCEL";
            this.customSize_cancelButton.UseVisualStyleBackColor = true;
            this.customSize_cancelButton.Click += new System.EventHandler(this.customSize_cancelButton_Click);
            // 
            // CustomSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 152);
            this.Controls.Add(this.customSize_cancelButton);
            this.Controls.Add(this.customSize_okButton);
            this.Controls.Add(this.customSize_textBox);
            this.Controls.Add(this.customSize_label);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "CustomSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Size";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customSize_label;
        private System.Windows.Forms.TextBox customSize_textBox;
        private System.Windows.Forms.Button customSize_okButton;
        private System.Windows.Forms.Button customSize_cancelButton;
    }
}