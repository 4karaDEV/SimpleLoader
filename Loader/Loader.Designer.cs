namespace Loader
{
    partial class Loader
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HeadPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.CloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SolutionLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.KeyBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.drag = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.LoginBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Getbtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.KetLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.drag2 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.HeadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.HeadPanel.Controls.Add(this.CloseBtn);
            this.HeadPanel.Controls.Add(this.SolutionLabel);
            this.HeadPanel.Location = new System.Drawing.Point(-1, -2);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(359, 25);
            this.HeadPanel.TabIndex = 0;
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
            // KeyBox
            // 
            this.KeyBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.KeyBox.BorderRadius = 6;
            this.KeyBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyBox.DefaultText = "";
            this.KeyBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KeyBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KeyBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.KeyBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.KeyBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.KeyBox.ForeColor = System.Drawing.Color.White;
            this.KeyBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyBox.Location = new System.Drawing.Point(7, 32);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.PasswordChar = '\0';
            this.KeyBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.KeyBox.PlaceholderText = "";
            this.KeyBox.SelectedText = "";
            this.KeyBox.Size = new System.Drawing.Size(250, 23);
            this.KeyBox.TabIndex = 1;
            // 
            // drag
            // 
            this.drag.DockIndicatorTransparencyValue = 1D;
            this.drag.DragStartTransparencyValue = 1D;
            this.drag.TargetControl = this.HeadPanel;
            this.drag.UseTransparentDrag = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderRadius = 8;
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(7, 61);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(59, 25);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseTransparentBackground = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Getbtn
            // 
            this.Getbtn.BackColor = System.Drawing.Color.Transparent;
            this.Getbtn.BorderRadius = 8;
            this.Getbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Getbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Getbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Getbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Getbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Getbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Getbtn.ForeColor = System.Drawing.Color.White;
            this.Getbtn.Location = new System.Drawing.Point(72, 61);
            this.Getbtn.Name = "Getbtn";
            this.Getbtn.Size = new System.Drawing.Size(71, 25);
            this.Getbtn.TabIndex = 3;
            this.Getbtn.Text = "Get Key";
            this.Getbtn.UseTransparentBackground = true;
            this.Getbtn.Click += new System.EventHandler(this.GetBtn_Click);
            // 
            // KetLabel
            // 
            this.KetLabel.BackColor = System.Drawing.Color.Transparent;
            this.KetLabel.CausesValidation = false;
            this.KetLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.KetLabel.IsSelectionEnabled = false;
            this.KetLabel.Location = new System.Drawing.Point(261, 36);
            this.KetLabel.Name = "KetLabel";
            this.KetLabel.Size = new System.Drawing.Size(23, 17);
            this.KetLabel.TabIndex = 4;
            this.KetLabel.Text = "Key";
            // 
            // drag2
            // 
            this.drag2.DockIndicatorTransparencyValue = 1D;
            this.drag2.DragStartTransparencyValue = 1D;
            this.drag2.TargetControl = this;
            this.drag2.UseTransparentDrag = true;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(357, 215);
            this.Controls.Add(this.KetLabel);
            this.Controls.Add(this.Getbtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.HeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Loader_Load);
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel HeadPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox KeyBox;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl drag;
        private Siticone.Desktop.UI.WinForms.SiticoneButton LoginBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Getbtn;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel KetLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel SolutionLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton CloseBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl drag2;
    }
}

