using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;



namespace ZipBomb
{
    public partial class Form1 : Form
    {
        public char CharToAdd = '0';

        public Form1()
        {
            InitializeComponent();
            UnitChanger.SelectedIndex = 2;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (!(ActiveForm is null))
            {
                ProgressBar.Size = new Size(ActiveForm.Width - 40, 24);
                ProgressBar.Location = new Point(12, ActiveForm.Height - 75);
                ZipButton.Location = new Point(ActiveForm.Width / 2 - 83, ActiveForm.Height - 125);
                FileName.Size = new Size(ActiveForm.Width - 285, 20);
                LinesNb.Size = new Size(ActiveForm.Width - 285, 20);
                Parcourir.Location = new Point(ActiveForm.Width - 125, 59);
                UnitChanger.Location = new Point(ActiveForm.Width - 125, 97);
            }
        }

        private void ZipButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName != "")
            {
                if (!BackgroundWorker.IsBusy)
                    BackgroundWorker.RunWorkerAsync(UnitChanger.SelectedIndex);
            }
            else
            {
                saveFileDialog1.ShowDialog();
                FileName.Text = saveFileDialog1.FileName;
            }
        }

        private void changerLemplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileName.Text = saveFileDialog1.FileName;
        }
        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void Parcourir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileName.Text = saveFileDialog1.FileName;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            File.AppendAllText("test2.txt", e.Argument.ToString());

            using (TextWriter file = new StreamWriter(saveFileDialog1.FileName, true))
            {
                string ToWrite = "";
                for (int i = 0; i < LinesNb.Value; i++)
                    ToWrite += CharToAdd;

                double Max = Math.Pow(1000, Convert.ToDouble(e.Argument));

                if (Convert.ToInt32(e.Argument) > 2)
                {
                    string ToWrite2 = ToWrite;
                    for (int i = 1; i < 1000; i++)
                        ToWrite += ToWrite2;
                    Max /= 1000;
                }

                for (int i = 0; i < Max; i++)
                {
                    file.Write(ToWrite);
                    BackgroundWorker.ReportProgress((int)(i * 100 / Max));
                }
            }
            sw.Stop();
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage + 1;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void àproposdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
