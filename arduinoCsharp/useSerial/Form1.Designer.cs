
namespace useSerial
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nbCOMNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSerialConnect = new System.Windows.Forms.Button();
            this.btnSerialUnconnect = new System.Windows.Forms.Button();
            this.tbSendingMessage = new System.Windows.Forms.TextBox();
            this.btnSubmitTodo = new System.Windows.Forms.Button();
            this.btnS1 = new System.Windows.Forms.Button();
            this.btnS2 = new System.Windows.Forms.Button();
            this.btnS3 = new System.Windows.Forms.Button();
            this.btnS4 = new System.Windows.Forms.Button();
            this.btnS5 = new System.Windows.Forms.Button();
            this.btnS6 = new System.Windows.Forms.Button();
            this.btnS7 = new System.Windows.Forms.Button();
            this.btnS8 = new System.Windows.Forms.Button();
            this.lbHour1 = new System.Windows.Forms.Label();
            this.lbHour2 = new System.Windows.Forms.Label();
            this.lbMin2 = new System.Windows.Forms.Label();
            this.lbMin1 = new System.Windows.Forms.Label();
            this.lbTimerMin = new System.Windows.Forms.Label();
            this.lbTimerHour = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nbCOMNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM";
            // 
            // nbCOMNumber
            // 
            this.nbCOMNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.nbCOMNumber.ForeColor = System.Drawing.Color.Beige;
            this.nbCOMNumber.Location = new System.Drawing.Point(96, 30);
            this.nbCOMNumber.Name = "nbCOMNumber";
            this.nbCOMNumber.Size = new System.Drawing.Size(59, 21);
            this.nbCOMNumber.TabIndex = 1;
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.BackColor = System.Drawing.Color.Beige;
            this.btnSerialConnect.Location = new System.Drawing.Point(161, 28);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(111, 23);
            this.btnSerialConnect.TabIndex = 2;
            this.btnSerialConnect.Text = "💡CONNECT";
            this.btnSerialConnect.UseVisualStyleBackColor = false;
            this.btnSerialConnect.Click += new System.EventHandler(this.btnSerialConnect_Click);
            // 
            // btnSerialUnconnect
            // 
            this.btnSerialUnconnect.BackColor = System.Drawing.Color.Tan;
            this.btnSerialUnconnect.Location = new System.Drawing.Point(280, 28);
            this.btnSerialUnconnect.Name = "btnSerialUnconnect";
            this.btnSerialUnconnect.Size = new System.Drawing.Size(111, 23);
            this.btnSerialUnconnect.TabIndex = 4;
            this.btnSerialUnconnect.Text = "💡UNCONNECT";
            this.btnSerialUnconnect.UseVisualStyleBackColor = false;
            this.btnSerialUnconnect.Click += new System.EventHandler(this.btnSerialUnconnect_Click);
            // 
            // tbSendingMessage
            // 
            this.tbSendingMessage.Location = new System.Drawing.Point(119, 156);
            this.tbSendingMessage.Name = "tbSendingMessage";
            this.tbSendingMessage.Size = new System.Drawing.Size(184, 21);
            this.tbSendingMessage.TabIndex = 5;
            // 
            // btnSubmitTodo
            // 
            this.btnSubmitTodo.BackColor = System.Drawing.Color.Beige;
            this.btnSubmitTodo.Location = new System.Drawing.Point(307, 154);
            this.btnSubmitTodo.Name = "btnSubmitTodo";
            this.btnSubmitTodo.Size = new System.Drawing.Size(84, 23);
            this.btnSubmitTodo.TabIndex = 6;
            this.btnSubmitTodo.Text = "SUBMIT";
            this.btnSubmitTodo.UseVisualStyleBackColor = false;
            this.btnSubmitTodo.Click += new System.EventHandler(this.btnSubmitTodo_Click);
            // 
            // btnS1
            // 
            this.btnS1.Location = new System.Drawing.Point(41, 400);
            this.btnS1.Name = "btnS1";
            this.btnS1.Size = new System.Drawing.Size(37, 22);
            this.btnS1.TabIndex = 7;
            this.btnS1.Text = "S1";
            this.btnS1.UseVisualStyleBackColor = true;
            this.btnS1.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // btnS2
            // 
            this.btnS2.Location = new System.Drawing.Point(85, 400);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(37, 22);
            this.btnS2.TabIndex = 8;
            this.btnS2.Text = "S2";
            this.btnS2.UseVisualStyleBackColor = true;
            this.btnS2.Click += new System.EventHandler(this.btnS2_Click);
            // 
            // btnS3
            // 
            this.btnS3.Location = new System.Drawing.Point(129, 400);
            this.btnS3.Name = "btnS3";
            this.btnS3.Size = new System.Drawing.Size(37, 22);
            this.btnS3.TabIndex = 9;
            this.btnS3.Text = "S3";
            this.btnS3.UseVisualStyleBackColor = true;
            this.btnS3.Click += new System.EventHandler(this.btnS3_Click);
            // 
            // btnS4
            // 
            this.btnS4.Location = new System.Drawing.Point(173, 400);
            this.btnS4.Name = "btnS4";
            this.btnS4.Size = new System.Drawing.Size(37, 22);
            this.btnS4.TabIndex = 10;
            this.btnS4.Text = "S4";
            this.btnS4.UseVisualStyleBackColor = true;
            this.btnS4.Click += new System.EventHandler(this.btnS4_Click);
            // 
            // btnS5
            // 
            this.btnS5.Location = new System.Drawing.Point(217, 400);
            this.btnS5.Name = "btnS5";
            this.btnS5.Size = new System.Drawing.Size(37, 22);
            this.btnS5.TabIndex = 11;
            this.btnS5.Text = "S5";
            this.btnS5.UseVisualStyleBackColor = true;
            this.btnS5.Click += new System.EventHandler(this.btnS5_Click);
            // 
            // btnS6
            // 
            this.btnS6.Location = new System.Drawing.Point(261, 400);
            this.btnS6.Name = "btnS6";
            this.btnS6.Size = new System.Drawing.Size(37, 22);
            this.btnS6.TabIndex = 12;
            this.btnS6.Text = "S6";
            this.btnS6.UseVisualStyleBackColor = true;
            this.btnS6.Click += new System.EventHandler(this.btnS6_Click);
            // 
            // btnS7
            // 
            this.btnS7.Location = new System.Drawing.Point(305, 400);
            this.btnS7.Name = "btnS7";
            this.btnS7.Size = new System.Drawing.Size(37, 22);
            this.btnS7.TabIndex = 13;
            this.btnS7.Text = "S7";
            this.btnS7.UseVisualStyleBackColor = true;
            this.btnS7.Click += new System.EventHandler(this.btnS7_Click);
            // 
            // btnS8
            // 
            this.btnS8.Location = new System.Drawing.Point(349, 400);
            this.btnS8.Name = "btnS8";
            this.btnS8.Size = new System.Drawing.Size(37, 22);
            this.btnS8.TabIndex = 14;
            this.btnS8.Text = "S8";
            this.btnS8.UseVisualStyleBackColor = true;
            this.btnS8.Click += new System.EventHandler(this.btnS8_Click);
            // 
            // lbHour1
            // 
            this.lbHour1.AutoSize = true;
            this.lbHour1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbHour1.ForeColor = System.Drawing.Color.Salmon;
            this.lbHour1.Location = new System.Drawing.Point(52, 368);
            this.lbHour1.Name = "lbHour1";
            this.lbHour1.Size = new System.Drawing.Size(15, 16);
            this.lbHour1.TabIndex = 15;
            this.lbHour1.Text = "0";
            // 
            // lbHour2
            // 
            this.lbHour2.AutoSize = true;
            this.lbHour2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbHour2.ForeColor = System.Drawing.Color.Salmon;
            this.lbHour2.Location = new System.Drawing.Point(96, 368);
            this.lbHour2.Name = "lbHour2";
            this.lbHour2.Size = new System.Drawing.Size(15, 16);
            this.lbHour2.TabIndex = 16;
            this.lbHour2.Text = "0";
            // 
            // lbMin2
            // 
            this.lbMin2.AutoSize = true;
            this.lbMin2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMin2.ForeColor = System.Drawing.Color.Salmon;
            this.lbMin2.Location = new System.Drawing.Point(184, 368);
            this.lbMin2.Name = "lbMin2";
            this.lbMin2.Size = new System.Drawing.Size(15, 16);
            this.lbMin2.TabIndex = 18;
            this.lbMin2.Text = "0";
            // 
            // lbMin1
            // 
            this.lbMin1.AutoSize = true;
            this.lbMin1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMin1.ForeColor = System.Drawing.Color.Salmon;
            this.lbMin1.Location = new System.Drawing.Point(140, 368);
            this.lbMin1.Name = "lbMin1";
            this.lbMin1.Size = new System.Drawing.Size(15, 16);
            this.lbMin1.TabIndex = 17;
            this.lbMin1.Text = "0";
            // 
            // lbTimerMin
            // 
            this.lbTimerMin.AutoSize = true;
            this.lbTimerMin.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTimerMin.ForeColor = System.Drawing.Color.Salmon;
            this.lbTimerMin.Location = new System.Drawing.Point(272, 368);
            this.lbTimerMin.Name = "lbTimerMin";
            this.lbTimerMin.Size = new System.Drawing.Size(15, 16);
            this.lbTimerMin.TabIndex = 20;
            this.lbTimerMin.Text = "0";
            // 
            // lbTimerHour
            // 
            this.lbTimerHour.AutoSize = true;
            this.lbTimerHour.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTimerHour.ForeColor = System.Drawing.Color.Salmon;
            this.lbTimerHour.Location = new System.Drawing.Point(228, 368);
            this.lbTimerHour.Name = "lbTimerHour";
            this.lbTimerHour.Size = new System.Drawing.Size(15, 16);
            this.lbTimerHour.TabIndex = 19;
            this.lbTimerHour.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(360, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Salmon;
            this.label7.Location = new System.Drawing.Point(316, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(41, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "CLOCK S1~S4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Beige;
            this.label3.Location = new System.Drawing.Point(217, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "TODO S5~S8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Beige;
            this.label4.Location = new System.Drawing.Point(41, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "TODO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Beige;
            this.label5.Location = new System.Drawing.Point(41, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "BUTTON and SEGMENT";
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTime.ForeColor = System.Drawing.Color.Beige;
            this.lbCurrentTime.Location = new System.Drawing.Point(39, 86);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(169, 25);
            this.lbCurrentTime.TabIndex = 27;
            this.lbCurrentTime.Text = "00H 00M 00S";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.Beige;
            this.lbTimer.Location = new System.Drawing.Point(114, 221);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(169, 25);
            this.lbTimer.TabIndex = 28;
            this.lbTimer.Text = "00H 00M 00S";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Beige;
            this.label8.Location = new System.Drawing.Point(41, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "TIMER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbCurrentTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTimerMin);
            this.Controls.Add(this.lbTimerHour);
            this.Controls.Add(this.lbMin2);
            this.Controls.Add(this.lbMin1);
            this.Controls.Add(this.lbHour2);
            this.Controls.Add(this.lbHour1);
            this.Controls.Add(this.btnS8);
            this.Controls.Add(this.btnS7);
            this.Controls.Add(this.btnS6);
            this.Controls.Add(this.btnS5);
            this.Controls.Add(this.btnS4);
            this.Controls.Add(this.btnS3);
            this.Controls.Add(this.btnS2);
            this.Controls.Add(this.btnS1);
            this.Controls.Add(this.btnSubmitTodo);
            this.Controls.Add(this.tbSendingMessage);
            this.Controls.Add(this.btnSerialUnconnect);
            this.Controls.Add(this.btnSerialConnect);
            this.Controls.Add(this.nbCOMNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Serial Example";
            ((System.ComponentModel.ISupportInitialize)(this.nbCOMNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbCOMNumber;
        private System.Windows.Forms.Button btnSerialConnect;
        private System.Windows.Forms.Button btnSerialUnconnect;
        private System.Windows.Forms.TextBox tbSendingMessage;
        private System.Windows.Forms.Button btnSubmitTodo;
        private System.Windows.Forms.Button btnS1;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.Button btnS3;
        private System.Windows.Forms.Button btnS4;
        private System.Windows.Forms.Button btnS5;
        private System.Windows.Forms.Button btnS6;
        private System.Windows.Forms.Button btnS7;
        private System.Windows.Forms.Button btnS8;
        private System.Windows.Forms.Label lbHour1;
        private System.Windows.Forms.Label lbHour2;
        private System.Windows.Forms.Label lbMin2;
        private System.Windows.Forms.Label lbMin1;
        private System.Windows.Forms.Label lbTimerMin;
        private System.Windows.Forms.Label lbTimerHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}

