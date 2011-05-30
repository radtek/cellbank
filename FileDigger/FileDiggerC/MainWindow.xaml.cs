﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.ServiceModel;

namespace FileDiggerC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String fileName=this.textBox1.Text;
            String hostString=Dns.GetHostName();
            IPHostEntry hostinfo = Dns.GetHostEntry(hostString);
            System.Net.IPAddress[] addresses = hostinfo.AddressList;
            foreach(IPAddress address in addresses)
            {
                if (!address.IsIPv6LinkLocal)
                {
                    String localIp = address.ToString();
                    localIp=localIp.Substring(0,localIp.LastIndexOf(".")+1);
                    for (int i = 0; i < 255; i++)
                    {
                        String ip = localIp + i;
                        FileDiggerService.FileDiggerClient c = new FileDiggerService.FileDiggerClient();
                       // System.ServiceModel.EndpointAddress endAddress = c.Endpoint.Address;
                        c.Endpoint.Address = new EndpointAddress("http://"+ip+":8000/ServiceModelSamples/service";
                        string[] files= c.findFile("shit");
                        if(files!=null&&files.Length>0){

                            break;
                        }
                    }
                }
            }

        }
    }
}
