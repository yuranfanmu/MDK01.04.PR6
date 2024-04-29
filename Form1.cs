using System.Windows.Forms;

namespace MDK01._04.PR6
{
    public partial class Form1 : Form
    {
        private TimeSpan timeLeft; // ���������� ��� ������������ ����������� �������
        private bool isTimerRunning = false; // ���� ��� ������������ ��������� �������
        public Form1()
        {
            InitializeComponent();
        }

        // ����� ��������� ������� Click ������ Start/Stop
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (isTimerRunning) // ���� ������ ��� �������, ������������� ���
            {
                timer1.Stop();
                isTimerRunning = false;
                btnStartStop.Text ="00:00:00"; // ������ ����� ������;
            }
            else // ���� ������ �� �������, ��������� ���
            {
                // �������� ��������� ������������� ����� �� TextBox � ������������ ��� � TimeSpan
                if (TimeSpan.TryParse(txtTime.Text, out timeLeft))
                {
                    timer1.Start();
                    isTimerRunning = true;
                    btnStartStop.Text = "����"; // ������ ����� ������ �� "Stop"

                }
                else
                {
                    MessageBox.Show("������� ���������� ����� � ������� hh:mm: ss");
                }
            }
        }

        // ����� ��������� ������� Tick �������
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft.TotalSeconds > 0)
            {
                timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
                lblTimer.Text = timeLeft.ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer1.Stop();
                isTimerRunning = false;
                btnStartStop.Text = "Start"; // ������ ����� ������ �� Start
                MessageBox.Show(" ����� �������!");
            }
        }

    }
}
