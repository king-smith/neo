﻿using AntShares.Core;
using AntShares.Data;
using AntShares.Network;
using AntShares.Properties;
using AntShares.UI;
using AntShares.Wallets;
using System;
using System.Windows.Forms;

namespace AntShares
{
    internal static class Program
    {
        public static readonly LBlockchain Blockchain;
        public static readonly LocalNode LocalNode;
        public static UserWallet CurrentWallet;

        static Program()
        {
            Blockchain = new LBlockchain();
            LocalNode = new LocalNode(Settings.Default.NodePort);
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            LocalNode.Dispose();
            Blockchain.Dispose();
        }
    }
}
