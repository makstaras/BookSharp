﻿namespace КурсоваБД
{
    partial class Managment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.attachBut = new System.Windows.Forms.Button();
            this.attach = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.smtp = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 409);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dateTimePicker3);
            this.tabPage1.Controls.Add(this.dateTimePicker4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.comboBox5);
            this.tabPage1.Controls.Add(this.comboBox6);
            this.tabPage1.Controls.Add(this.attachBut);
            this.tabPage1.Controls.Add(this.attach);
            this.tabPage1.Controls.Add(this.password);
            this.tabPage1.Controls.Add(this.username);
            this.tabPage1.Controls.Add(this.smtp);
            this.tabPage1.Controls.Add(this.subject);
            this.tabPage1.Controls.Add(this.to);
            this.tabPage1.Controls.Add(this.from);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.send);
            this.tabPage1.Controls.Add(this.body);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(506, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Робочий стіл";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 19);
            this.textBox2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(52, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 32;
            this.label3.Text = "Поточний час";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(103, 265);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(82, 19);
            this.dateTimePicker3.TabIndex = 31;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(5, 265);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(82, 19);
            this.dateTimePicker4.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 29;
            this.button2.Text = "Призначити зміну";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(6, 223);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(179, 22);
            this.comboBox4.TabIndex = 28;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(6, 176);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(179, 22);
            this.comboBox5.TabIndex = 27;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(6, 134);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(179, 22);
            this.comboBox6.TabIndex = 26;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // attachBut
            // 
            this.attachBut.Location = new System.Drawing.Point(199, 194);
            this.attachBut.Name = "attachBut";
            this.attachBut.Size = new System.Drawing.Size(99, 27);
            this.attachBut.TabIndex = 22;
            this.attachBut.Text = "Прикріпити файл";
            this.attachBut.UseVisualStyleBackColor = true;
            this.attachBut.Click += new System.EventHandler(this.attachBut_Click);
            // 
            // attach
            // 
            this.attach.Location = new System.Drawing.Point(198, 226);
            this.attach.Name = "attach";
            this.attach.Size = new System.Drawing.Size(100, 19);
            this.attach.TabIndex = 20;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(393, 344);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 19);
            this.password.TabIndex = 19;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(393, 314);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 19);
            this.username.TabIndex = 18;
            // 
            // smtp
            // 
            this.smtp.Location = new System.Drawing.Point(393, 286);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(100, 19);
            this.smtp.TabIndex = 17;
            this.smtp.Text = "smtp.gmail.com";
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(393, 256);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(100, 19);
            this.subject.TabIndex = 16;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(393, 228);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(100, 19);
            this.to.TabIndex = 15;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(393, 197);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(100, 19);
            this.from.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(328, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 14);
            this.label12.TabIndex = 13;
            this.label12.Text = "Пароль";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(328, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Ім\'я користувача";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(328, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Smtp сервер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(328, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Тема";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(328, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "До";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(328, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Від";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(199, 319);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(99, 43);
            this.send.TabIndex = 7;
            this.send.Text = "Відіслати поідомлення";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(199, 34);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(297, 153);
            this.body.TabIndex = 6;
            this.body.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(506, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Інформація";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(14, 205);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Name";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Price";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(474, 158);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(517, 406);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Managment";
            this.Load += new System.EventHandler(this.Mechanic_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox smtp;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.TextBox attach;
        private System.Windows.Forms.Button attachBut;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

    }
}