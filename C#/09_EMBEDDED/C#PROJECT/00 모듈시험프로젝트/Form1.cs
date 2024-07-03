﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODULE_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void connection_btn_Click(object sender, EventArgs e) 
        // "connection_btn" 버튼을 클릭했을 때 호출되는 메서드
        {
            Console.Write(this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString() + " CONN\r\n");
            // 콘솔에 comboBox에서 선택한 항목과 "CONN"을 출력

            this.textBox1.Text = this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString() + " CONN";
            // textBox의 텍스트를 comboBox에서 선택한 항목과 "CONN"으로 설정
        }

        private void button1_Click(object sender, EventArgs e)
        // "button1"을 클릭했을 때 호출되는 메서드
        {
            Console.Write("LED_01 ON CLICKED\r\n");
            // 콘솔에 "LED_01 ON CLICKED"를 출력

            this.textBox1.Text = "LED_01 ON SUCCESS";
            // textBox의 텍스트를 "LED_01 ON SUCCESS"로 설정
        }

        private void button2_Click(object sender, EventArgs e)
        // "button2"를 클릭했을 때 호출되는 메서드
        {
            Console.Write("LED_01 OFF CLICKED\r\n");
            // 콘솔에 "LED_01 OFF CLICKED"를 출력

            this.textBox1.Text = "LED_01 OFF SUCCESS";
            // textBox의 텍스트를 "LED_01 OFF SUCCESS"로 설정
        }

        private void button3_Click(object sender, EventArgs e)
        // "button3"을 클릭했을 때 호출되는 메서드
        {
            Console.Write("LED_02 ON CLICKED\r\n");
            // 콘솔에 "LED_02 ON CLICKED"를 출력

            this.textBox1.Text = "LED_02 ON SUCCESS";
            // textBox의 텍스트를 "LED_02 ON SUCCESS"로 설정
        }

        private void button4_Click(object sender, EventArgs e)
        // "button4"를 클릭했을 때 호출되는 메서드
        {
            Console.Write("LED_02 OFF CLICKED\r\n");
            // 콘솔에 "LED_02 OFF CLICKED"를 출력

            this.textBox1.Text = "LED_02 OFF SUCCESS";
            // textBox의 텍스트를 "LED_02 OFF SUCCESS"로 설정
        }
    }
}
