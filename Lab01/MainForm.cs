using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Lab01
{
    public partial class MainForm : Form
    {
        private List<Student> _list;

        public MainForm()
        {
            InitializeComponent();
            _list = new List<Student>();
        }

        private void loadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"students.txt");
                // StLastName, StFirstName, Grade, Classroom, Bus, TLastName, TFirstName
                // COOKUS,XUAN ,3 ,107,52,FAFARD,ROCIO
                foreach (string line in lines)
                {
                    string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    //richTextBox1.Text += line + Environment.NewLine;

                    Student student = new Student()
                    {
                        StLastName = data[0],
                        StFirstName = data[1],
                        Grade = int.Parse(data[2]),
                        Classroom = int.Parse(data[3]),
                        Bus = int.Parse(data[4]),
                        TLastName = data[5],
                        TFirstName = data[6]
                    };
                    _list.Add(student);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            statusStrip1.Items[1].Text = _list.Count.ToString();
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //класс Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера

            foreach (var item in _list)
            {
                var stSurname = tb1Surname.Text.Trim();
                if (item.StLastName == stSurname)
                {
                    rtbResult.Text += item.ToStringStudentClassTeacher();
                }
                if (stopwatch.Elapsed.TotalMinutes >= 2) //возврат общего затраченного времени
                {
                    //достигнуто 2 минут - всплывает окно с сообщением
                    MessageBox.Show("Час очікування перевищив 2 хв.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }

            }
            stopwatch.Stop(); //остановка таймер

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //объект Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера

            foreach (var item in _list)
            {
                var stSurname = tb2Surname.Text.Trim();
                if (item.StLastName == stSurname)
                {
                    rtbResult.Text += item.ToStringStudentBus();
                }
                if (stopwatch.Elapsed.TotalMinutes >= 2)
                {
                    //достигнуто 2 минут - всплывает окно с сообщением
                    MessageBox.Show("Час очікування перевищив 2 хв.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            stopwatch.Stop(); //остановка таймер

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //объект Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера
            int count = 0;

            var tSurname = tb3Surname.Text.Trim();
            var tName = tbName.Text.Trim();

            foreach (var item in _list)
            {

                if (item.TLastName == tSurname && item.TFirstName == tName)
                {
                    count++;
                    rtbResult.Text += count + " ";
                    rtbResult.Text += item.ToStringTeacherStudents();
                }
                if (stopwatch.Elapsed.TotalMinutes >= 2)
                {
                    //достигнуто 2 минут - всплывает окно с сообщением
                    MessageBox.Show("Час очікування перевищив 2 хв.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            stopwatch.Stop(); //остановка таймер

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void task4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //объект Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера
            int count = 0;

            foreach (var item in _list)
            {
                int stBus = Convert.ToInt32(tbNumberBus.Text.Trim());
                if (item.Bus == stBus)
                {
                    count++;
                    rtbResult.Text += count + " ";
                    rtbResult.Text += item.ToStringBusStudent();
                }
                if (stopwatch.Elapsed.TotalMinutes >= 2)
                {
                    //достигнуто 2 минут - всплывает окно с сообщением
                    MessageBox.Show("Час очікування перевищив 2 хв.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            stopwatch.Stop(); //остановка таймер

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void task5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //объект Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера
            int count = 0;

            foreach (var item in _list)
            {
                int stGrade = Convert.ToInt32(tbNumberGrade.Text.Trim());
                if (item.Grade == stGrade)
                {
                    count++;
                    rtbResult.Text += count + " ";
                    rtbResult.Text += item.ToStringStudentGrade();
                }
                if (stopwatch.Elapsed.TotalMinutes >= 2)
                {
                    //достигнуто 2 минут - всплывает окно с сообщением
                    MessageBox.Show("Час очікування перевищив 2 хв.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            stopwatch.Stop(); //остановка таймер

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}