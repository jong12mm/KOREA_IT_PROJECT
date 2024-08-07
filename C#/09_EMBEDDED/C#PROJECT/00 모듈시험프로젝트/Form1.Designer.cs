﻿using System.Reflection;                                                // Reflection을 사용하기 위한 네임스페이스

namespace MODULE_PROJECT
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;     // 컴포넌트 변수 선언

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();                                   // 컴포넌트 해제
            }
            base.Dispose(disposing);                                    // 부모 클래스의 Dispose 메서드 호출
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            // 컨트롤 초기화 코드

            this.comboBox1 = new System.Windows.Forms.ComboBox();       // 콤보박스 초기화
            this.connection_btn = new System.Windows.Forms.Button();    // 버튼 초기화
            this.label1 = new System.Windows.Forms.Label();             // 레이블 초기화
            this.button1 = new System.Windows.Forms.Button();           // 버튼 초기화
            this.button2 = new System.Windows.Forms.Button();           // 버튼 초기화
            this.button3 = new System.Windows.Forms.Button();           // 버튼 초기화
            this.button4 = new System.Windows.Forms.Button();           // 버튼 초기화
            this.textBox1 = new System.Windows.Forms.TextBox();         // 텍스트 상자 초기화

            this.SuspendLayout();                                       // 레이아웃 변경 시작

            
            // comboBox1
            this.comboBox1.FormattingEnabled = true;                    // 콤보박스 속성 설정
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});                                                   // 콤보박스에 아이템 추가

            this.comboBox1.Location = new System.Drawing.Point(16, 33); // 위치 설정
            this.comboBox1.Name = "comboBox1";                          // 이름 설정
            this.comboBox1.Size = new System.Drawing.Size(167, 32);     // 크기 설정
            this.comboBox1.TabIndex = 1;                                // 탭 인덱스 설정
            this.comboBox1.SelectedIndex = 0;                           // 초기 선택 인덱스 설정

            
            // connection_btn
            this.connection_btn.Location = new System.Drawing.Point(209, 33);   // 위치 설정
            this.connection_btn.Name = "connection_btn";                        // 이름 설정
            this.connection_btn.Size = new System.Drawing.Size(167, 47);        // 크기 설정
            this.connection_btn.TabIndex = 2;                                   // 탭 인덱스 설정
            this.connection_btn.Text = "연결";                                  // 텍스트 설정
            this.connection_btn.UseVisualStyleBackColor = true;                 // 사용자 정의 설정

             
            // label1
            this.label1.AutoSize = true;                                // 자동 크기 조정 설정
            this.label1.Location = new System.Drawing.Point(12, 331);   // 위치 설정
            this.label1.Name = "label1";                                // 이름 설정
            this.label1.Size = new System.Drawing.Size(116, 24);        // 크기 설정
            this.label1.TabIndex = 3;                                   // 탭 인덱스 설정
            this.label1.Text = "Message :";                             // 텍스트 설정

            
            // button1
            this.button1.Location = new System.Drawing.Point(12, 111);  // 위치 설정
            this.button1.Name = "button1";                              // 이름 설정
            this.button1.Size = new System.Drawing.Size(165, 91);       // 크기 설정
            this.button1.TabIndex = 4;                                  // 탭 인덱스 설정
            this.button1.Text = "LED_01 ON";                            // 텍스트 설정
            this.button1.UseVisualStyleBackColor = true;                // 사용자 정의 설정

            
            // button2
            this.button2.Location = new System.Drawing.Point(209, 111); // 위치 설정
            this.button2.Name = "button2";                              // 이름 설정
            this.button2.Size = new System.Drawing.Size(167, 91);       // 크기 설정
            this.button2.TabIndex = 5;                                  // 탭 인덱스 설정
            this.button2.Text = "LED_01 OFF";                           // 텍스트 설정
            this.button2.UseVisualStyleBackColor = true;                // 사용자 정의 설정

            
            // button3
            this.button3.Location = new System.Drawing.Point(12, 208);  // 위치 설정
            this.button3.Name = "button3";                              // 이름 설정
            this.button3.Size = new System.Drawing.Size(165, 91);       // 크기 설정
            this.button3.TabIndex = 6;                                  // 탭 인덱스 설정
            this.button3.Text = "LED_02 ON";                            // 텍스트 설정
            this.button3.UseVisualStyleBackColor = true;                // 사용자 정의 설정

            
            // button4
            this.button4.Location = new System.Drawing.Point(209, 208); // 위치 설정
            this.button4.Name = "button4";                              // 이름 설정
            this.button4.Size = new System.Drawing.Size(167, 91);       // 크기 설정
            this.button4.TabIndex = 7;                                  // 탭 인덱스 설정
            this.button4.Text = "LED_02 OFF";                           // 텍스트 설정
            this.button4.UseVisualStyleBackColor = true;                // 사용자 정의 설정

            
            // textBox1
            this.textBox1.Enabled = false;                              // 활성화 여부 설정
            this.textBox1.Location = new System.Drawing.Point(16, 370); // 위치 설정
            this.textBox1.Name = "textBox1";                            // 이름 설정
            this.textBox1.Size = new System.Drawing.Size(360, 35);      // 크기 설정
            this.textBox1.TabIndex = 8;                                 // 탭 인덱스 설정

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);  // 폰트 크기 설정
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;   // 폰트 크기 조정 설정
            this.ClientSize = new System.Drawing.Size(412, 429);            // 크기 설정
            this.Controls.Add(this.textBox1);                               // 컨트롤 추가
            this.Controls.Add(this.button4);                                // 컨트롤 추가
            this.Controls.Add(this.button3);                                // 컨트롤 추가
            this.Controls.Add(this.button2);                                // 컨트롤 추가
            this.Controls.Add(this.button1);                                // 컨트롤 추가
            this.Controls.Add(this.label1);                                 // 컨트롤 추가
            this.Controls.Add(this.connection_btn);                         // 컨트롤 추가
            this.Controls.Add(this.comboBox1);                              // 컨트롤 추가
            this.Name = "Form1";                                            // 이름 설정
            this.Text = "Form1";                                            // 텍스트 설정
            this.ResumeLayout(false);                                       // 레이아웃 변경 종료
            this.PerformLayout();                                           // 레이아웃 변경 적용
        }

        #endregion

        // 다양한 컨트롤 및 구성 요소 정의

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button connection_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
    }
}
