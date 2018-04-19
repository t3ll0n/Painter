namespace Painter
{
    partial class PainterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainterForm));
            this.color_groupBox = new System.Windows.Forms.GroupBox();
            this.color_pictureBox = new System.Windows.Forms.PictureBox();
            this.colorCustom_radioButton = new System.Windows.Forms.RadioButton();
            this.colorBlack_radioButton = new System.Windows.Forms.RadioButton();
            this.colorGreen_radioButton = new System.Windows.Forms.RadioButton();
            this.colorBlue_radioButton = new System.Windows.Forms.RadioButton();
            this.colorRed_radioButton = new System.Windows.Forms.RadioButton();
            this.size_groupBox = new System.Windows.Forms.GroupBox();
            this.sizeCustom_radioButton = new System.Windows.Forms.RadioButton();
            this.size_textBox = new System.Windows.Forms.TextBox();
            this.sizeLarge_radioButton = new System.Windows.Forms.RadioButton();
            this.sizeMedium_radioButton = new System.Windows.Forms.RadioButton();
            this.sizeSmall_radioButton = new System.Windows.Forms.RadioButton();
            this.paint_panel = new System.Windows.Forms.Panel();
            this.clear_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.erase_button = new System.Windows.Forms.Button();
            this.paint_button = new System.Windows.Forms.Button();
            this.color_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_pictureBox)).BeginInit();
            this.size_groupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // color_groupBox
            // 
            this.color_groupBox.Controls.Add(this.color_pictureBox);
            this.color_groupBox.Controls.Add(this.colorCustom_radioButton);
            this.color_groupBox.Controls.Add(this.colorBlack_radioButton);
            this.color_groupBox.Controls.Add(this.colorGreen_radioButton);
            this.color_groupBox.Controls.Add(this.colorBlue_radioButton);
            this.color_groupBox.Controls.Add(this.colorRed_radioButton);
            this.color_groupBox.Location = new System.Drawing.Point(18, 46);
            this.color_groupBox.Name = "color_groupBox";
            this.color_groupBox.Size = new System.Drawing.Size(90, 165);
            this.color_groupBox.TabIndex = 0;
            this.color_groupBox.TabStop = false;
            this.color_groupBox.Text = "Color";
            // 
            // color_pictureBox
            // 
            this.color_pictureBox.Location = new System.Drawing.Point(31, 134);
            this.color_pictureBox.Name = "color_pictureBox";
            this.color_pictureBox.Size = new System.Drawing.Size(25, 25);
            this.color_pictureBox.TabIndex = 5;
            this.color_pictureBox.TabStop = false;
            // 
            // colorCustom_radioButton
            // 
            this.colorCustom_radioButton.AutoSize = true;
            this.colorCustom_radioButton.Location = new System.Drawing.Point(6, 111);
            this.colorCustom_radioButton.Name = "colorCustom_radioButton";
            this.colorCustom_radioButton.Size = new System.Drawing.Size(60, 17);
            this.colorCustom_radioButton.TabIndex = 4;
            this.colorCustom_radioButton.Text = "Custom";
            this.colorCustom_radioButton.UseVisualStyleBackColor = true;
            this.colorCustom_radioButton.Click += new System.EventHandler(this.color_radioButtons_Click);
            // 
            // colorBlack_radioButton
            // 
            this.colorBlack_radioButton.AutoSize = true;
            this.colorBlack_radioButton.Location = new System.Drawing.Point(6, 88);
            this.colorBlack_radioButton.Name = "colorBlack_radioButton";
            this.colorBlack_radioButton.Size = new System.Drawing.Size(52, 17);
            this.colorBlack_radioButton.TabIndex = 3;
            this.colorBlack_radioButton.Text = "Black";
            this.colorBlack_radioButton.UseVisualStyleBackColor = true;
            this.colorBlack_radioButton.Click += new System.EventHandler(this.color_radioButtons_Click);
            // 
            // colorGreen_radioButton
            // 
            this.colorGreen_radioButton.AutoSize = true;
            this.colorGreen_radioButton.Location = new System.Drawing.Point(6, 65);
            this.colorGreen_radioButton.Name = "colorGreen_radioButton";
            this.colorGreen_radioButton.Size = new System.Drawing.Size(54, 17);
            this.colorGreen_radioButton.TabIndex = 2;
            this.colorGreen_radioButton.Text = "Green";
            this.colorGreen_radioButton.UseVisualStyleBackColor = true;
            this.colorGreen_radioButton.Click += new System.EventHandler(this.color_radioButtons_Click);
            // 
            // colorBlue_radioButton
            // 
            this.colorBlue_radioButton.AutoSize = true;
            this.colorBlue_radioButton.Location = new System.Drawing.Point(6, 42);
            this.colorBlue_radioButton.Name = "colorBlue_radioButton";
            this.colorBlue_radioButton.Size = new System.Drawing.Size(46, 17);
            this.colorBlue_radioButton.TabIndex = 1;
            this.colorBlue_radioButton.Text = "Blue";
            this.colorBlue_radioButton.UseVisualStyleBackColor = true;
            this.colorBlue_radioButton.Click += new System.EventHandler(this.color_radioButtons_Click);
            // 
            // colorRed_radioButton
            // 
            this.colorRed_radioButton.AutoSize = true;
            this.colorRed_radioButton.Checked = true;
            this.colorRed_radioButton.Location = new System.Drawing.Point(6, 19);
            this.colorRed_radioButton.Name = "colorRed_radioButton";
            this.colorRed_radioButton.Size = new System.Drawing.Size(45, 17);
            this.colorRed_radioButton.TabIndex = 0;
            this.colorRed_radioButton.TabStop = true;
            this.colorRed_radioButton.Text = "Red";
            this.colorRed_radioButton.UseVisualStyleBackColor = true;
            this.colorRed_radioButton.Click += new System.EventHandler(this.color_radioButtons_Click);
            // 
            // size_groupBox
            // 
            this.size_groupBox.Controls.Add(this.sizeCustom_radioButton);
            this.size_groupBox.Controls.Add(this.size_textBox);
            this.size_groupBox.Controls.Add(this.sizeLarge_radioButton);
            this.size_groupBox.Controls.Add(this.sizeMedium_radioButton);
            this.size_groupBox.Controls.Add(this.sizeSmall_radioButton);
            this.size_groupBox.Location = new System.Drawing.Point(18, 228);
            this.size_groupBox.Name = "size_groupBox";
            this.size_groupBox.Size = new System.Drawing.Size(90, 137);
            this.size_groupBox.TabIndex = 1;
            this.size_groupBox.TabStop = false;
            this.size_groupBox.Text = "Size";
            // 
            // sizeCustom_radioButton
            // 
            this.sizeCustom_radioButton.AutoSize = true;
            this.sizeCustom_radioButton.Location = new System.Drawing.Point(6, 88);
            this.sizeCustom_radioButton.Name = "sizeCustom_radioButton";
            this.sizeCustom_radioButton.Size = new System.Drawing.Size(60, 17);
            this.sizeCustom_radioButton.TabIndex = 10;
            this.sizeCustom_radioButton.Text = "Custom";
            this.sizeCustom_radioButton.UseVisualStyleBackColor = true;
            this.sizeCustom_radioButton.Click += new System.EventHandler(this.size_radioButtons_Click);
            // 
            // size_textBox
            // 
            this.size_textBox.Location = new System.Drawing.Point(31, 111);
            this.size_textBox.Name = "size_textBox";
            this.size_textBox.ReadOnly = true;
            this.size_textBox.Size = new System.Drawing.Size(25, 20);
            this.size_textBox.TabIndex = 9;
            // 
            // sizeLarge_radioButton
            // 
            this.sizeLarge_radioButton.AutoSize = true;
            this.sizeLarge_radioButton.Location = new System.Drawing.Point(6, 65);
            this.sizeLarge_radioButton.Name = "sizeLarge_radioButton";
            this.sizeLarge_radioButton.Size = new System.Drawing.Size(52, 17);
            this.sizeLarge_radioButton.TabIndex = 8;
            this.sizeLarge_radioButton.Text = "Large";
            this.sizeLarge_radioButton.UseVisualStyleBackColor = true;
            this.sizeLarge_radioButton.Click += new System.EventHandler(this.size_radioButtons_Click);
            // 
            // sizeMedium_radioButton
            // 
            this.sizeMedium_radioButton.AutoSize = true;
            this.sizeMedium_radioButton.Location = new System.Drawing.Point(6, 42);
            this.sizeMedium_radioButton.Name = "sizeMedium_radioButton";
            this.sizeMedium_radioButton.Size = new System.Drawing.Size(62, 17);
            this.sizeMedium_radioButton.TabIndex = 7;
            this.sizeMedium_radioButton.Text = "Medium";
            this.sizeMedium_radioButton.UseVisualStyleBackColor = true;
            this.sizeMedium_radioButton.Click += new System.EventHandler(this.size_radioButtons_Click);
            // 
            // sizeSmall_radioButton
            // 
            this.sizeSmall_radioButton.AutoSize = true;
            this.sizeSmall_radioButton.Checked = true;
            this.sizeSmall_radioButton.Location = new System.Drawing.Point(6, 19);
            this.sizeSmall_radioButton.Name = "sizeSmall_radioButton";
            this.sizeSmall_radioButton.Size = new System.Drawing.Size(50, 17);
            this.sizeSmall_radioButton.TabIndex = 6;
            this.sizeSmall_radioButton.TabStop = true;
            this.sizeSmall_radioButton.Text = "Small";
            this.sizeSmall_radioButton.UseVisualStyleBackColor = true;
            this.sizeSmall_radioButton.Click += new System.EventHandler(this.size_radioButtons_Click);
            // 
            // paint_panel
            // 
            this.paint_panel.BackColor = System.Drawing.Color.White;
            this.paint_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paint_panel.Location = new System.Drawing.Point(142, 46);
            this.paint_panel.Name = "paint_panel";
            this.paint_panel.Size = new System.Drawing.Size(550, 504);
            this.paint_panel.TabIndex = 2;
            this.paint_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paint_panel_MouseDown);
            this.paint_panel.MouseLeave += new System.EventHandler(this.paint_panel_MouseLeave);
            this.paint_panel.MouseHover += new System.EventHandler(this.paint_panel_MouseHover);
            this.paint_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paint_Panel_MouseMove);
            this.paint_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paint_panel_MouseUp);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(36, 479);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(60, 25);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "CLEAR";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(36, 525);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(60, 25);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.sizeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.customToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.customToolStripMenuItem1});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem1
            // 
            this.customToolStripMenuItem1.Name = "customToolStripMenuItem1";
            this.customToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.customToolStripMenuItem1.Text = "Custom";
            this.customToolStripMenuItem1.Click += new System.EventHandler(this.customToolStripMenuItem1_Click);
            // 
            // erase_button
            // 
            this.erase_button.BackgroundImage = global::Painter.Properties.Resources.eraser;
            this.erase_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.erase_button.Location = new System.Drawing.Point(68, 399);
            this.erase_button.Name = "erase_button";
            this.erase_button.Size = new System.Drawing.Size(40, 40);
            this.erase_button.TabIndex = 7;
            this.erase_button.UseVisualStyleBackColor = true;
            this.erase_button.Click += new System.EventHandler(this.erase_button_Click);
            // 
            // paint_button
            // 
            this.paint_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paint_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paint_button.BackgroundImage")));
            this.paint_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paint_button.Location = new System.Drawing.Point(18, 399);
            this.paint_button.Name = "paint_button";
            this.paint_button.Size = new System.Drawing.Size(40, 40);
            this.paint_button.TabIndex = 6;
            this.paint_button.UseVisualStyleBackColor = false;
            this.paint_button.Click += new System.EventHandler(this.paint_button_Click);
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 585);
            this.Controls.Add(this.erase_button);
            this.Controls.Add(this.paint_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.paint_panel);
            this.Controls.Add(this.size_groupBox);
            this.Controls.Add(this.color_groupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PainterForm";
            this.Text = "Painter";
            this.color_groupBox.ResumeLayout(false);
            this.color_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_pictureBox)).EndInit();
            this.size_groupBox.ResumeLayout(false);
            this.size_groupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox color_groupBox;
        private System.Windows.Forms.GroupBox size_groupBox;
        private System.Windows.Forms.Panel paint_panel;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.PictureBox color_pictureBox;
        private System.Windows.Forms.RadioButton colorCustom_radioButton;
        private System.Windows.Forms.RadioButton colorBlack_radioButton;
        private System.Windows.Forms.RadioButton colorGreen_radioButton;
        private System.Windows.Forms.RadioButton colorBlue_radioButton;
        private System.Windows.Forms.RadioButton colorRed_radioButton;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.RadioButton sizeLarge_radioButton;
        private System.Windows.Forms.RadioButton sizeMedium_radioButton;
        private System.Windows.Forms.RadioButton sizeSmall_radioButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button paint_button;
        private System.Windows.Forms.Button erase_button;
        private System.Windows.Forms.RadioButton sizeCustom_radioButton;
        private System.Windows.Forms.TextBox size_textBox;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem1;
    }
}

