namespace ocv_myopie
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
            this.components = new System.ComponentModel.Container();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.tmrFrame = new System.Windows.Forms.Timer(this.components);
            this.spc = new gei1076_tools.SerialPortConfigurator();
            this.vsbDioptrie = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCamera
            // 
            this.pbCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCamera.Location = new System.Drawing.Point(13, 112);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(499, 296);
            this.pbCamera.TabIndex = 0;
            this.pbCamera.TabStop = false;
            // 
            // tmrFrame
            // 
            this.tmrFrame.Interval = 30;
            this.tmrFrame.Tick += new System.EventHandler(this.tmrFrame_Tick);
            // 
            // spc
            // 
            this.spc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spc.Location = new System.Drawing.Point(13, 13);
            this.spc.Name = "spc";
            this.spc.Size = new System.Drawing.Size(499, 93);
            this.spc.TabIndex = 1;
            // 
            // vsbDioptrie
            // 
            this.vsbDioptrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vsbDioptrie.LargeChange = 100;
            this.vsbDioptrie.Location = new System.Drawing.Point(541, 57);
            this.vsbDioptrie.Maximum = 1000;
            this.vsbDioptrie.Minimum = -1000;
            this.vsbDioptrie.Name = "vsbDioptrie";
            this.vsbDioptrie.Size = new System.Drawing.Size(39, 202);
            this.vsbDioptrie.SmallChange = 25;
            this.vsbDioptrie.TabIndex = 2;
            this.vsbDioptrie.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbDioptrie_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dioptrie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vsbDioptrie);
            this.Controls.Add(this.spc);
            this.Controls.Add(this.pbCamera);
            this.MinimumSize = new System.Drawing.Size(509, 459);
            this.Name = "Form1";
            this.Text = "Simulateur de myopie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Timer tmrFrame;
        private gei1076_tools.SerialPortConfigurator spc;
        private System.Windows.Forms.VScrollBar vsbDioptrie;
        private System.Windows.Forms.Label label1;
    }
}

