namespace TimerAndRandom
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.RedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GreenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BlueTextBox = new System.Windows.Forms.TextBox();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.RunTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // RedTextBox
            // 
            this.RedTextBox.Enabled = false;
            this.RedTextBox.Location = new System.Drawing.Point(48, 6);
            this.RedTextBox.Name = "RedTextBox";
            this.RedTextBox.ReadOnly = true;
            this.RedTextBox.Size = new System.Drawing.Size(100, 23);
            this.RedTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green:";
            // 
            // GreenTextBox
            // 
            this.GreenTextBox.Enabled = false;
            this.GreenTextBox.Location = new System.Drawing.Point(201, 6);
            this.GreenTextBox.Name = "GreenTextBox";
            this.GreenTextBox.ReadOnly = true;
            this.GreenTextBox.Size = new System.Drawing.Size(100, 23);
            this.GreenTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue:";
            // 
            // BlueTextBox
            // 
            this.BlueTextBox.Enabled = false;
            this.BlueTextBox.Location = new System.Drawing.Point(346, 6);
            this.BlueTextBox.Name = "BlueTextBox";
            this.BlueTextBox.ReadOnly = true;
            this.BlueTextBox.Size = new System.Drawing.Size(100, 23);
            this.BlueTextBox.TabIndex = 4;
            // 
            // ColorPanel
            // 
            this.ColorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorPanel.Location = new System.Drawing.Point(12, 35);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(776, 403);
            this.ColorPanel.TabIndex = 6;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(452, 5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RunTimer
            // 
            this.RunTimer.Interval = 1000;
            this.RunTimer.Tick += new System.EventHandler(this.RunTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BlueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GreenTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RedTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox RedTextBox;
        private Label label1;
        private Label label2;
        private TextBox GreenTextBox;
        private Label label3;
        private TextBox BlueTextBox;
        private Panel ColorPanel;
        private Button StartButton;
        private System.Windows.Forms.Timer RunTimer;
    }
}