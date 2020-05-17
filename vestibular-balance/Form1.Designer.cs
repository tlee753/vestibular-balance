namespace vestibular_balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.infoPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.softPanel = new System.Windows.Forms.Panel();
            this.softLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.hardPanel = new System.Windows.Forms.Panel();
            this.initButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.hardLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.reportPlot = new System.Windows.Forms.Panel();
            this.reportCenter = new System.Windows.Forms.PictureBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.reportLabel = new System.Windows.Forms.Label();
            this.infoPanel.SuspendLayout();
            this.softPanel.SuspendLayout();
            this.hardPanel.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.reportPlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BackColor = System.Drawing.Color.Black;
            this.infoPanel.Controls.Add(this.infoLabel);
            this.infoPanel.Location = new System.Drawing.Point(12, 12);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1020, 60);
            this.infoPanel.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.infoLabel.Location = new System.Drawing.Point(6, 6);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(6);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(1008, 48);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "label1";
            // 
            // softPanel
            // 
            this.softPanel.BackColor = System.Drawing.Color.Black;
            this.softPanel.Controls.Add(this.softLabel);
            this.softPanel.Controls.Add(this.connectButton);
            this.softPanel.Controls.Add(this.disconnectButton);
            this.softPanel.Location = new System.Drawing.Point(12, 84);
            this.softPanel.Name = "softPanel";
            this.softPanel.Size = new System.Drawing.Size(360, 280);
            this.softPanel.TabIndex = 1;
            // 
            // softLabel
            // 
            this.softLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.softLabel.BackColor = System.Drawing.Color.Transparent;
            this.softLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.softLabel.Location = new System.Drawing.Point(6, 6);
            this.softLabel.Margin = new System.Windows.Forms.Padding(6);
            this.softLabel.Name = "softLabel";
            this.softLabel.Size = new System.Drawing.Size(348, 136);
            this.softLabel.TabIndex = 10;
            this.softLabel.Text = "label2";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Teal;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.Color.MistyRose;
            this.connectButton.Location = new System.Drawing.Point(6, 148);
            this.connectButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(348, 60);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.Crimson;
            this.disconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.ForeColor = System.Drawing.Color.MistyRose;
            this.disconnectButton.Location = new System.Drawing.Point(6, 214);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(348, 60);
            this.disconnectButton.TabIndex = 7;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // hardPanel
            // 
            this.hardPanel.BackColor = System.Drawing.Color.Black;
            this.hardPanel.Controls.Add(this.initButton);
            this.hardPanel.Controls.Add(this.removeButton);
            this.hardPanel.Controls.Add(this.hardLabel);
            this.hardPanel.Location = new System.Drawing.Point(12, 376);
            this.hardPanel.Name = "hardPanel";
            this.hardPanel.Size = new System.Drawing.Size(360, 280);
            this.hardPanel.TabIndex = 2;
            // 
            // initButton
            // 
            this.initButton.BackColor = System.Drawing.Color.Teal;
            this.initButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initButton.ForeColor = System.Drawing.Color.MistyRose;
            this.initButton.Location = new System.Drawing.Point(6, 148);
            this.initButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(348, 60);
            this.initButton.TabIndex = 12;
            this.initButton.Text = "Initialize";
            this.initButton.UseVisualStyleBackColor = false;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Crimson;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.MistyRose;
            this.removeButton.Location = new System.Drawing.Point(6, 214);
            this.removeButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(348, 60);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // hardLabel
            // 
            this.hardLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hardLabel.BackColor = System.Drawing.Color.Transparent;
            this.hardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.hardLabel.Location = new System.Drawing.Point(6, 6);
            this.hardLabel.Margin = new System.Windows.Forms.Padding(6);
            this.hardLabel.Name = "hardLabel";
            this.hardLabel.Size = new System.Drawing.Size(348, 136);
            this.hardLabel.TabIndex = 11;
            this.hardLabel.Text = "label3";
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.BackColor = System.Drawing.Color.Crimson;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.MistyRose;
            this.helpButton.Location = new System.Drawing.Point(1043, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(129, 60);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // reportPanel
            // 
            this.reportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportPanel.BackColor = System.Drawing.Color.Black;
            this.reportPanel.Controls.Add(this.reportPlot);
            this.reportPanel.Controls.Add(this.reportButton);
            this.reportPanel.Controls.Add(this.reportLabel);
            this.reportPanel.Location = new System.Drawing.Point(384, 84);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(788, 572);
            this.reportPanel.TabIndex = 3;
            // 
            // reportPlot
            // 
            this.reportPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportPlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportPlot.BackgroundImage")));
            this.reportPlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportPlot.Controls.Add(this.reportCenter);
            this.reportPlot.Location = new System.Drawing.Point(6, 72);
            this.reportPlot.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.reportPlot.Name = "reportPlot";
            this.reportPlot.Size = new System.Drawing.Size(776, 494);
            this.reportPlot.TabIndex = 16;
            // 
            // reportCenter
            // 
            this.reportCenter.BackColor = System.Drawing.Color.Crimson;
            this.reportCenter.Location = new System.Drawing.Point(378, 237);
            this.reportCenter.Name = "reportCenter";
            this.reportCenter.Size = new System.Drawing.Size(20, 20);
            this.reportCenter.TabIndex = 15;
            this.reportCenter.TabStop = false;
            // 
            // reportButton
            // 
            this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportButton.BackColor = System.Drawing.Color.Teal;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.Color.MistyRose;
            this.reportButton.Location = new System.Drawing.Point(434, 6);
            this.reportButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(348, 60);
            this.reportButton.TabIndex = 13;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // reportLabel
            // 
            this.reportLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportLabel.BackColor = System.Drawing.Color.Transparent;
            this.reportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.reportLabel.Location = new System.Drawing.Point(6, 6);
            this.reportLabel.Margin = new System.Windows.Forms.Padding(6);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(421, 60);
            this.reportLabel.TabIndex = 13;
            this.reportLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 667);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.hardPanel);
            this.Controls.Add(this.softPanel);
            this.Controls.Add(this.infoPanel);
            this.Name = "Form1";
            this.Text = "Vestibular Balance";
            this.infoPanel.ResumeLayout(false);
            this.softPanel.ResumeLayout(false);
            this.hardPanel.ResumeLayout(false);
            this.reportPanel.ResumeLayout(false);
            this.reportPlot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel softPanel;
        private System.Windows.Forms.Panel hardPanel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label softLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label hardLabel;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Panel reportPlot;
        private System.Windows.Forms.PictureBox reportCenter;
    }
}

