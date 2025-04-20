using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DLCN_DEMO
{
    public partial class Form1: Form
    {
        private SerialPort serialPort1;
        private Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphPane mypane = zedGraphControl1.GraphPane;
            mypane.Title.Text = "Temperature Graph";
            mypane.YAxis.Title.Text = "Value";
            mypane.XAxis.Title.Text = "Time";
            RollingPointPairList list1 = new RollingPointPairList(60000);
            LineItem line1 = mypane.AddCurve("Temperature", list1, Color.Red);
            mypane.XAxis.Scale.Min = 0;
            mypane.XAxis.Scale.Max = 100;
            mypane.XAxis.Scale.MinorStep = 1;
            mypane.XAxis.Scale.MajorStep = 5;
            mypane.YAxis.Scale.Min = 0;
            mypane.YAxis.Scale.Max = 100;
            mypane.YAxis.Scale.MinorStep = 1;
            mypane.YAxis.Scale.MajorStep = 5;
            zedGraphControl1.AxisChange();

            string[] myport = SerialPort.GetPortNames();

        }
        double sum = 0;
        public void Draw(double line1) // Gọi hàm này để vẽ
        {
            LineItem curveline1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            if (curveline1 == null)
                return;
            IPointListEdit list1 = curveline1.Points as IPointListEdit;
            if (list1 == null)
                return;
            list1.Add(sum, line1);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            sum += 0.5;
        }


        private void btnOPEN_Click(object sender, EventArgs e)
        {
            string selectedPort = comboBoxCOM.SelectedItem.ToString();
            string selectedBaud = comboBoxBaud.SelectedItem.ToString();
            serialPort = new SerialPort(selectedPort, int.Parse(selectedBaud));
            serialPort.Open();
            serialPort.DataReceived += SerialPort_DataReceived;
            stopwatch = new Stopwatch();
            MessageBox.Show("COM: " + selectedPort + " BaudRate: " + selectedBaud);
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string receivedData = serialPort.ReadExisting();
                // Tìm vị trí bắt đầu và kết thúc của giá trị nhiệt độ trong chuỗi nhận được
                int startIdx = receivedData.IndexOf("Nhiet do: ") + "Nhiet do: ".Length;
                int endIdx = receivedData.IndexOf("; a:");
                // tách giá trị nhiệt độ từ chuỗi
                string temperatureString = receivedData.Substring(startIdx, endIdx - startIdx);
                float temperature = float.Parse(temperatureString);

                
                if (!string.IsNullOrEmpty(receivedData))
                {
                    Invoke(new Action(() =>{textBOX.Text =  receivedData;}));
                    Invoke(new MethodInvoker(() => Draw(temperature)));
                }
                else
                {
                    Invoke(new Action(() =>{textBOX.Text = "Invalid data received!";}));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    textBOX.Text = "Error: " + ex.Message;
                }));
            }
        }


        private void btnREAD_Click(object sender, EventArgs e)
        {
            byte[] buffer = { 0x02 };
            serialPort.Write(buffer, 0, buffer.Length);
            stopwatch.Restart();
            MessageBox.Show("Dữ liệu đã được gửi.");
        }

        private void btnSET_Click(object sender, EventArgs e)
        {
            //Lấy gia trị từ textbox
            float in_a = float.Parse(txta.Text);
            float in_b = float.Parse(txtb.Text);
            // convert float to byte
            byte[] byteArray_a = BitConverter.GetBytes(in_a);
            byte[] byteArray_b = BitConverter.GetBytes(in_b);
            byte[] buffer_send = { 0x03, byteArray_a[0], byteArray_a[1], byteArray_a[2], byteArray_a[3], byteArray_b[0], byteArray_b[1], byteArray_b[2], byteArray_b[3] };
            serialPort.Write(buffer_send, 0, buffer_send.Length);
            stopwatch.Restart();
            MessageBox.Show("Dữ liệu đã được gửi.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            if (MessageBox.Show("Do you want to exit ?", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
