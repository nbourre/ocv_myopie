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
            this.txtDioptrie = new System.Windows.Forms.TextBox();
            this.tmrReception = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(3, 6);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(640, 480);
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
            this.spc.Location = new System.Drawing.Point(6, 6);
            this.spc.Name = "spc";
            this.spc.Size = new System.Drawing.Size(707, 93);
            this.spc.TabIndex = 1;
            // 
            // vsbDioptrie
            // 
            this.vsbDioptrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vsbDioptrie.LargeChange = 100;
            this.vsbDioptrie.Location = new System.Drawing.Point(680, 58);
            this.vsbDioptrie.Maximum = 1000;
            this.vsbDioptrie.Name = "vsbDioptrie";
            this.vsbDioptrie.Size = new System.Drawing.Size(26, 207);
            this.vsbDioptrie.SmallChange = 25;
            this.vsbDioptrie.TabIndex = 2;
            this.vsbDioptrie.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbDioptrie_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dioptrie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDioptrie
            // 
            this.txtDioptrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDioptrie.Location = new System.Drawing.Point(671, 25);
            this.txtDioptrie.Name = "txtDioptrie";
            this.txtDioptrie.Size = new System.Drawing.Size(44, 20);
            this.txtDioptrie.TabIndex = 4;
            this.txtDioptrie.Text = "0";
            this.txtDioptrie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrReception
            // 
            this.tmrReception.Interval = 10;
            this.tmrReception.Tick += new System.EventHandler(this.tmrReception_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Distance :";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(680, 329);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(30, 13);
            this.lblDistance.TabIndex = 5;
            this.lblDistance.Text = "0 cm";
            this.lblDistance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabView);
            this.tabMain.Controls.Add(this.tabConfiguration);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(729, 527);
            this.tabMain.TabIndex = 6;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.pbCamera);
            this.tabView.Controls.Add(this.lblDistance);
            this.tabView.Controls.Add(this.label1);
            this.tabView.Controls.Add(this.label2);
            this.tabView.Controls.Add(this.vsbDioptrie);
            this.tabView.Controls.Add(this.txtDioptrie);
            this.tabView.Location = new System.Drawing.Point(4, 22);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(721, 501);
            this.tabView.TabIndex = 0;
            this.tabView.Text = "Vision";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.spc);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguration.Size = new System.Drawing.Size(721, 501);
            this.tabConfiguration.TabIndex = 1;
            this.tabConfiguration.Text = "Configuration";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 541);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(770, 580);
            this.Name = "Form1";
            this.Text = "Simulateur de myopie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabView.PerformLayout();
            this.tabConfiguration.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Timer tmrFrame;
        private gei1076_tools.SerialPortConfigurator spc;
        private System.Windows.Forms.VScrollBar vsbDioptrie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDioptrie;
        private System.Windows.Forms.Timer tmrReception;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabConfiguration;
    }
}

