namespace GEV.EasyVis.GUI
{
    partial class FontSettings
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
            this.gclWindowHeader1 = new GEV.Layouts.GCLWindowHeader();
            this.gclPanel1 = new GEV.Layouts.GCLPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gclButton1 = new GEV.Layouts.GCLButton();
            this.gclButton2 = new GEV.Layouts.GCLButton();
            this.fontSettingsControl1 = new GEV.EasyVis.GUI.UIControls.FontSettingsControl();
            this.gclPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gclWindowHeader1
            // 
            this.gclWindowHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gclWindowHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gclWindowHeader1.Location = new System.Drawing.Point(1, 1);
            this.gclWindowHeader1.Margin = new System.Windows.Forms.Padding(2);
            this.gclWindowHeader1.Name = "gclWindowHeader1";
            this.gclWindowHeader1.ShowCloseButton = true;
            this.gclWindowHeader1.ShowWindowButtons = false;
            this.gclWindowHeader1.Size = new System.Drawing.Size(602, 40);
            this.gclWindowHeader1.TabIndex = 0;
            this.gclWindowHeader1.Title = "Betűtípus";
            // 
            // gclPanel1
            // 
            this.gclPanel1.BackColor = System.Drawing.Color.White;
            this.gclPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gclPanel1.Controls.Add(this.gclButton2);
            this.gclPanel1.Controls.Add(this.gclButton1);
            this.gclPanel1.Controls.Add(this.fontSettingsControl1);
            this.gclPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclPanel1.Location = new System.Drawing.Point(10, 10);
            this.gclPanel1.Name = "gclPanel1";
            this.gclPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.gclPanel1.Size = new System.Drawing.Size(582, 491);
            this.gclPanel1.TabIndex = 3;
            this.gclPanel1.UseThemeColors = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gclPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 41);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(602, 511);
            this.panel1.TabIndex = 4;
            // 
            // gclButton1
            // 
            this.gclButton1.BackColor = System.Drawing.Color.White;
            this.gclButton1.Checked = false;
            this.gclButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.gclButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.gclButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(87)))));
            this.gclButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.gclButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gclButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gclButton1.Location = new System.Drawing.Point(385, 448);
            this.gclButton1.Name = "gclButton1";
            this.gclButton1.Size = new System.Drawing.Size(91, 35);
            this.gclButton1.TabIndex = 3;
            this.gclButton1.Text = "OK";
            this.gclButton1.UseThemeColors = true;
            this.gclButton1.UseVisualStyleBackColor = false;
            // 
            // gclButton2
            // 
            this.gclButton2.BackColor = System.Drawing.Color.White;
            this.gclButton2.Checked = false;
            this.gclButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.gclButton2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.gclButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(87)))));
            this.gclButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.gclButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gclButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gclButton2.Location = new System.Drawing.Point(482, 448);
            this.gclButton2.Name = "gclButton2";
            this.gclButton2.Size = new System.Drawing.Size(91, 35);
            this.gclButton2.TabIndex = 4;
            this.gclButton2.Text = "Mégse";
            this.gclButton2.UseThemeColors = true;
            this.gclButton2.UseVisualStyleBackColor = false;
            // 
            // fontSettingsControl1
            // 
            this.fontSettingsControl1.FontColor = System.Drawing.Color.White;
            this.fontSettingsControl1.Location = new System.Drawing.Point(14, 14);
            this.fontSettingsControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fontSettingsControl1.Name = "fontSettingsControl1";
            this.fontSettingsControl1.SelectedFont = null;
            this.fontSettingsControl1.ShowColorPicker = true;
            this.fontSettingsControl1.Size = new System.Drawing.Size(559, 427);
            this.fontSettingsControl1.TabIndex = 2;
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(604, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gclWindowHeader1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Name = "FontSettings";
            this.Text = "Betűtípus";
            this.gclPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Layouts.GCLWindowHeader gclWindowHeader1;
        private UIControls.FontSettingsControl fontSettingsControl1;
        private Layouts.GCLPanel gclPanel1;
        private Layouts.GCLButton gclButton2;
        private Layouts.GCLButton gclButton1;
        private System.Windows.Forms.Panel panel1;
    }
}