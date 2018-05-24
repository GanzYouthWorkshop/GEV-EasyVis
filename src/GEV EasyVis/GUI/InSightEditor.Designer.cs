namespace GEV.EasyVis.GUI
{
    partial class InSightEditor
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
            this.components = new System.ComponentModel.Container();
            this.gclWindowGrab1 = new GEV.Layouts.GCLWindowGrab();
            this.gclWindowHeader1 = new GEV.Layouts.GCLWindowHeader();
            this.gclDockingContainer1 = new GEV.Layouts.Docking.GCLDockingContainer(this.components);
            this.gclDockablePanel1 = new GEV.Layouts.Docking.GCLDockablePanel();
            this.gclDockablePanel2 = new GEV.Layouts.Docking.GCLDockablePanel();
            this.cvsFilmstrip1 = new Cognex.InSight.Controls.Filmstrip.CvsFilmstrip();
            this.discreteSettingsControl1 = new Cognex.InSight.Controls.Display.Internal.DiscreteSettingsControl();
            this.cvsInSightDisplay1 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.gclDockingContainer1.SuspendLayout();
            this.gclDockablePanel1.SuspendLayout();
            this.gclDockablePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gclWindowGrab1
            // 
            this.gclWindowGrab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gclWindowGrab1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gclWindowGrab1.Location = new System.Drawing.Point(1, 705);
            this.gclWindowGrab1.Margin = new System.Windows.Forms.Padding(2);
            this.gclWindowGrab1.Name = "gclWindowGrab1";
            this.gclWindowGrab1.Size = new System.Drawing.Size(1394, 32);
            this.gclWindowGrab1.TabIndex = 0;
            // 
            // gclWindowHeader1
            // 
            this.gclWindowHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gclWindowHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gclWindowHeader1.Location = new System.Drawing.Point(1, 1);
            this.gclWindowHeader1.Margin = new System.Windows.Forms.Padding(2);
            this.gclWindowHeader1.Name = "gclWindowHeader1";
            this.gclWindowHeader1.ShowCloseButton = true;
            this.gclWindowHeader1.ShowWindowButtons = true;
            this.gclWindowHeader1.Size = new System.Drawing.Size(1394, 40);
            this.gclWindowHeader1.TabIndex = 1;
            this.gclWindowHeader1.Title = "Camera Editor";
            // 
            // gclDockingContainer1
            // 
            this.gclDockingContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(84)))), ((int)(((byte)(86)))));
            this.gclDockingContainer1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gclDockingContainer1.Controls.Add(this.cvsInSightDisplay1);
            this.gclDockingContainer1.Controls.Add(this.gclDockablePanel2);
            this.gclDockingContainer1.Controls.Add(this.gclDockablePanel1);
            this.gclDockingContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclDockingContainer1.Location = new System.Drawing.Point(1, 41);
            this.gclDockingContainer1.Name = "gclDockingContainer1";
            this.gclDockingContainer1.Size = new System.Drawing.Size(1394, 664);
            this.gclDockingContainer1.TabIndex = 2;
            this.gclDockingContainer1.UseThemeColors = true;
            // 
            // gclDockablePanel1
            // 
            this.gclDockablePanel1.BackColor = System.Drawing.Color.White;
            this.gclDockablePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gclDockablePanel1.Controls.Add(this.discreteSettingsControl1);
            this.gclDockablePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gclDockablePanel1.Location = new System.Drawing.Point(910, 0);
            this.gclDockablePanel1.Name = "gclDockablePanel1";
            this.gclDockablePanel1.Padding = new System.Windows.Forms.Padding(1);
            this.gclDockablePanel1.Size = new System.Drawing.Size(484, 664);
            this.gclDockablePanel1.TabIndex = 0;
            this.gclDockablePanel1.Title = "IO Settings";
            this.gclDockablePanel1.UseThemeColors = true;
            // 
            // gclDockablePanel2
            // 
            this.gclDockablePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(84)))), ((int)(((byte)(86)))));
            this.gclDockablePanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gclDockablePanel2.Controls.Add(this.cvsFilmstrip1);
            this.gclDockablePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gclDockablePanel2.Location = new System.Drawing.Point(0, 564);
            this.gclDockablePanel2.Name = "gclDockablePanel2";
            this.gclDockablePanel2.Padding = new System.Windows.Forms.Padding(1);
            this.gclDockablePanel2.Size = new System.Drawing.Size(910, 100);
            this.gclDockablePanel2.TabIndex = 1;
            this.gclDockablePanel2.Title = "Film Strip";
            this.gclDockablePanel2.UseThemeColors = true;
            // 
            // cvsFilmstrip1
            // 
            this.cvsFilmstrip1.BackColor = System.Drawing.Color.Transparent;
            this.cvsFilmstrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvsFilmstrip1.FilmQueue = null;
            this.cvsFilmstrip1.FirstThumbnailIndex = 0;
            this.cvsFilmstrip1.HeightScale = Cognex.InSight.Controls.Filmstrip.CvsFilmstripScale.One;
            this.cvsFilmstrip1.ImageIndex = 0;
            this.cvsFilmstrip1.Location = new System.Drawing.Point(1, 22);
            this.cvsFilmstrip1.Name = "cvsFilmstrip1";
            this.cvsFilmstrip1.SelectedIndex = -1;
            this.cvsFilmstrip1.ShowSummary = false;
            this.cvsFilmstrip1.ShowThumbnailImage = true;
            this.cvsFilmstrip1.Size = new System.Drawing.Size(908, 77);
            this.cvsFilmstrip1.StatusLevelStyle = Cognex.InSight.Controls.Filmstrip.CvsStatusLevelStyle.Geometric;
            this.cvsFilmstrip1.TabIndex = 2;
            // 
            // discreteSettingsControl1
            // 
            this.discreteSettingsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discreteSettingsControl1.Location = new System.Drawing.Point(1, 22);
            this.discreteSettingsControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discreteSettingsControl1.Name = "discreteSettingsControl1";
            this.discreteSettingsControl1.Size = new System.Drawing.Size(482, 641);
            this.discreteSettingsControl1.TabIndex = 2;
            // 
            // cvsInSightDisplay1
            // 
            this.cvsInSightDisplay1.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay1.DialogIcon = null;
            this.cvsInSightDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvsInSightDisplay1.Location = new System.Drawing.Point(0, 0);
            this.cvsInSightDisplay1.Name = "cvsInSightDisplay1";
            this.cvsInSightDisplay1.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.Default;
            this.cvsInSightDisplay1.Size = new System.Drawing.Size(910, 564);
            this.cvsInSightDisplay1.TabIndex = 2;
            // 
            // InSightEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 738);
            this.Controls.Add(this.gclDockingContainer1);
            this.Controls.Add(this.gclWindowHeader1);
            this.Controls.Add(this.gclWindowGrab1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Name = "InSightEditor";
            this.Text = "Camera Editor";
            this.gclDockingContainer1.ResumeLayout(false);
            this.gclDockablePanel1.ResumeLayout(false);
            this.gclDockablePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Layouts.GCLWindowGrab gclWindowGrab1;
        private Layouts.GCLWindowHeader gclWindowHeader1;
        private Layouts.Docking.GCLDockingContainer gclDockingContainer1;
        private Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay1;
        private Layouts.Docking.GCLDockablePanel gclDockablePanel2;
        private Cognex.InSight.Controls.Filmstrip.CvsFilmstrip cvsFilmstrip1;
        private Layouts.Docking.GCLDockablePanel gclDockablePanel1;
        private Cognex.InSight.Controls.Display.Internal.DiscreteSettingsControl discreteSettingsControl1;
    }
}