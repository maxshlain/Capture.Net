namespace Capture.Net
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tstrip_Main = new System.Windows.Forms.ToolStrip();
            this.btn_Capture = new System.Windows.Forms.ToolStripButton();
            this.tstrip_Context = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.tstrip_Main.SuspendLayout();
            this.tstrip_Context.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // tstrip_Main
            // 
            this.tstrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Capture});
            this.tstrip_Main.Location = new System.Drawing.Point(0, 0);
            this.tstrip_Main.Name = "tstrip_Main";
            this.tstrip_Main.Size = new System.Drawing.Size(284, 25);
            this.tstrip_Main.TabIndex = 0;
            this.tstrip_Main.Text = "toolStrip1";
            // 
            // btn_Capture
            // 
            this.btn_Capture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Capture.Image = ((System.Drawing.Image)(resources.GetObject("btn_Capture.Image")));
            this.btn_Capture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Capture.Name = "btn_Capture";
            this.btn_Capture.Size = new System.Drawing.Size(23, 22);
            this.btn_Capture.Text = "Capture";
            this.btn_Capture.ToolTipText = "Capture Image";
            this.btn_Capture.Click += new System.EventHandler(this.btn_Capture_Click);
            // 
            // tstrip_Context
            // 
            this.tstrip_Context.Dock = System.Windows.Forms.DockStyle.Left;
            this.tstrip_Context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.tstrip_Context.Location = new System.Drawing.Point(0, 25);
            this.tstrip_Context.Name = "tstrip_Context";
            this.tstrip_Context.Size = new System.Drawing.Size(24, 237);
            this.tstrip_Context.TabIndex = 1;
            this.tstrip_Context.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(29, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 237);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Location = new System.Drawing.Point(51, 0);
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDelay.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tstrip_Context);
            this.Controls.Add(this.tstrip_Main);
            this.Name = "MainForm";
            this.Text = "Capture.Net V1";
            this.tstrip_Main.ResumeLayout(false);
            this.tstrip_Main.PerformLayout();
            this.tstrip_Context.ResumeLayout(false);
            this.tstrip_Context.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstrip_Main;
        private System.Windows.Forms.ToolStrip tstrip_Context;
        private System.Windows.Forms.ToolStripButton btn_Capture;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
    }
}

