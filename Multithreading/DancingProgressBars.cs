using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Multithreading {
    public partial class DancingProgressBars : Form {
        private short Amount;
        private Thread[] threads;
        public DancingProgressBars(short amount) {
            InitializeComponent();
            this.Amount = amount;
            threads = new Thread[amount];
            this.Height = new ProgressBar().Height * amount+40;
            for (int i = 0; i < amount; i++) {
                this.Controls.Add(new ProgressBar() { Dock = DockStyle.Top, BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))});
                threads[i] = new Thread(Dance);
                threads[i].IsBackground = true;
                threads[i].Start(this.Controls[i]);
            }
        }
        Random rnd = new Random(DateTime.Now.GetHashCode());
        private void Dance(object progressBar) {
            if (progressBar == null || !(progressBar is ProgressBar)) return;

            var pb = progressBar as ProgressBar;

            Action action = () => {
                pb.Value = rnd.Next(1, 100);
            };
            while (true) {
                Thread.Sleep(200);
                if (InvokeRequired)
                    try {
                        Invoke(action);
                    }
                    catch (Exception) {
                    }
                   
                else
                    action();
            }
        }
    }
}
