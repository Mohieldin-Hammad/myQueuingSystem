namespace myQueuingSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.time_last_event = new System.Windows.Forms.TextBox();
            this.num_in_q = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.server_status = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.time_next_arrival_d = new System.Windows.Forms.TextBox();
            this.time_next_deprtial_d = new System.Windows.Forms.TextBox();
            this.sim_time = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.area_server_status = new System.Windows.Forms.TextBox();
            this.area_num_in_q = new System.Windows.Forms.TextBox();
            this.total_of_delays = new System.Windows.Forms.TextBox();
            this.num_custs_delayed = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.new_custs_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Initialization time = 0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.time_last_event);
            this.panel1.Controls.Add(this.num_in_q);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.server_status);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(160, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 245);
            this.panel1.TabIndex = 3;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(150, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(78, 23);
            this.textBox11.TabIndex = 14;
            this.textBox11.Text = "System state";
            // 
            // time_last_event
            // 
            this.time_last_event.Location = new System.Drawing.Point(234, 134);
            this.time_last_event.Name = "time_last_event";
            this.time_last_event.Size = new System.Drawing.Size(41, 23);
            this.time_last_event.TabIndex = 10;
            this.time_last_event.Text = "0";
            this.time_last_event.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_in_q
            // 
            this.num_in_q.Location = new System.Drawing.Point(127, 134);
            this.num_in_q.Name = "num_in_q";
            this.num_in_q.Size = new System.Drawing.Size(41, 23);
            this.num_in_q.TabIndex = 9;
            this.num_in_q.Text = "0";
            this.num_in_q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(234, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(101, 23);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Time of last event";
            // 
            // server_status
            // 
            this.server_status.Location = new System.Drawing.Point(48, 134);
            this.server_status.Name = "server_status";
            this.server_status.Size = new System.Drawing.Size(41, 23);
            this.server_status.TabIndex = 2;
            this.server_status.Text = "0";
            this.server_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Number in queue";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Server status";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.time_next_arrival_d);
            this.panel2.Controls.Add(this.time_next_deprtial_d);
            this.panel2.Controls.Add(this.sim_time);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Location = new System.Drawing.Point(559, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 130);
            this.panel2.TabIndex = 4;
            // 
            // time_next_arrival_d
            // 
            this.time_next_arrival_d.Location = new System.Drawing.Point(232, 35);
            this.time_next_arrival_d.Name = "time_next_arrival_d";
            this.time_next_arrival_d.Size = new System.Drawing.Size(54, 23);
            this.time_next_arrival_d.TabIndex = 13;
            this.time_next_arrival_d.Text = "0";
            this.time_next_arrival_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // time_next_deprtial_d
            // 
            this.time_next_deprtial_d.Location = new System.Drawing.Point(232, 54);
            this.time_next_deprtial_d.Name = "time_next_deprtial_d";
            this.time_next_deprtial_d.Size = new System.Drawing.Size(54, 23);
            this.time_next_deprtial_d.TabIndex = 12;
            this.time_next_deprtial_d.Text = "∞";
            this.time_next_deprtial_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sim_time
            // 
            this.sim_time.Location = new System.Drawing.Point(71, 54);
            this.sim_time.Name = "sim_time";
            this.sim_time.Size = new System.Drawing.Size(41, 23);
            this.sim_time.TabIndex = 11;
            this.sim_time.Text = "0";
            this.sim_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(232, 83);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(54, 23);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "Event list";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(71, 83);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(38, 23);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Clock";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox12);
            this.panel3.Controls.Add(this.area_server_status);
            this.panel3.Controls.Add(this.area_num_in_q);
            this.panel3.Controls.Add(this.total_of_delays);
            this.panel3.Controls.Add(this.num_custs_delayed);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Controls.Add(this.textBox9);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Location = new System.Drawing.Point(559, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 118);
            this.panel3.TabIndex = 5;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(141, 3);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(107, 23);
            this.textBox12.TabIndex = 15;
            this.textBox12.Text = "Statistical counters";
            // 
            // area_server_status
            // 
            this.area_server_status.Location = new System.Drawing.Point(292, 48);
            this.area_server_status.Name = "area_server_status";
            this.area_server_status.Size = new System.Drawing.Size(63, 23);
            this.area_server_status.TabIndex = 16;
            this.area_server_status.Text = "0";
            this.area_server_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // area_num_in_q
            // 
            this.area_num_in_q.Location = new System.Drawing.Point(185, 48);
            this.area_num_in_q.Name = "area_num_in_q";
            this.area_num_in_q.Size = new System.Drawing.Size(63, 23);
            this.area_num_in_q.TabIndex = 15;
            this.area_num_in_q.Text = "0";
            this.area_num_in_q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_of_delays
            // 
            this.total_of_delays.Location = new System.Drawing.Point(115, 48);
            this.total_of_delays.Name = "total_of_delays";
            this.total_of_delays.Size = new System.Drawing.Size(63, 23);
            this.total_of_delays.TabIndex = 14;
            this.total_of_delays.Text = "0";
            this.total_of_delays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_custs_delayed
            // 
            this.num_custs_delayed.Location = new System.Drawing.Point(8, 48);
            this.num_custs_delayed.Name = "num_custs_delayed";
            this.num_custs_delayed.Size = new System.Drawing.Size(63, 23);
            this.num_custs_delayed.TabIndex = 13;
            this.num_custs_delayed.Text = "0";
            this.num_custs_delayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(292, 77);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(86, 23);
            this.textBox10.TabIndex = 12;
            this.textBox10.Text = "Area under B(t)";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(185, 77);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(101, 23);
            this.textBox9.TabIndex = 11;
            this.textBox9.Text = "Area under Q(t)";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(115, 77);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(64, 23);
            this.textBox8.TabIndex = 10;
            this.textBox8.Text = "Total delay";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(8, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(101, 23);
            this.textBox7.TabIndex = 9;
            this.textBox7.Text = "Number delayed";
            // 
            // new_custs_button
            // 
            this.new_custs_button.Location = new System.Drawing.Point(12, 12);
            this.new_custs_button.Name = "new_custs_button";
            this.new_custs_button.Size = new System.Drawing.Size(75, 23);
            this.new_custs_button.TabIndex = 6;
            this.new_custs_button.Text = "Click me";
            this.new_custs_button.UseVisualStyleBackColor = true;
            this.new_custs_button.Click += new System.EventHandler(this.new_custs_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.new_custs_button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox time_last_event;
        private TextBox num_in_q;
        private TextBox server_status;
        private TextBox time_next_arrival_d;
        private TextBox time_next_deprtial_d;
        private TextBox sim_time;
        private TextBox area_server_status;
        private TextBox area_num_in_q;
        private TextBox total_of_delays;
        private TextBox num_custs_delayed;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button new_custs_button;
    }
}