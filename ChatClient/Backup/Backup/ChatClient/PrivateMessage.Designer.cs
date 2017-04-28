namespace ChatClient
{
    partial class PrivateMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivateMessage));
            this.btnSend = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.rtbWriteMsg = new System.Windows.Forms.RichTextBox();
            this.btnEmotion = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn19 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSad = new System.Windows.Forms.Button();
            this.btnSmile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(361, 233);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(55, 37);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtbMessage
            // 
            this.rtbMessage.BackColor = System.Drawing.SystemColors.Window;
            this.rtbMessage.Location = new System.Drawing.Point(2, 2);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMessage.Size = new System.Drawing.Size(413, 204);
            this.rtbMessage.TabIndex = 4;
            this.rtbMessage.Text = "";
            // 
            // rtbWriteMsg
            // 
            this.rtbWriteMsg.Location = new System.Drawing.Point(2, 233);
            this.rtbWriteMsg.Multiline = false;
            this.rtbWriteMsg.Name = "rtbWriteMsg";
            this.rtbWriteMsg.Size = new System.Drawing.Size(357, 34);
            this.rtbWriteMsg.TabIndex = 5;
            this.rtbWriteMsg.Text = "";
            this.rtbWriteMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbWriteMsg_KeyPress);
            // 
            // btnEmotion
            // 
            this.btnEmotion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmotion.BackgroundImage")));
            this.btnEmotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmotion.Location = new System.Drawing.Point(2, 209);
            this.btnEmotion.Name = "btnEmotion";
            this.btnEmotion.Size = new System.Drawing.Size(21, 21);
            this.btnEmotion.TabIndex = 6;
            this.btnEmotion.UseVisualStyleBackColor = true;
            this.btnEmotion.Click += new System.EventHandler(this.btnEmotion_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColor.BackgroundImage")));
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(27, 209);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(21, 21);
            this.btnColor.TabIndex = 7;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFont.BackgroundImage")));
            this.btnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Location = new System.Drawing.Point(52, 209);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(21, 21);
            this.btnFont.TabIndex = 8;
            this.btnFont.Text = "button3";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btn21);
            this.panel1.Controls.Add(this.btn20);
            this.panel1.Controls.Add(this.btn19);
            this.panel1.Controls.Add(this.btn18);
            this.panel1.Controls.Add(this.btn17);
            this.panel1.Controls.Add(this.btn16);
            this.panel1.Controls.Add(this.btn15);
            this.panel1.Controls.Add(this.btn14);
            this.panel1.Controls.Add(this.btn13);
            this.panel1.Controls.Add(this.btn12);
            this.panel1.Controls.Add(this.btn11);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btnSad);
            this.panel1.Controls.Add(this.btnSmile);
            this.panel1.Location = new System.Drawing.Point(10, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 91);
            this.panel1.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(111, 67);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 21);
            this.btnClose.TabIndex = 32;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn21
            // 
            this.btn21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn21.BackgroundImage")));
            this.btn21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Location = new System.Drawing.Point(45, 67);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(21, 21);
            this.btn21.TabIndex = 31;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btn21_Click);
            // 
            // btn20
            // 
            this.btn20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn20.BackgroundImage")));
            this.btn20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Location = new System.Drawing.Point(23, 67);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(21, 21);
            this.btn20.TabIndex = 30;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn19
            // 
            this.btn19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn19.BackgroundImage")));
            this.btn19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn19.Location = new System.Drawing.Point(1, 67);
            this.btn19.Name = "btn19";
            this.btn19.Size = new System.Drawing.Size(21, 21);
            this.btn19.TabIndex = 29;
            this.btn19.UseVisualStyleBackColor = true;
            this.btn19.Click += new System.EventHandler(this.btn19_Click);
            // 
            // btn18
            // 
            this.btn18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn18.BackgroundImage")));
            this.btn18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn18.Location = new System.Drawing.Point(111, 45);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(21, 21);
            this.btn18.TabIndex = 28;
            this.btn18.UseVisualStyleBackColor = true;
            this.btn18.Click += new System.EventHandler(this.btn18_Click);
            // 
            // btn17
            // 
            this.btn17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn17.BackgroundImage")));
            this.btn17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn17.Location = new System.Drawing.Point(89, 45);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(21, 21);
            this.btn17.TabIndex = 27;
            this.btn17.UseVisualStyleBackColor = true;
            this.btn17.Click += new System.EventHandler(this.btn17_Click);
            // 
            // btn16
            // 
            this.btn16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn16.BackgroundImage")));
            this.btn16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn16.Location = new System.Drawing.Point(67, 45);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(21, 21);
            this.btn16.TabIndex = 26;
            this.btn16.UseVisualStyleBackColor = true;
            this.btn16.Click += new System.EventHandler(this.btn16_Click);
            // 
            // btn15
            // 
            this.btn15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn15.BackgroundImage")));
            this.btn15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn15.Location = new System.Drawing.Point(45, 45);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(21, 21);
            this.btn15.TabIndex = 25;
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn14
            // 
            this.btn14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn14.BackgroundImage")));
            this.btn14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn14.Location = new System.Drawing.Point(23, 45);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(21, 21);
            this.btn14.TabIndex = 24;
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Click += new System.EventHandler(this.btn14_Click);
            // 
            // btn13
            // 
            this.btn13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn13.BackgroundImage")));
            this.btn13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Location = new System.Drawing.Point(1, 45);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(21, 21);
            this.btn13.TabIndex = 23;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btn13_Click);
            // 
            // btn12
            // 
            this.btn12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn12.BackgroundImage")));
            this.btn12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Location = new System.Drawing.Point(111, 23);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(21, 21);
            this.btn12.TabIndex = 22;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn11
            // 
            this.btn11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn11.BackgroundImage")));
            this.btn11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Location = new System.Drawing.Point(89, 23);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(21, 21);
            this.btn11.TabIndex = 21;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn10
            // 
            this.btn10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn10.BackgroundImage")));
            this.btn10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Location = new System.Drawing.Point(67, 23);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(21, 21);
            this.btn10.TabIndex = 20;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn9
            // 
            this.btn9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn9.BackgroundImage")));
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(45, 23);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(21, 21);
            this.btn9.TabIndex = 19;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn8.BackgroundImage")));
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(23, 23);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(21, 21);
            this.btn8.TabIndex = 18;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn7.BackgroundImage")));
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(1, 23);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(21, 21);
            this.btn7.TabIndex = 17;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn6.BackgroundImage")));
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(111, 1);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(21, 21);
            this.btn6.TabIndex = 16;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5.BackgroundImage")));
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(89, 1);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(21, 21);
            this.btn5.TabIndex = 15;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4.BackgroundImage")));
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(67, 1);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(21, 21);
            this.btn4.TabIndex = 14;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(45, 1);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(21, 21);
            this.btn3.TabIndex = 13;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnSad
            // 
            this.btnSad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSad.BackgroundImage")));
            this.btnSad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSad.Location = new System.Drawing.Point(23, 1);
            this.btnSad.Name = "btnSad";
            this.btnSad.Size = new System.Drawing.Size(21, 21);
            this.btnSad.TabIndex = 12;
            this.btnSad.UseVisualStyleBackColor = true;
            this.btnSad.Click += new System.EventHandler(this.btnSad_Click);
            // 
            // btnSmile
            // 
            this.btnSmile.BackColor = System.Drawing.SystemColors.Control;
            this.btnSmile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSmile.BackgroundImage")));
            this.btnSmile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSmile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmile.Location = new System.Drawing.Point(1, 1);
            this.btnSmile.Name = "btnSmile";
            this.btnSmile.Size = new System.Drawing.Size(21, 21);
            this.btnSmile.TabIndex = 11;
            this.btnSmile.UseVisualStyleBackColor = false;
            this.btnSmile.Click += new System.EventHandler(this.btnSmile_Click);
            // 
            // PrivateMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnEmotion);
            this.Controls.Add(this.rtbWriteMsg);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrivateMessage";
            this.Text = "Private Message";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrivateMessage_FormClosing);
            this.Load += new System.EventHandler(this.PrivateMessage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.RichTextBox rtbWriteMsg;
        private System.Windows.Forms.Button btnEmotion;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSad;
        private System.Windows.Forms.Button btnSmile;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn18;
        private System.Windows.Forms.Button btn17;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn19;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btnClose;
    }
}