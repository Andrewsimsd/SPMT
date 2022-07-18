
namespace SPMT
{
    partial class MainForm
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
            this.tlpNavButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSecurityLookup = new System.Windows.Forms.Button();
            this.pnlCurrentForm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpNavButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpNavButtons
            // 
            this.tlpNavButtons.ColumnCount = 1;
            this.tlpNavButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavButtons.Controls.Add(this.btnSecurityLookup, 0, 1);
            this.tlpNavButtons.Controls.Add(this.button1, 0, 2);
            this.tlpNavButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpNavButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpNavButtons.Name = "tlpNavButtons";
            this.tlpNavButtons.RowCount = 6;
            this.tlpNavButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpNavButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpNavButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpNavButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpNavButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpNavButtons.Size = new System.Drawing.Size(200, 460);
            this.tlpNavButtons.TabIndex = 0;
            // 
            // btnSecurityLookup
            // 
            this.btnSecurityLookup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecurityLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurityLookup.ForeColor = System.Drawing.Color.White;
            this.btnSecurityLookup.Location = new System.Drawing.Point(3, 123);
            this.btnSecurityLookup.Name = "btnSecurityLookup";
            this.btnSecurityLookup.Size = new System.Drawing.Size(194, 34);
            this.btnSecurityLookup.TabIndex = 0;
            this.btnSecurityLookup.Text = "Secutiry Lookup";
            this.btnSecurityLookup.UseVisualStyleBackColor = true;
            this.btnSecurityLookup.Click += new System.EventHandler(this.btnSecurityLookup_Click);
            // 
            // pnlCurrentForm
            // 
            this.pnlCurrentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCurrentForm.Location = new System.Drawing.Point(200, 0);
            this.pnlCurrentForm.Name = "pnlCurrentForm";
            this.pnlCurrentForm.Size = new System.Drawing.Size(670, 460);
            this.pnlCurrentForm.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Another Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(870, 460);
            this.Controls.Add(this.pnlCurrentForm);
            this.Controls.Add(this.tlpNavButtons);
            this.Name = "MainForm";
            this.Text = "SMPT";
            this.tlpNavButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNavButtons;
        private System.Windows.Forms.Button btnSecurityLookup;
        private System.Windows.Forms.Panel pnlCurrentForm;
        private System.Windows.Forms.Button button1;
    }
}

