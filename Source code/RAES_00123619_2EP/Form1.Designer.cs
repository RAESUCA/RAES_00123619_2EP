namespace RAES_00123619_2EP
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
            this.login1 = new RAES_00123619_2EP.login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.SystemColors.Control;
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(914, 600);
            this.login1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RAES_00123619_2EP.Properties.Resources.Untitled;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.login1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private RAES_00123619_2EP.login login1;
    }
}