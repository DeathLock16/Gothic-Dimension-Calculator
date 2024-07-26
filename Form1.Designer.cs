
namespace Gothic_Pixels_Virtuals
{
    partial class Gothic_DimCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.Value = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.ResolutionCBox = new System.Windows.Forms.ComboBox();
            this.Resolution = new System.Windows.Forms.Label();
            this.PixelsX = new System.Windows.Forms.TextBox();
            this.Pixels = new System.Windows.Forms.Label();
            this.PixelsY = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.VirtualsX = new System.Windows.Forms.TextBox();
            this.Virtuals = new System.Windows.Forms.Label();
            this.VirtualsY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ValueNumeric
            // 
            this.ValueNumeric.BackColor = System.Drawing.Color.MistyRose;
            this.ValueNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueNumeric.Location = new System.Drawing.Point(12, 56);
            this.ValueNumeric.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.ValueNumeric.Name = "ValueNumeric";
            this.ValueNumeric.Size = new System.Drawing.Size(94, 23);
            this.ValueNumeric.TabIndex = 0;
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Location = new System.Drawing.Point(12, 82);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(94, 15);
            this.Value.TabIndex = 1;
            this.Value.Text = "Insert your value";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Aquamarine;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Location = new System.Drawing.Point(155, 25);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 41);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ResolutionCBox
            // 
            this.ResolutionCBox.BackColor = System.Drawing.Color.MistyRose;
            this.ResolutionCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionCBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResolutionCBox.FormattingEnabled = true;
            this.ResolutionCBox.Items.AddRange(new object[] {
            "640x360",
            "640x480",
            "800x600",
            "1024x768",
            "1280x720",
            "1280x800",
            "1280x1024",
            "1360x768",
            "1366x768",
            "1440x900",
            "1536x864",
            "1600x900",
            "1600x1200",
            "1680x1050",
            "1920x1080",
            "1920x1200",
            "2048x1152",
            "2048x1536",
            "2560x1080",
            "2560x1440",
            "2560x1600",
            "3440x1440",
            "3840x2160"});
            this.ResolutionCBox.Location = new System.Drawing.Point(12, 12);
            this.ResolutionCBox.Name = "ResolutionCBox";
            this.ResolutionCBox.Size = new System.Drawing.Size(121, 23);
            this.ResolutionCBox.TabIndex = 3;
            // 
            // Resolution
            // 
            this.Resolution.AutoSize = true;
            this.Resolution.Location = new System.Drawing.Point(12, 38);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(121, 15);
            this.Resolution.TabIndex = 4;
            this.Resolution.Text = "Select your resolution";
            // 
            // PixelsX
            // 
            this.PixelsX.BackColor = System.Drawing.Color.Thistle;
            this.PixelsX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PixelsX.Location = new System.Drawing.Point(267, 27);
            this.PixelsX.Name = "PixelsX";
            this.PixelsX.ReadOnly = true;
            this.PixelsX.Size = new System.Drawing.Size(37, 23);
            this.PixelsX.TabIndex = 5;
            // 
            // Pixels
            // 
            this.Pixels.AutoSize = true;
            this.Pixels.Location = new System.Drawing.Point(267, 9);
            this.Pixels.Name = "Pixels";
            this.Pixels.Size = new System.Drawing.Size(37, 15);
            this.Pixels.TabIndex = 6;
            this.Pixels.Text = "Pixels";
            // 
            // PixelsY
            // 
            this.PixelsY.BackColor = System.Drawing.Color.Thistle;
            this.PixelsY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PixelsY.Location = new System.Drawing.Point(267, 56);
            this.PixelsY.Name = "PixelsY";
            this.PixelsY.ReadOnly = true;
            this.PixelsY.Size = new System.Drawing.Size(37, 23);
            this.PixelsY.TabIndex = 7;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(244, 29);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(17, 15);
            this.X.TabIndex = 8;
            this.X.Text = "X:";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(244, 58);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(17, 15);
            this.Y.TabIndex = 9;
            this.Y.Text = "Y:";
            // 
            // VirtualsX
            // 
            this.VirtualsX.BackColor = System.Drawing.Color.Moccasin;
            this.VirtualsX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VirtualsX.Location = new System.Drawing.Point(332, 27);
            this.VirtualsX.Name = "VirtualsX";
            this.VirtualsX.ReadOnly = true;
            this.VirtualsX.Size = new System.Drawing.Size(37, 23);
            this.VirtualsX.TabIndex = 10;
            // 
            // Virtuals
            // 
            this.Virtuals.AutoSize = true;
            this.Virtuals.Location = new System.Drawing.Point(328, 9);
            this.Virtuals.Name = "Virtuals";
            this.Virtuals.Size = new System.Drawing.Size(46, 15);
            this.Virtuals.TabIndex = 11;
            this.Virtuals.Text = "Virtuals";
            // 
            // VirtualsY
            // 
            this.VirtualsY.BackColor = System.Drawing.Color.Moccasin;
            this.VirtualsY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VirtualsY.Location = new System.Drawing.Point(332, 56);
            this.VirtualsY.Name = "VirtualsY";
            this.VirtualsY.ReadOnly = true;
            this.VirtualsY.Size = new System.Drawing.Size(37, 23);
            this.VirtualsY.TabIndex = 12;
            // 
            // Gothic_DimCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 103);
            this.Controls.Add(this.VirtualsY);
            this.Controls.Add(this.Virtuals);
            this.Controls.Add(this.VirtualsX);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.PixelsY);
            this.Controls.Add(this.Pixels);
            this.Controls.Add(this.PixelsX);
            this.Controls.Add(this.Resolution);
            this.Controls.Add(this.ResolutionCBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.ValueNumeric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gothic_DimCalc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gothic - Dimension Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ValueNumeric;
        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox ResolutionCBox;
        private System.Windows.Forms.Label Resolution;
        private System.Windows.Forms.TextBox PixelsX;
        private System.Windows.Forms.Label Pixels;
        private System.Windows.Forms.TextBox PixelsY;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.TextBox VirtualsX;
        private System.Windows.Forms.Label Virtuals;
        private System.Windows.Forms.TextBox VirtualsY;
    }
}

