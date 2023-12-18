namespace ModernDgitalClock
{
    partial class DgitalClock
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.clcokTimer = new System.Windows.Forms.Timer(this.components);
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.indigoButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.dBlueButton = new System.Windows.Forms.Button();
            this.styleButton = new System.Windows.Forms.Button();
            this.styleButton2 = new System.Windows.Forms.Button();
            this.styleButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ClockLabel
            // 
            this.ClockLabel.Font = new System.Drawing.Font("Myanmar Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.ForeColor = System.Drawing.Color.Red;
            this.ClockLabel.Location = new System.Drawing.Point(4, 0);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(1050, 570);
            this.ClockLabel.TabIndex = 1;
            this.ClockLabel.Text = "Loading....";
            this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClockLabel.Click += new System.EventHandler(this.ClockLabel_Click);
            // 
            // clcokTimer
            // 
            this.clcokTimer.Interval = 1000;
            this.clcokTimer.Tick += new System.EventHandler(this.clcokTimer_Tick);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(12, 593);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(33, 34);
            this.redButton.TabIndex = 2;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.greenButton.Location = new System.Drawing.Point(66, 593);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(33, 34);
            this.greenButton.TabIndex = 3;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // indigoButton
            // 
            this.indigoButton.BackColor = System.Drawing.Color.Indigo;
            this.indigoButton.Location = new System.Drawing.Point(123, 593);
            this.indigoButton.Name = "indigoButton";
            this.indigoButton.Size = new System.Drawing.Size(33, 34);
            this.indigoButton.TabIndex = 4;
            this.indigoButton.UseVisualStyleBackColor = false;
            this.indigoButton.Click += new System.EventHandler(this.indigoButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(180, 593);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(33, 34);
            this.yellowButton.TabIndex = 5;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // dBlueButton
            // 
            this.dBlueButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.dBlueButton.Location = new System.Drawing.Point(234, 593);
            this.dBlueButton.Name = "dBlueButton";
            this.dBlueButton.Size = new System.Drawing.Size(33, 34);
            this.dBlueButton.TabIndex = 6;
            this.dBlueButton.UseVisualStyleBackColor = false;
            this.dBlueButton.Click += new System.EventHandler(this.dBlueButton_Click);
            // 
            // styleButton
            // 
            this.styleButton.BackColor = System.Drawing.Color.White;
            this.styleButton.Font = new System.Drawing.Font("Impact", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.styleButton.Location = new System.Drawing.Point(298, 593);
            this.styleButton.Name = "styleButton";
            this.styleButton.Size = new System.Drawing.Size(75, 34);
            this.styleButton.TabIndex = 7;
            this.styleButton.Text = "Style 1";
            this.styleButton.UseVisualStyleBackColor = false;
            this.styleButton.Click += new System.EventHandler(this.styleButton_Click);
            // 
            // styleButton2
            // 
            this.styleButton2.BackColor = System.Drawing.Color.White;
            this.styleButton2.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton2.Location = new System.Drawing.Point(403, 593);
            this.styleButton2.Name = "styleButton2";
            this.styleButton2.Size = new System.Drawing.Size(75, 34);
            this.styleButton2.TabIndex = 8;
            this.styleButton2.Text = "Style 2";
            this.styleButton2.UseVisualStyleBackColor = false;
            this.styleButton2.Click += new System.EventHandler(this.styleButton2_Click);
            // 
            // styleButton3
            // 
            this.styleButton3.BackColor = System.Drawing.Color.White;
            this.styleButton3.Font = new System.Drawing.Font("Rockwell", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton3.Location = new System.Drawing.Point(507, 593);
            this.styleButton3.Name = "styleButton3";
            this.styleButton3.Size = new System.Drawing.Size(75, 34);
            this.styleButton3.TabIndex = 9;
            this.styleButton3.Text = "Style 3";
            this.styleButton3.UseVisualStyleBackColor = false;
            this.styleButton3.Click += new System.EventHandler(this.styleButton3_Click);
            // 
            // DgitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1057, 639);
            this.Controls.Add(this.styleButton3);
            this.Controls.Add(this.styleButton2);
            this.Controls.Add(this.styleButton);
            this.Controls.Add(this.dBlueButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.indigoButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.label1);
            this.Name = "DgitalClock";
            this.Text = "Dgital Clock";
            this.Load += new System.EventHandler(this.DgitalClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Timer clcokTimer;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button indigoButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button dBlueButton;
        private System.Windows.Forms.Button styleButton;
        private System.Windows.Forms.Button styleButton2;
        private System.Windows.Forms.Button styleButton3;
    }
}

