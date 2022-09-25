using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace Multithreading {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void bDancingProgressBars_Click(object sender, EventArgs e) {
            DancingProgressBars bars = new DancingProgressBars((short)nBars.Value);
            bars.ShowDialog();
        }
        Thread[] hoursesThreads = new Thread[5];
        private void bHourseRace_Click(object sender, EventArgs e) {
            lbResults.Items.Clear();
            bHourseRace.Enabled = false;
            for (int i = 0; i < hoursesThreads.Length; i++) {
                hoursesThreads[i] = new Thread(Run);
                (this.Controls["gbHourse"].Controls[i] as ProgressBar).Value = 0;
                hoursesThreads[i].Start(this.Controls["gbHourse"].Controls[i]);
            }
        }
        Random rnd = new Random(DateTime.Now.GetHashCode());
        private void Run(object pb) {
            if (pb == null || !(pb is ProgressBar)) return;

            var CastedPb = pb as ProgressBar;

            Action act = () => {
                var value = rnd.Next(1, 10); ;
                if (value + CastedPb.Value > 100) {
                    CastedPb.Value = 100;
                }
                else
                    CastedPb.Value += value;
            };

            Action endAct = () => {
                lbResults.Items.Add($"#{lbResults.Items.Count + 1} is {CastedPb.Name}");
                bHourseRace.Enabled = true;
            };

            while (CastedPb.Value <= 99) {
                Thread.Sleep(200);
                if (InvokeRequired)
                    try {
                        Invoke(act);
                    }
                    catch (Exception) {
                    }
                else act();
            }
            if (CastedPb.Value == 100) {
                if (InvokeRequired)
                    try {
                        Invoke(endAct);
                    }
                    catch (Exception) {
                    }
                else endAct();
            }
        }

        private void bFibonacci_Click(object sender, EventArgs e) {
            lbFibonacci.Items.Clear();
            Fibonacci fibo = ExecFibonacci;
            fibo.BeginInvoke((int)nMaxFibo.Value, null, null);
        }

        private delegate void Fibonacci(int maxValue);

        private void ExecFibonacci(int maxVal) {
            long a = 0, b = 1, c = 0;
            Action action = () => {
                c = a + b;
                lbFibonacci.Items.Add(c);
                (a, b) = (b, c);
            };
            while (c < maxVal) {
                Thread.Sleep(100);
                if (InvokeRequired)
                    Invoke(action);
                else
                    action();
            }
        }

        private void bOpenFileDialog(object sender, EventArgs e) {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = "Text Files|*.txt";

            OFD.ShowDialog();

            CountWord words = ExecCountWord;
            if (OFD.FileName != string.Empty && tbWord.Text != string.Empty)
                words.BeginInvoke(OFD.FileName, tbWord.Text, Callback, words);
        }

        private void bDir_Click(object sender, EventArgs e) {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();

            CountDirWord count = ExecCountIntWord;
            if (folder.SelectedPath != string.Empty && tbWord.Text != string.Empty)
                count.BeginInvoke(folder.SelectedPath, tbWord.Text, Callback_dir, count);
        }

        private string ExecCountIntWord(string filepath, string word) {
            string result = "";
            foreach (var item in Directory.GetFiles(filepath).Where(f => f.Contains(".txt"))) {
                var r = ExecCountWord(item, word);
                result += $"File: {Path.GetFileName(item)}\nPath: {filepath}\nResult: {r}\n";
            }
            return result;
        }

        private void Callback_dir(IAsyncResult result) {
            CountDirWord cWords = result.AsyncState as CountDirWord;
            MessageBox.Show(cWords.EndInvoke(result), "Counter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Callback(IAsyncResult result) {
            CountWord cWords = result.AsyncState as CountWord;
            int res = cWords.EndInvoke(result);
            MessageBox.Show($"Result: {res}", "Counter", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private delegate int CountWord(string filepath, string word);
        private delegate string CountDirWord(string dirpath, string word);

        private int ExecCountWord(string filepath, string word) {
            string res;
            using (StreamReader sr = new StreamReader(filepath)) {
                res = sr.ReadToEnd();
            }
            char[] delimiterChars = { ' ', ',', '.', ':' };
            var arr = res.Split(delimiterChars);
            int counter = 0;
            string tWord = word.ToLower();
            foreach (var item in arr) {
                if (item.ToLower() == tWord) counter++;
            }
            return counter;
        }
    }
}
