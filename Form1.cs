using System.Windows.Forms;

namespace MDK01._04.PR6
{
    public partial class Form1 : Form
    {
        private TimeSpan timeLeft; // Переменная для отслеживания оставшегося времени
        private bool isTimerRunning = false; // Флаг для отслеживания состояния таймера
        public Form1()
        {
            InitializeComponent();
        }

        // Метод обработки события Click кнопки Start/Stop
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (isTimerRunning) // Если таймер уже запущен, останавливаем его
            {
                timer1.Stop();
                isTimerRunning = false;
                btnStartStop.Text ="00:00:00"; // Меняем текст кнопки;
            }
            else // Если таймер не запущен, запускаем его
            {
                // Получаем введенное пользователем время из TextBox и конвертируем его в TimeSpan
                if (TimeSpan.TryParse(txtTime.Text, out timeLeft))
                {
                    timer1.Start();
                    isTimerRunning = true;
                    btnStartStop.Text = "Стоп"; // Меняем текст кнопки на "Stop"

                }
                else
                {
                    MessageBox.Show("Введите корректное время в формате hh:mm: ss");
                }
            }
        }

        // Метод обработки события Tick таймера
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
                btnStartStop.Text = "Start"; // Меняем текст кнопки на Start
                MessageBox.Show(" Время истекло!");
            }
        }

    }
}
