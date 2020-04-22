namespace smartCopyWatcher
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.conMenu_Notification = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.txt_InfoText = new System.Windows.Forms.TextBox();
            this.conMenu_Notification.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.conMenu_Notification;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Settings";
            this.notifyIcon1.Visible = true;
            // 
            // conMenu_Notification
            // 
            this.conMenu_Notification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.conMenu_Notification.Name = "conMenu_Notification";
            this.conMenu_Notification.Size = new System.Drawing.Size(129, 48);
            this.conMenu_Notification.Text = "Settings";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openToolStripMenuItem.Text = "Öffnen";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.closeToolStripMenuItem.Text = "Schliessen";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Location = new System.Drawing.Point(12, 98);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(75, 23);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.Text = "Minimieren";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // txt_InfoText
            // 
            this.txt_InfoText.ForeColor = System.Drawing.Color.Red;
            this.txt_InfoText.Location = new System.Drawing.Point(12, 13);
            this.txt_InfoText.Multiline = true;
            this.txt_InfoText.Name = "txt_InfoText";
            this.txt_InfoText.ReadOnly = true;
            this.txt_InfoText.Size = new System.Drawing.Size(307, 79);
            this.txt_InfoText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 133);
            this.ControlBox = false;
            this.Controls.Add(this.txt_InfoText);
            this.Controls.Add(this.btn_minimize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(347, 172);
            this.MinimumSize = new System.Drawing.Size(347, 172);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "smartCopyWatcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.conMenu_Notification.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip conMenu_Notification;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.TextBox txt_InfoText;
    }
}

