namespace Program_6___Painter
{
    partial class painterForm
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
            this.canvas = new System.Windows.Forms.Panel();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.customButton = new System.Windows.Forms.Button();
            this.whiteRadButton = new System.Windows.Forms.RadioButton();
            this.blueRadButton = new System.Windows.Forms.RadioButton();
            this.greenRadButton = new System.Windows.Forms.RadioButton();
            this.redRadButton = new System.Windows.Forms.RadioButton();
            this.blackRadButton = new System.Windows.Forms.RadioButton();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.largeRadButton = new System.Windows.Forms.RadioButton();
            this.mediumRadButton = new System.Windows.Forms.RadioButton();
            this.smallRadButton = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.colorGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.Location = new System.Drawing.Point(218, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(752, 629);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.customButton);
            this.colorGroupBox.Controls.Add(this.whiteRadButton);
            this.colorGroupBox.Controls.Add(this.blueRadButton);
            this.colorGroupBox.Controls.Add(this.greenRadButton);
            this.colorGroupBox.Controls.Add(this.redRadButton);
            this.colorGroupBox.Controls.Add(this.blackRadButton);
            this.colorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorGroupBox.ForeColor = System.Drawing.Color.White;
            this.colorGroupBox.Location = new System.Drawing.Point(12, 12);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(200, 250);
            this.colorGroupBox.TabIndex = 1;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color:";
            // 
            // customButton
            // 
            this.customButton.BackColor = System.Drawing.Color.LightGray;
            this.customButton.ForeColor = System.Drawing.Color.Black;
            this.customButton.Location = new System.Drawing.Point(97, 206);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(97, 38);
            this.customButton.TabIndex = 5;
            this.customButton.Text = "Custom";
            this.customButton.UseVisualStyleBackColor = false;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // whiteRadButton
            // 
            this.whiteRadButton.AutoSize = true;
            this.whiteRadButton.Location = new System.Drawing.Point(21, 157);
            this.whiteRadButton.Name = "whiteRadButton";
            this.whiteRadButton.Size = new System.Drawing.Size(86, 24);
            this.whiteRadButton.TabIndex = 4;
            this.whiteRadButton.TabStop = true;
            this.whiteRadButton.Text = "Eraser";
            this.whiteRadButton.UseVisualStyleBackColor = true;
            this.whiteRadButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // blueRadButton
            // 
            this.blueRadButton.AutoSize = true;
            this.blueRadButton.Location = new System.Drawing.Point(21, 127);
            this.blueRadButton.Name = "blueRadButton";
            this.blueRadButton.Size = new System.Drawing.Size(68, 24);
            this.blueRadButton.TabIndex = 3;
            this.blueRadButton.TabStop = true;
            this.blueRadButton.Text = "Blue";
            this.blueRadButton.UseVisualStyleBackColor = true;
            this.blueRadButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // greenRadButton
            // 
            this.greenRadButton.AutoSize = true;
            this.greenRadButton.Location = new System.Drawing.Point(21, 97);
            this.greenRadButton.Name = "greenRadButton";
            this.greenRadButton.Size = new System.Drawing.Size(81, 24);
            this.greenRadButton.TabIndex = 2;
            this.greenRadButton.TabStop = true;
            this.greenRadButton.Text = "Green";
            this.greenRadButton.UseVisualStyleBackColor = true;
            this.greenRadButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // redRadButton
            // 
            this.redRadButton.AutoSize = true;
            this.redRadButton.Location = new System.Drawing.Point(21, 67);
            this.redRadButton.Name = "redRadButton";
            this.redRadButton.Size = new System.Drawing.Size(63, 24);
            this.redRadButton.TabIndex = 1;
            this.redRadButton.TabStop = true;
            this.redRadButton.Text = "Red";
            this.redRadButton.UseVisualStyleBackColor = true;
            this.redRadButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // blackRadButton
            // 
            this.blackRadButton.AutoSize = true;
            this.blackRadButton.Checked = true;
            this.blackRadButton.Location = new System.Drawing.Point(21, 37);
            this.blackRadButton.Name = "blackRadButton";
            this.blackRadButton.Size = new System.Drawing.Size(77, 24);
            this.blackRadButton.TabIndex = 0;
            this.blackRadButton.TabStop = true;
            this.blackRadButton.Text = "Black";
            this.blackRadButton.UseVisualStyleBackColor = true;
            this.blackRadButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.largeRadButton);
            this.sizeGroupBox.Controls.Add(this.mediumRadButton);
            this.sizeGroupBox.Controls.Add(this.smallRadButton);
            this.sizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeGroupBox.ForeColor = System.Drawing.Color.White;
            this.sizeGroupBox.Location = new System.Drawing.Point(12, 322);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(200, 149);
            this.sizeGroupBox.TabIndex = 2;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size:";
            // 
            // largeRadButton
            // 
            this.largeRadButton.AutoSize = true;
            this.largeRadButton.Location = new System.Drawing.Point(21, 96);
            this.largeRadButton.Name = "largeRadButton";
            this.largeRadButton.Size = new System.Drawing.Size(78, 24);
            this.largeRadButton.TabIndex = 3;
            this.largeRadButton.TabStop = true;
            this.largeRadButton.Text = "Large";
            this.largeRadButton.UseVisualStyleBackColor = true;
            this.largeRadButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // mediumRadButton
            // 
            this.mediumRadButton.AutoSize = true;
            this.mediumRadButton.Location = new System.Drawing.Point(21, 66);
            this.mediumRadButton.Name = "mediumRadButton";
            this.mediumRadButton.Size = new System.Drawing.Size(95, 24);
            this.mediumRadButton.TabIndex = 2;
            this.mediumRadButton.TabStop = true;
            this.mediumRadButton.Text = "Medium";
            this.mediumRadButton.UseVisualStyleBackColor = true;
            this.mediumRadButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // smallRadButton
            // 
            this.smallRadButton.AutoSize = true;
            this.smallRadButton.Checked = true;
            this.smallRadButton.Location = new System.Drawing.Point(21, 36);
            this.smallRadButton.Name = "smallRadButton";
            this.smallRadButton.Size = new System.Drawing.Size(77, 24);
            this.smallRadButton.TabIndex = 1;
            this.smallRadButton.TabStop = true;
            this.smallRadButton.Text = "Small";
            this.smallRadButton.UseVisualStyleBackColor = true;
            this.smallRadButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(43, 524);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(127, 45);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // painterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.colorGroupBox);
            this.Controls.Add(this.canvas);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "painterForm";
            this.Text = "Painter";
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.RadioButton whiteRadButton;
        private System.Windows.Forms.RadioButton blueRadButton;
        private System.Windows.Forms.RadioButton greenRadButton;
        private System.Windows.Forms.RadioButton redRadButton;
        private System.Windows.Forms.RadioButton blackRadButton;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.RadioButton largeRadButton;
        private System.Windows.Forms.RadioButton mediumRadButton;
        private System.Windows.Forms.RadioButton smallRadButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button customButton;
    }
}

