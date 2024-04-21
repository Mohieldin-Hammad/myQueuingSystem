namespace myQueuingSystem
{
    public partial class Form1 : Form
    {
        static int num_delays_required = 1000;
        static int Queue_size = 32000;
        static int next_event_type; //1 or 2
        static double mean_interarrival = 1;
        static double mean_service = 0.5;
        static double[] time_arrival = new double[Queue_size];
        static double[] time_next_event = new double[3];
        static Random random = new Random(10000);
        double sim_time_num;
        double time_last_event_num;
        double area_num_in_q_num;
        int num_in_q_num;
        //double server_status_num;
        double area_server_status_num;
        double total_of_delays_num;
        int num_custs_delayed_num;

        public Form1()
        {

            InitializeComponent();
            initialize();


        }

        private void initialize()
        {
            time_next_event[1] = double.Parse(sim_time.Text) + expon(mean_interarrival);
            time_next_event[2] = 1.0e+30; //10^30
            
            sim_time_num = double.Parse(sim_time.Text);
            time_last_event_num = double.Parse(time_last_event.Text);
            area_num_in_q_num = double.Parse(area_num_in_q.Text);
            num_in_q_num = int.Parse(num_in_q.Text);
            //server_status_num = double.Parse(server_status.Text);
            area_server_status_num = double.Parse(area_server_status.Text);
            total_of_delays_num = double.Parse(total_of_delays.Text);
            num_custs_delayed_num = int.Parse(num_custs_delayed.Text);

        }


        private void new_custs_button_Click(object sender, EventArgs e)
        {
            if (num_custs_delayed_num < num_delays_required)
            {
                timing();

                update_time_avg_stats();
                switch (next_event_type)
                {
                    case 1:
                        arrive();
                        break;
                    case 2:
                        depart();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Can't add more custmers, The system reached the maximum number of delayed required: " + num_delays_required);
            }
        }


        private void timing()
        {
            if (time_next_event[1] < time_next_event[2])
                next_event_type = 1;//arrival
            else
                next_event_type = 2; //departure
            sim_time_num = time_next_event[next_event_type];
            sim_time.Text = sim_time_num.ToString();

        }



        private void update_time_avg_stats()
        {
            double lag;

            //sim_time: clock, time of current event
            lag = sim_time_num - time_last_event_num;

            //area under Q(t)
            area_num_in_q_num += num_in_q_num * lag;
            area_num_in_q.Text = area_num_in_q_num.ToString();

            //area under B(t)
            area_server_status_num += int.Parse(server_status.Text) * lag;
            area_server_status.Text = area_server_status_num.ToString();
        }

        private void arrive()
        {
            double delay;
            time_next_event[1] = sim_time_num + expon(mean_interarrival);
            time_next_arrival_d.Text = time_next_event[1].ToString();

            if (int.Parse(server_status.Text) == 1)
            {
                num_in_q_num++;
                num_in_q.Text = num_in_q_num.ToString();

                time_arrival[num_in_q_num] = sim_time_num;
                time_arrival_qeaue.Items.Add(sim_time.Text);
            }
            else
            {
                delay = 0;
                total_of_delays_num += delay;
                total_of_delays.Text = total_of_delays_num.ToString();

                num_custs_delayed_num++;
                num_custs_delayed.Text = num_custs_delayed_num.ToString();

                server_status.Text = (1).ToString();

                time_next_event[2] = sim_time_num + expon(mean_service);
                time_next_deprtial_d.Text = time_next_event[2].ToString();
            }
        }

        private void depart()
        {
            double delay;
            if (num_in_q_num == 0)
            {
                server_status.Text = 0.ToString();

                time_next_event[2] = 1.0e+30;
                time_next_deprtial_d.Text = "∞";
            }
            else
            {
                num_in_q_num--;
                num_in_q.Text = num_in_q_num.ToString();

                delay = sim_time_num - time_arrival[1];
                total_of_delays_num += delay;
                total_of_delays.Text = total_of_delays_num.ToString();

                num_custs_delayed_num++;
                num_custs_delayed.Text = num_custs_delayed_num.ToString();

                time_next_event[2] = sim_time_num + expon(mean_service);
                time_next_deprtial_d.Text = time_next_event[2].ToString();

                time_arrival_qeaue.Items.RemoveAt(0);
                for (int i = 1; i <= num_in_q_num; i++)
                {
                    time_arrival[1] = time_arrival[i + 1];
                }
            }
        }


        static double expon(double mean)
        {
            return -mean * Math.Log(random.NextDouble());
        }


        private void report_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total customer use this server: " + num_custs_delayed_num + "\n\n" +
                            "Average delay in queu in minutes d(n): " + total_of_delays_num / num_custs_delayed_num + "\n\n" +
                            "Average number in queue q(n): " + area_num_in_q_num / sim_time_num + "\n\n" +
                            "Server utilozation u(n): " + area_server_status_num / sim_time_num + "\n\n");

        }
    }
}