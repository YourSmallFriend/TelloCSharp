namespace controller
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
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            BtnTurnLeft = new System.Windows.Forms.Button();
            BtnTurnRight = new System.Windows.Forms.Button();
            BtnAchteruit = new System.Windows.Forms.Button();
            BtnVooruit = new System.Windows.Forms.Button();
            BtnFlip = new System.Windows.Forms.Button();
            BtnFlipRight = new System.Windows.Forms.Button();
            BtnFrontFlip = new System.Windows.Forms.Button();
            BtnBackFlip = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            BtnStream = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            BtnOmhoog = new System.Windows.Forms.Button();
            BtnOmlaag = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(31, 28);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(131, 72);
            button1.TabIndex = 0;
            button1.Text = "opstijgen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(168, 28);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(131, 72);
            button2.TabIndex = 1;
            button2.Text = "landen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BtnTurnLeft
            // 
            BtnTurnLeft.Location = new System.Drawing.Point(168, 108);
            BtnTurnLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnTurnLeft.Name = "BtnTurnLeft";
            BtnTurnLeft.Size = new System.Drawing.Size(131, 72);
            BtnTurnLeft.TabIndex = 2;
            BtnTurnLeft.Text = "draai links";
            BtnTurnLeft.UseVisualStyleBackColor = true;
            BtnTurnLeft.Click += BtnTurnLeft_Click;
            // 
            // BtnTurnRight
            // 
            BtnTurnRight.Location = new System.Drawing.Point(442, 108);
            BtnTurnRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnTurnRight.Name = "BtnTurnRight";
            BtnTurnRight.Size = new System.Drawing.Size(131, 72);
            BtnTurnRight.TabIndex = 3;
            BtnTurnRight.Text = "draai rechts";
            BtnTurnRight.UseVisualStyleBackColor = true;
            BtnTurnRight.Click += BtnTurnRight_Click;
            // 
            // BtnAchteruit
            // 
            BtnAchteruit.Location = new System.Drawing.Point(305, 188);
            BtnAchteruit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnAchteruit.Name = "BtnAchteruit";
            BtnAchteruit.Size = new System.Drawing.Size(131, 72);
            BtnAchteruit.TabIndex = 4;
            BtnAchteruit.Text = "achteruit";
            BtnAchteruit.UseVisualStyleBackColor = true;
            BtnAchteruit.Click += BtnAchteruit_Click;
            // 
            // BtnVooruit
            // 
            BtnVooruit.Location = new System.Drawing.Point(305, 108);
            BtnVooruit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnVooruit.Name = "BtnVooruit";
            BtnVooruit.Size = new System.Drawing.Size(131, 72);
            BtnVooruit.TabIndex = 5;
            BtnVooruit.Text = "voor";
            BtnVooruit.UseVisualStyleBackColor = true;
            BtnVooruit.Click += BtnVooruit_Click;
            // 
            // BtnFlip
            // 
            BtnFlip.Location = new System.Drawing.Point(31, 188);
            BtnFlip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnFlip.Name = "BtnFlip";
            BtnFlip.Size = new System.Drawing.Size(131, 72);
            BtnFlip.TabIndex = 6;
            BtnFlip.Text = "Flip left";
            BtnFlip.UseVisualStyleBackColor = true;
            BtnFlip.Click += BtnFlip_Click;
            // 
            // BtnFlipRight
            // 
            BtnFlipRight.Location = new System.Drawing.Point(579, 188);
            BtnFlipRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnFlipRight.Name = "BtnFlipRight";
            BtnFlipRight.Size = new System.Drawing.Size(131, 72);
            BtnFlipRight.TabIndex = 7;
            BtnFlipRight.Text = "Flip right";
            BtnFlipRight.UseVisualStyleBackColor = true;
            BtnFlipRight.Click += BtnFlipRight_Click;
            // 
            // BtnFrontFlip
            // 
            BtnFrontFlip.Location = new System.Drawing.Point(305, 28);
            BtnFrontFlip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnFrontFlip.Name = "BtnFrontFlip";
            BtnFrontFlip.Size = new System.Drawing.Size(131, 72);
            BtnFrontFlip.TabIndex = 8;
            BtnFrontFlip.Text = "FrontFlip";
            BtnFrontFlip.UseVisualStyleBackColor = true;
            BtnFrontFlip.Click += BtnFrontFlip_Click;
            // 
            // BtnBackFlip
            // 
            BtnBackFlip.Location = new System.Drawing.Point(305, 268);
            BtnBackFlip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnBackFlip.Name = "BtnBackFlip";
            BtnBackFlip.Size = new System.Drawing.Size(131, 72);
            BtnBackFlip.TabIndex = 9;
            BtnBackFlip.Text = "BackFlip";
            BtnBackFlip.UseVisualStyleBackColor = true;
            BtnBackFlip.Click += BtnBackFlip_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(168, 188);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(131, 72);
            button3.TabIndex = 10;
            button3.Text = "links";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(442, 188);
            button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(131, 72);
            button4.TabIndex = 11;
            button4.Text = "rechts";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // BtnStream
            // 
            BtnStream.Location = new System.Drawing.Point(442, 28);
            BtnStream.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnStream.Name = "BtnStream";
            BtnStream.Size = new System.Drawing.Size(131, 72);
            BtnStream.TabIndex = 12;
            BtnStream.Text = "Stream";
            BtnStream.UseVisualStyleBackColor = true;
            BtnStream.Click += BtnStream_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 20);
            label1.TabIndex = 13;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // BtnOmhoog
            // 
            BtnOmhoog.Location = new System.Drawing.Point(579, 28);
            BtnOmhoog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnOmhoog.Name = "BtnOmhoog";
            BtnOmhoog.Size = new System.Drawing.Size(131, 72);
            BtnOmhoog.TabIndex = 14;
            BtnOmhoog.Text = "Omhoog";
            BtnOmhoog.UseVisualStyleBackColor = true;
            BtnOmhoog.Click += BtnOmhoog_Click;
            // 
            // BtnOmlaag
            // 
            BtnOmlaag.Location = new System.Drawing.Point(579, 108);
            BtnOmlaag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnOmlaag.Name = "BtnOmlaag";
            BtnOmlaag.Size = new System.Drawing.Size(131, 72);
            BtnOmlaag.TabIndex = 15;
            BtnOmlaag.Text = "Omlaag";
            BtnOmlaag.UseVisualStyleBackColor = true;
            BtnOmlaag.Click += BtnOmlaag_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(732, 562);
            Controls.Add(BtnOmlaag);
            Controls.Add(BtnOmhoog);
            Controls.Add(label1);
            Controls.Add(BtnStream);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(BtnBackFlip);
            Controls.Add(BtnFrontFlip);
            Controls.Add(BtnFlipRight);
            Controls.Add(BtnFlip);
            Controls.Add(BtnVooruit);
            Controls.Add(BtnAchteruit);
            Controls.Add(BtnTurnRight);
            Controls.Add(BtnTurnLeft);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnTurnLeft;
        private System.Windows.Forms.Button BtnTurnRight;
        private System.Windows.Forms.Button BtnAchteruit;
        private System.Windows.Forms.Button BtnVooruit;
        private System.Windows.Forms.Button BtnFlip;
        private System.Windows.Forms.Button BtnFlipRight;
        private System.Windows.Forms.Button BtnFrontFlip;
        private System.Windows.Forms.Button BtnBackFlip;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnStream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnOmhoog;
        private System.Windows.Forms.Button BtnOmlaag;
    }
}

