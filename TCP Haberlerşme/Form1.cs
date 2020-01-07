using EasyModbus;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TCP_Haberlerşme
{
    public partial class Form1 : Form
    {
        private ModbusClient modbusClient = new ModbusClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();

                bool[] ip = modbusClient.ReadDiscreteInputs(0, 9);

                for (int i = 0; i < 9; i++)
                {
                    Control[] sayacLabels = Controls.Find("lbl" + (i + 1).ToString(), true);
                    Label sayac = (Label)sayacLabels[0];

                    sayac.BackColor = Color.White;
                    sayac.ForeColor = Color.Black;

                    if (ip[i])
                    {
                        sayac.BackColor = Color.Green;
                        sayac.ForeColor = Color.White;
                    }
                }

                timer1.Start();
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnBaglan.Enabled = true;
            }
        }

        private void BtnBaglan_Click(object sender, EventArgs e)
        {
            // 07.01.2019
            // Nadir Kocakır
            // bilgisayarın ethernet kartını, PLC nin Ip adresi ile aynı bloklara almak gerekiyor 192.168.0.XX

            modbusClient = new ModbusClient(
                txtIP.Text.Trim().ToString(),
                Convert.ToInt32(txtPort.Text.ToString().Trim()));

            modbusClient.Connect();

            LblBaglandi.Visible = true;

            timer1.Start();

            BtnBaglan.Enabled = false;
        }
    }
}