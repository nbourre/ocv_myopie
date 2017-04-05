namespace ocv_myopie
{
    partial class frmMain
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
            this.tmrReception = new System.Windows.Forms.Timer(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSnellen = new System.Windows.Forms.TabPage();
            this.pbSnellen = new System.Windows.Forms.PictureBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vsbDioptrie = new System.Windows.Forms.VScrollBar();
            this.txtDioptrie = new System.Windows.Forms.TextBox();
            this.tabView = new System.Windows.Forms.TabPage();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDpiY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDpiX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHauteur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLargeur = new System.Windows.Forms.TextBox();
            this.chkNoCamera = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabSnellen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnellen)).BeginInit();
            this.tabView.SuspendLayout();
            this.tabConfiguration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCamera
            // 
            this.pbCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCamera.Location = new System.Drawing.Point(3, 6);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(640, 480);
            this.pbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            // tmrReception
            // 
            this.tmrReception.Interval = 10;
            this.tmrReception.Tick += new System.EventHandler(this.tmrReception_Tick);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabSnellen);
            this.tabMain.Controls.Add(this.tabView);
            this.tabMain.Controls.Add(this.tabConfiguration);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(729, 527);
            this.tabMain.TabIndex = 6;
            // 
            // tabSnellen
            // 
            this.tabSnellen.Controls.Add(this.pbSnellen);
            this.tabSnellen.Controls.Add(this.lblDistance);
            this.tabSnellen.Controls.Add(this.label1);
            this.tabSnellen.Controls.Add(this.label2);
            this.tabSnellen.Controls.Add(this.vsbDioptrie);
            this.tabSnellen.Controls.Add(this.txtDioptrie);
            this.tabSnellen.Location = new System.Drawing.Point(4, 22);
            this.tabSnellen.Name = "tabSnellen";
            this.tabSnellen.Size = new System.Drawing.Size(721, 501);
            this.tabSnellen.TabIndex = 2;
            this.tabSnellen.Text = "Snellen";
            this.tabSnellen.UseVisualStyleBackColor = true;
            // 
            // pbSnellen
            // 
            this.pbSnellen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSnellen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSnellen.Location = new System.Drawing.Point(4, 4);
            this.pbSnellen.Name = "pbSnellen";
            this.pbSnellen.Size = new System.Drawing.Size(644, 491);
            this.pbSnellen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSnellen.TabIndex = 11;
            this.pbSnellen.TabStop = false;
            // 
            // lblDistance
            // 
            this.lblDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(683, 337);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(30, 13);
            this.lblDistance.TabIndex = 9;
            this.lblDistance.Text = "0 cm";
            this.lblDistance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dioptrie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Distance :";
            // 
            // vsbDioptrie
            // 
            this.vsbDioptrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vsbDioptrie.LargeChange = 100;
            this.vsbDioptrie.Location = new System.Drawing.Point(683, 66);
            this.vsbDioptrie.Maximum = 1000;
            this.vsbDioptrie.Name = "vsbDioptrie";
            this.vsbDioptrie.Size = new System.Drawing.Size(26, 207);
            this.vsbDioptrie.SmallChange = 25;
            this.vsbDioptrie.TabIndex = 6;
            // 
            // txtDioptrie
            // 
            this.txtDioptrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDioptrie.Location = new System.Drawing.Point(674, 33);
            this.txtDioptrie.Name = "txtDioptrie";
            this.txtDioptrie.Size = new System.Drawing.Size(44, 20);
            this.txtDioptrie.TabIndex = 8;
            this.txtDioptrie.Text = "0";
            this.txtDioptrie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDioptrie.TextChanged += new System.EventHandler(this.txtDioptrie_TextChanged);
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.pbCamera);
            this.tabView.Location = new System.Drawing.Point(4, 22);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(721, 501);
            this.tabView.TabIndex = 0;
            this.tabView.Text = "Caméra";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.chkNoCamera);
            this.tabConfiguration.Controls.Add(this.groupBox1);
            this.tabConfiguration.Controls.Add(this.spc);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguration.Size = new System.Drawing.Size(721, 501);
            this.tabConfiguration.TabIndex = 1;
            this.tabConfiguration.Text = "Configuration";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtHauteur);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLargeur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDpiY);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDpiX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtResY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtResX);
            this.groupBox1.Location = new System.Drawing.Point(17, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information d\'affichage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "DPI Y :";
            // 
            // txtDpiY
            // 
            this.txtDpiY.Location = new System.Drawing.Point(228, 48);
            this.txtDpiY.Name = "txtDpiY";
            this.txtDpiY.Size = new System.Drawing.Size(100, 20);
            this.txtDpiY.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DPI X :";
            // 
            // txtDpiX
            // 
            this.txtDpiX.Location = new System.Drawing.Point(228, 22);
            this.txtDpiX.Name = "txtDpiX";
            this.txtDpiX.Size = new System.Drawing.Size(100, 20);
            this.txtDpiX.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rés. Y :";
            // 
            // txtResY
            // 
            this.txtResY.Location = new System.Drawing.Point(62, 48);
            this.txtResY.Name = "txtResY";
            this.txtResY.Size = new System.Drawing.Size(100, 20);
            this.txtResY.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rés. X :";
            // 
            // txtResX
            // 
            this.txtResX.Location = new System.Drawing.Point(62, 22);
            this.txtResX.Name = "txtResX";
            this.txtResX.Size = new System.Drawing.Size(100, 20);
            this.txtResX.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hauteur :";
            // 
            // txtHauteur
            // 
            this.txtHauteur.Location = new System.Drawing.Point(62, 100);
            this.txtHauteur.Name = "txtHauteur";
            this.txtHauteur.Size = new System.Drawing.Size(100, 20);
            this.txtHauteur.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Largeur :";
            // 
            // txtLargeur
            // 
            this.txtLargeur.Location = new System.Drawing.Point(62, 74);
            this.txtLargeur.Name = "txtLargeur";
            this.txtLargeur.Size = new System.Drawing.Size(100, 20);
            this.txtLargeur.TabIndex = 8;
            // 
            // chkNoCamera
            // 
            this.chkNoCamera.AutoSize = true;
            this.chkNoCamera.Checked = true;
            this.chkNoCamera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNoCamera.Location = new System.Drawing.Point(368, 129);
            this.chkNoCamera.Name = "chkNoCamera";
            this.chkNoCamera.Size = new System.Drawing.Size(115, 17);
            this.chkNoCamera.TabIndex = 3;
            this.chkNoCamera.Text = "Désactiver caméra";
            this.chkNoCamera.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 541);
            this.Controls.Add(this.tabMain);
            this.MinimumSize = new System.Drawing.Size(770, 580);
            this.Name = "frmMain";
            this.Text = "Simulateur de myopie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabSnellen.ResumeLayout(false);
            this.tabSnellen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnellen)).EndInit();
            this.tabView.ResumeLayout(false);
            this.tabConfiguration.ResumeLayout(false);
            this.tabConfiguration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Timer tmrFrame;
        private gei1076_tools.SerialPortConfigurator spc;
        private System.Windows.Forms.Timer tmrReception;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.TabPage tabSnellen;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar vsbDioptrie;
        private System.Windows.Forms.TextBox txtDioptrie;
        private System.Windows.Forms.PictureBox pbSnellen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDpiY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDpiX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHauteur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLargeur;
        private System.Windows.Forms.CheckBox chkNoCamera;
    }
}

