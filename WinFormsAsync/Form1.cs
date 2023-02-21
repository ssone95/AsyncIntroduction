using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var task = DoSomeHeavyWork();
            var task2 = DoSomeHeavyWork();

            //await Task.Run(LongRunningMethod);

            var task3 = Task.FromResult(123);

            var valueOfTask3 = await task3;

            textBox1.Text = "Returned from the task";

            await task;
        }

        private async void Test()
        {

        }

        private async Task DoSomethingOnSuccess(Task t)
        {

        }

        private async Task DoSomethingOnError(Task t)
        {

        }

        private void LongRunningMethod()
        {
            Thread.Sleep(10000);
            MessageBox.Show("LongRunningMethod is done!");
        }

        private async Task DoSomeHeavyWork()
        {
            textBox1.Text = "Runing...";
            await Task.Delay(5000);
            textBox1.Text = "Work has completed!";


            //throw new Exception("Exception has occurred");
        }
    }
}
