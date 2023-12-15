using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace _307Assessment
{
    public partial class StaffPage : Form
    {
        public StaffPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form = new Form2();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteFromDatabase Form = new DeleteFromDatabase();
            Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToSoftware Form = new AddToSoftware();
            Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteFromSoftware Form = new DeleteFromSoftware();
            Form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditHardware Form = new EditHardware();
            Form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditSoftware Form = new EditSoftware();
            Form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewDatabase Form = new ViewDatabase();
            Form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Get system information
            string systemName = Environment.MachineName;
            string systemModel = GetSystemModel();
            string systemManufacturer = GetSystemManufacturer();
            string systemType = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";

            // Get IP address
            string ipAddress = GetLocalIPAddress();

            // Display the information
            MessageBox.Show($"System Name: {systemName}\n" +
                            $"System Model: {systemModel}\n" +
                            $"System Manufacturer: {systemManufacturer}\n" +
                            $"System Type: {systemType}\n" +
                            $"IP Address: {ipAddress}",
                            "System Information");
        }

        private string GetSystemModel()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    return obj["Model"].ToString();
                }
            }
            return "N/A";
        }

        private string GetSystemManufacturer()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    return obj["Manufacturer"].ToString();
                }
            }
            return "N/A";
        }

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "N/A";
        }
    }
}
