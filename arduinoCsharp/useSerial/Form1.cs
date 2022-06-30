using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace useSerial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        /// serial 통신 connect 버튼
        /// </summary>
        private void btnSerialConnect_Click(object sender, EventArgs e)
        {
            // connect 버튼 누르면 시리얼 통신 라인 생성
            // string port = "COM" + nbCOMNumber.Value;

            serialPort1.PortName = "COM" + nbCOMNumber.Value; // 입력한 포트 넘버로 포트 설정

            // 사용자가 버튼을 연속적으로 누를 경우를 대비해 예외처리 필요
            if (serialPort1.IsOpen)
            {
                // 추가적인 동작을 하지 않음
            }
            else serialPort1.Open(); // 통신 라인 생성
        }

        /// <summary>
        /// serial 통신 unconnect 버튼
        /// </summary>
        private void btnSerialUnconnect_Click(object sender, EventArgs e)
        {
            // unconnect 버튼 클릭 시 시리얼 통신 끊김
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        /// <summary>
        /// 아두이노로부터 데이터 받기 -> 시간 출력
        /// </summary>
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int arduinoClock = int.Parse(Regex.Replace(serialPort1.ReadLine(), @"[^a-zA-Z0-9가-힣]", "", RegexOptions.Singleline));
                int Hour = (arduinoClock / 3600) % 24 + int.Parse(lbHour1.Text + lbHour2.Text);
                int Minute = (arduinoClock / 60) % 60 + int.Parse(lbMin1.Text + lbMin2.Text);
                int Second = arduinoClock % 60;
                lbCurrentTime.Text = Hour.ToString() + "H " + Minute.ToString() + "M " + Second.ToString() + "S";
            }
        }


        /// <summary>
        /// TODO submit 버튼 -> 아두이노로 todo를 보냄
        /// </summary>
        private void btnSubmitTodo_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(tbSendingMessage.Text);
            }
        }



        /*
         S1~S4 시간 조작 버튼 동작 & 모니터링
         시간, 분 조작만 구현함 (초 단위 조작은 불필요)
         */
        //int SecSeg = int.Parse(lbSec1.Text + lbSec2.Text;
        /// <summary>
        /// S1 버튼 조작 -> 시간 증가 (1시간씩)
        /// 증가된 시간만 세그먼트로 확인
        /// </summary>
        private void btnS1_Click(object sender, EventArgs e)
        {
            int HourSeg = int.Parse(lbHour1.Text + lbHour2.Text);
            HourSeg += 1;
            if (HourSeg >= 24)
            {
                HourSeg = 0;
            }
            lbHour1.Text = (HourSeg / 10).ToString();
            lbHour2.Text = (HourSeg % 10).ToString();

        }

        /// <summary>
        /// S2 버튼 조작 -> 시간 감소 (1시간씩)
        /// </summary
        private void btnS2_Click(object sender, EventArgs e)
        {
            int HourSeg = int.Parse(lbHour1.Text + lbHour2.Text);
            HourSeg -= 1;
            if (HourSeg <= 0)
            {
                HourSeg = 0;
            }
            lbHour1.Text = (HourSeg / 10).ToString();
            lbHour2.Text = (HourSeg % 10).ToString();
        }

        /// <summary>
        /// S3 버튼 조작 -> 분 증가(1분씩)
        /// </summary>
        private void btnS3_Click(object sender, EventArgs e)
        {
            int MinuteSeg = int.Parse(lbMin1.Text + lbMin2.Text);
            MinuteSeg += 1;
            if (MinuteSeg >= 60)
            {
                MinuteSeg = 0;
            }
            lbMin1.Text = ((MinuteSeg) / 10).ToString();
            lbMin2.Text = (MinuteSeg % 10).ToString();
        }

        /// <summary>
        /// S4 버튼 조작 -> 분 감소(1분씩)
        /// </summary>
        private void btnS4_Click(object sender, EventArgs e)
        {
            int MinuteSeg = int.Parse(lbMin1.Text + lbMin2.Text);
            MinuteSeg -= 1;
            if (MinuteSeg <= 0)
            {
                MinuteSeg = 0;
            }
            lbMin1.Text = (MinuteSeg / 10).ToString();
            lbMin2.Text = (MinuteSeg % 10).ToString();
        }


        private int todoTimer = 0;
        /// <summary>
        /// 타이머 시간 증가 -> 1시간 단위, 24를 넘어가면 0으로
        /// </summary>
        private void btnS5_Click(object sender, EventArgs e)
        {
            int timerHour = int.Parse(lbTimerHour.Text);
            timerHour += 1;
            if (timerHour >= 10)
            {
                timerHour = 0;
            }

            lbTimerHour.Text = timerHour.ToString();

            todoTimer += timerHour * 3600;

            // lbTimer.Text = lbTimerHour.Text + "H" + lbTimerMin.Text + "M";
        }

        /// <summary>
        /// 타이머 분 증가 -> 30분 단위 -> 60분을 넘어가면 0으로
        /// </summary>
        private void btnS6_Click(object sender, EventArgs e)
        {
            int timerMin = int.Parse(lbTimerMin.Text);
            timerMin += 30;
            if (timerMin >= 60)
            {
                timerMin = 0;
            }

            lbTimerMin.Text = timerMin.ToString();

            todoTimer += timerMin * 60;

            // lbTimer.Text = lbTimerHour.Text + "H" + lbTimerMin.Text + "M";
        }


        
        /// <summary>
        /// 타이머 시작
        /// </summary>
        private void btnS7_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            timer1.Start();
        }

        /// <summary>
        /// 타이머 일시정지
        /// </summary>
        private void btnS8_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void count_down(object sender, EventArgs e)
        {
            int hour = (todoTimer / 3600) % 24;
            int min = (todoTimer / 60) % 60;
            int sec = todoTimer % 60;

            if (todoTimer == 0)
            {
                timer1.Stop();
            }
            else if (todoTimer > 0)
            {
                todoTimer--;
                lbTimer.Text = hour.ToString() + "H " + min.ToString() + "M " + sec.ToString() + "S";
            }
        }

        
    }
}
