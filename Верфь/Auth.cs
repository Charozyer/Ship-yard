using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Верфь
{
    public partial class Auth : Form
    {
        Model1 db = new Model1();
        byte count = 3;   // счетчик для количества попыток
        int seconds = 15;   // переменная для определения оставшегося времени до разблокировки
        int timesaver = 20;
        public Auth()
        {
            InitializeComponent();
        }
        public static Users USER { get; set; }
        public static string UserLogin { get; set; }
        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") { label4.Text = "Введите логин и пароль"; return; }
            Users usr = db.Users.Find(textBox1.Text);
            {
                if ((usr != null) && (usr.Pass == textBox2.Text))
                {
                    if (usr.RoleId == 1)
                    {
                    USER = usr;
                    label4.Text = " ";
                    Menu frm = new Menu();
                    frm.Show();
                    this.Hide();
                    UserLogin = textBox1.Text;
                    }
                    else
                    {
                        MessageBox.Show("На данном этапе разработки для входа в программу требуется пользователь с ролью администратора. \nПожалуйста, войдите в учетную запись с данными администратора");
                        return;
                    }

                }
                else
                {
                    count -= 1;
                    label4.Text = "Неправильный логин или пароль" + "\n" + "Попыток осталось: " + count;
                    textBox2.Text = "";
                    if (count < 1)
                    {
                        timesaver += 20;
                        textBox1.Text = "";
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        AuthButton.Enabled = false;
                        block.Enabled = true;  // включаем счетчик, считает 1мин и выключает себя и секундный таймер
                        sec.Enabled = true;    // секундный таймер. отсчитывает каждую секунду
                    }
                }
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            byte count = 3;
            label4.Text = "";

        }
        private void block_Tick(object sender, EventArgs e)  // таймер на 1 мин для включения и выключения блокировки
        {
            sec.Enabled = false;      // отключает секундный таймер
            label4.Text = "";    // очищает поле ошибки
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            AuthButton.Enabled = true;  // разблокирывает поля и кнопку
            count = 3;  // востанавливает кол-во попыток
            seconds = timesaver;
            block.Interval += 20000;// востанавливает кол-во времени до разблокировки (на будущее)
            block.Enabled = false;  // выключает секундный таймер 
        }

        private void sec_Tick(object sender, EventArgs e)
        {
            seconds -= 1;   // от переменной отнимаем 1 каждый раз как срабатывает счетчик
            label4.Text = "     Превышен лимит попыток." +
                     "\n" + "Пароль был сброшен" + "\n" + "До разблокировки осталось " + seconds + " сек";
            // выводим сообщение об ошибке(блокировки) со значением оставшегося времени
        }
    }
}
