using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Calc
{
    public partial class Message : Form
    {
        float a, b;
        int count;
        public Message()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.Anchor = AnchorStyles.Left;
            //// задаем комбинацию значений
            //button1.Anchor = AnchorStyles.Left | AnchorStyles.Top;
        }

        private void Button1_Click(object sender, EventArgs e)  // "/"
        {
            a = float.Parse(textbox.Text);
            textbox.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
        }
        
        private void Value_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e) // "."
        {
            textbox.Text = textbox.Text + ",";
        }

        private void Button4_Click(object sender, EventArgs e) // "0"
        {
            textbox.Text = textbox.Text + 0;
        }
        private void Button4_KeyDown(object sender, KeyEventArgs e) // "0"
        {
            if (e.KeyCode.Equals(Keys.D0)) button4.PerformClick();
        }
            ////////////
        private void Button8_Click(object sender, EventArgs e) // "1"
        {
            textbox.Text = textbox.Text + 1;
        }
        private void Button8_KeyDown(object sender, KeyEventArgs e) // "1"
        {
            if (e.KeyCode.Equals(Keys.D1)) button8.PerformClick();
        }
            /////////
        private void Button7_Click(object sender, EventArgs e) // "2"
        {
            textbox.Text = textbox.Text + 2;
        }
        private void Button7_KeyDown(object sender, KeyEventArgs e) // "2"
        {
            if (e.KeyCode.Equals(Keys.D2)) button7.PerformClick();
        }
            ////////////
        private void Button6_Click(object sender, EventArgs e) // "3"
        {
            textbox.Text = textbox.Text + 3;
        }
        private void Button6_KeyDown(object sender, KeyEventArgs e) // "3"
        {
            if (e.KeyCode.Equals(Keys.D3)) button6.PerformClick();
        }
            ////////////
        private void Button12_Click(object sender, EventArgs e)// "4"
        {
            textbox.Text = textbox.Text + 4;
        }
        private void Button12_KeyDown(object sender, KeyEventArgs e) // "4"
        {
            if (e.KeyCode.Equals(Keys.D4)) button12.PerformClick();
        }
            ////////////
        private void Button11_Click(object sender, EventArgs e) // "5"
        {
            textbox.Text = textbox.Text + 5;
        }
        private void Button11_KeyDown(object sender, KeyEventArgs e) // "5"
        {
            if (e.KeyCode.Equals(Keys.D5)) button11.PerformClick();
        }
            ////////////
        private void Button10_Click(object sender, EventArgs e)// "6"
        {
            textbox.Text = textbox.Text + 6;
        }
        private void Button10_KeyDown(object sender, KeyEventArgs e) // "6"
        {
            if (e.KeyCode.Equals(Keys.D6)) button10.PerformClick();
        }
            ////////////
        private void Button16_Click(object sender, EventArgs e)// "7"
        {
            textbox.Text = textbox.Text + 7;
        }
        private void Button16_KeyDown(object sender, KeyEventArgs e) // "7"
        {
            if (e.KeyCode.Equals(Keys.D7)) button16.PerformClick();
        }
            ////////////
        private void Button15_Click(object sender, EventArgs e)// "8"
        {
            textbox.Text = textbox.Text + 8;
        }
        private void Button15_KeyDown(object sender, KeyEventArgs e) // "8"
        {
            if (e.KeyCode.Equals(Keys.D8)) button15.PerformClick();
        }
            ////////////
        private void Button14_Click(object sender, EventArgs e) // "9"
        {
            textbox.Text = textbox.Text + 9;
        }
        private void Button14_KeyDown(object sender, KeyEventArgs e) // "9"
        {
            if (e.KeyCode.Equals(Keys.D9)) button14.PerformClick();
        }
            ////////////
        private void Button9_Click(object sender, EventArgs e) // "-"
        {
            a = float.Parse(textbox.Text);
            textbox.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
        }

        private void Button2_Click(object sender, EventArgs e)// "*"
        {
            a = float.Parse(textbox.Text);
            textbox.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
        }
        private void Calc() {
            {
                switch (count)
                {
                    case 1:  //+
                        b = a + float.Parse(textbox.Text);
                        textbox.Text = b.ToString();
                        break;
                    case 2:  //-
                        b = a - float.Parse(textbox.Text);
                        textbox.Text = b.ToString();
                        break;
                    case 3: //*
                        b = a * float.Parse(textbox.Text);
                        textbox.Text = b.ToString();
                        break;
                    case 4: //  /
                        b = a / float.Parse(textbox.Text);
                        textbox.Text = b.ToString();
                        break;

                    default:
                        break;
                }

            }
        }

        private void Button17_Click(object sender, EventArgs e) // "="
        {
            Calc();
            label1.Text = "";
            ////Если в буфере обмен содержится текст
            //if (Clipboard.ContainsText() == true)
            //{
            //    //Извлекаем (точнее копируем) его и сохраняем в переменную
            //    string someText = Clipboard.GetText();

            //    //Выводим показываем сообщение с текстом, скопированным из буфера обмена
            //    MessageBox.Show(this, someText, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //else
            //{
            //    //Выводим сообщение о том, что в буфере обмена нет текста
            //    MessageBox.Show(this, "В буфере обмена нет текста", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            ////Помещаем нужный нам текст в буфер обмена (обратите внимание, перед размещением нового текста, содержимое буфера обмена удаляется из него)
            //Clipboard.SetText("Текст из программы");
        }


        private void Button5_Click(object sender, EventArgs e)   // "CE"
        {
            textbox.Text = "";
            label1.Text = "";
        }

        private void Button13_Click(object sender, EventArgs e) // "+"
        {
            a = float.Parse(textbox.Text);//число, которое введёт пользователь перед тем, как нажать кнопку “+”
            textbox.Clear();//TextBox очищается, число, введённое пользователем, в нём пропадает (но остаётся в переменной a)
            count = 1;//Label записывается число из переменной a  u +
            label1.Text = a.ToString() + "+";
        }
    }
}
