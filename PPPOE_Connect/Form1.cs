﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PPPOE_Connect
{
    public partial class Form1 : Form
    {

        GET_Internet_IP gii = new GET_Internet_IP();
        string pppoe_id = null;
        string pppoe_pw = null;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int version = Environment.OSVersion.Version.Major + Environment.OSVersion.Version.Minor;
            add_link.Create_link(version);
            label_Public_IP.Text = gii.GetIP();
            pictureBox1.Image = imageList1.Images[0];
            label_version.Text = "0.3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.gogo))
            {
                IsBackground = true
            }.Start();
        }



        private void gogo()
        {
            pictureBox1.Image = imageList1.Images[1];
            
            if (button1.Text != "断开")
            {
                label3.Text = "链接中....";
                try
                {
                    button1.Enabled = false;

                    if (radio_StaticIP.Checked)
                    {
                        pppoe_id = "dianxin";
                        pppoe_pw = "asd123";
                    }
                    if (radio_LT_Line.Checked)
                    {
                        pppoe_id = "liantong";
                        pppoe_pw = "asd456";
                    }
                    if (radio_Download.Checked)
                    {
                        pppoe_id = "ctcc";
                        pppoe_pw = "123";
                    }
                        pppoe.pppoe_on(pppoe_id, pppoe_pw);
                        Thread.Sleep(1000);
                        NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                        NetworkInterface[] array = allNetworkInterfaces;
                        for (int i = 0; i < array.Length; i++)
                        {
                            NetworkInterface networkInterface = array[i];
                            Console.WriteLine(string.Concat(new object[]
                            {
                            "获取本地IP：",
                            networkInterface.NetworkInterfaceType,
                            " ",
                            networkInterface.Description.ToString()
                            }));
                            if (networkInterface.Description.Contains("CYJH"))
                            {
                                IPInterfaceProperties iPProperties = networkInterface.GetIPProperties();
                                UnicastIPAddressInformationCollection unicastAddresses = iPProperties.UnicastAddresses;
                                foreach (UnicastIPAddressInformation current in unicastAddresses)
                                {
                                    if (current.Address.AddressFamily == AddressFamily.InterNetwork)
                                    {
                                        label_PrivateIP.Text = current.Address.ToString();
                                    }
                                }
                            }

                    }
                    if (label_PrivateIP.Text != "Null")
                    {
                        button1.Text = "断开";
                        button1.Enabled = true;
                        radio_LT_Line.Enabled = false;
                        radio_StaticIP.Enabled = false;
                        radio_Download.Enabled = false;
                        Console.WriteLine(gii.GetIP());
                        GetIP();
                        pictureBox1.Image = imageList2.Images[0];
                        label3.Text = "";
                        Console.WriteLine("--------Link-------OK");
                    }
                    else
                    {
                        label3.Text = "失败了...";
                        pictureBox1.Image = imageList1.Images[2];
                        button1.Enabled = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                button1.Enabled = false;
                pppoe.pppoe_off();
                GetIP();
                button1.Enabled = true;
                radio_LT_Line.Enabled = true;
                radio_StaticIP.Enabled = true;
                radio_Download.Enabled = true;
                label_PrivateIP.Text = "Null";
                button1.Text = "连接";
                pictureBox1.Image = imageList1.Images[0];
            }

        }
        private void GetIP()
        {

            this.label_Public_IP.Text = "获取中...";
            this.label_Public_IP.Text = gii.GetIP();
            if (gii.GetIP() == "获取失败"|| label_PrivateIP.Text=="Null")
            {
                pictureBox1.Image = imageList1.Images[2];
                label3.Text = "拨号好像失败了..";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(GetIP))
            {
                IsBackground = true
            }.Start();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            pppoe.pppoe_off();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

    }
}
