using System.ComponentModel;

namespace RAES_00123619_2EP
{
    partial class AdminMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        private void InitializeComponent()
{
    this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
    this.button1 = new System.Windows.Forms.Button();
    this.button2 = new System.Windows.Forms.Button();
    this.tableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    // 
    // tableLayoutPanel1
    // 
    this.tableLayoutPanel1.ColumnCount = 3;
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
    this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
    this.tableLayoutPanel1.Controls.Add(this.button2, 1, 3);
    this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
    this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
    this.tableLayoutPanel1.Name = "tableLayoutPanel1";
    this.tableLayoutPanel1.RowCount = 5;
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
    this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 424);
    this.tableLayoutPanel1.TabIndex = 0;
    // 
    // button1
    // 
    this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.button1.Font = new System.Drawing.Font("Segoe UI", 15F);
    this.button1.Location = new System.Drawing.Point(141, 150);
    this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
    this.button1.Name = "button1";
    this.button1.Size = new System.Drawing.Size(408, 76);
    this.button1.TabIndex = 0;
    this.button1.Text = "Gestion de usuarios";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new System.EventHandler(this.button1_Click);
    // 
    // button2
    // 
    this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
    this.button2.Font = new System.Drawing.Font("Segoe UI", 15F);
    this.button2.Location = new System.Drawing.Point(141, 238);
    this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
    this.button2.Name = "button2";
    this.button2.Size = new System.Drawing.Size(408, 76);
    this.button2.TabIndex = 1;
    this.button2.Text = "Gestion de negocios";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new System.EventHandler(this.button2_Click);
    // 
    // AdminMenu
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.Controls.Add(this.tableLayoutPanel1);
    this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
    this.Name = "AdminMenu";
    this.Size = new System.Drawing.Size(690, 424);
    this.tableLayoutPanel1.ResumeLayout(false);
    this.ResumeLayout(false);
}

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}