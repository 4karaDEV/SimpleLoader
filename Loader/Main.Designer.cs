namespace Loader
{
    partial class Main
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
            this.HeadPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.CloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SolutionLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.GamePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SelectBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.InjectBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.drag2 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.drag = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.HeadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.HeadPanel.Controls.Add(this.CloseBtn);
            this.HeadPanel.Controls.Add(this.SolutionLabel);
            this.HeadPanel.Location = new System.Drawing.Point(0, -1);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(360, 25);
            this.HeadPanel.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(329, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 25);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseTransparentBackground = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SolutionLabel
            // 
            this.SolutionLabel.BackColor = System.Drawing.Color.Transparent;
            this.SolutionLabel.CausesValidation = false;
            this.SolutionLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionLabel.ForeColor = System.Drawing.Color.White;
            this.SolutionLabel.IsSelectionEnabled = false;
            this.SolutionLabel.Location = new System.Drawing.Point(3, 5);
            this.SolutionLabel.Name = "SolutionLabel";
            this.SolutionLabel.Size = new System.Drawing.Size(93, 17);
            this.SolutionLabel.TabIndex = 5;
            this.SolutionLabel.Text = "Exemple Loader";
            // 
            // GamePanel
            // 
            this.GamePanel.BorderRadius = 14;
            this.GamePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.GamePanel.Location = new System.Drawing.Point(7, 33);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(133, 73);
            this.GamePanel.TabIndex = 2;
            // 
            // SelectBtn
            // 
            this.SelectBtn.BackColor = System.Drawing.Color.Transparent;
            this.SelectBtn.BorderRadius = 8;
            this.SelectBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectBtn.ForeColor = System.Drawing.Color.White;
            this.SelectBtn.Location = new System.Drawing.Point(7, 112);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(59, 25);
            this.SelectBtn.TabIndex = 3;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseTransparentBackground = true;
            // 
            // InjectBtn
            // 
            this.InjectBtn.BackColor = System.Drawing.Color.Transparent;
            this.InjectBtn.BorderRadius = 8;
            this.InjectBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InjectBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InjectBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InjectBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InjectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.InjectBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InjectBtn.ForeColor = System.Drawing.Color.White;
            this.InjectBtn.Location = new System.Drawing.Point(72, 112);
            this.InjectBtn.Name = "InjectBtn";
            this.InjectBtn.Size = new System.Drawing.Size(59, 25);
            this.InjectBtn.TabIndex = 4;
            this.InjectBtn.Text = "Inject";
            this.InjectBtn.UseTransparentBackground = true;
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Label.IsSelectionEnabled = false;
            this.Label.Location = new System.Drawing.Point(12, 143);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(126, 17);
            this.Label.TabIndex = 5;
            this.Label.Text = "Please Select A Game";
            // 
            // drag2
            // 
            this.drag2.DockIndicatorTransparencyValue = 1D;
            this.drag2.DragStartTransparencyValue = 1D;
            this.drag2.TargetControl = this.HeadPanel;
            this.drag2.UseTransparentDrag = true;
            // 
            // drag
            // 
            this.drag.DockIndicatorTransparencyValue = 1D;
            this.drag.DragStartTransparencyValue = 1D;
            this.drag.TargetControl = this;
            this.drag.UseTransparentDrag = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(357, 277);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.InjectBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.HeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Z";
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel HeadPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton CloseBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel SolutionLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel GamePanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SelectBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton InjectBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel Label;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl drag2;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl drag;
    }
}