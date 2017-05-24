using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsLifecycle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            sr.WriteLine("1 - Move event : This event occurs when the form is moved. Although by default, when a form is instantiated and launched, the user does not move it, yet this event is triggered before the Load event occurs.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sr.WriteLine("1 - Load event : This event occurs before a form is displayed for the first time.");
        }
        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            sr.WriteLine("1 - VisibleChanged event : This event occurs when the Visible property value changes.");
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            sr.WriteLine("1 - Activated event : This event occurs when the form is activated in code or by the user.");
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            sr.WriteLine("1 - Shown event : This event occurs whenever the form is first displayed.");
        }
        private void Form1_Paint(object sender, EventArgs e)
        {
            sr.WriteLine("1 - Paint event : This event occurs when the control is redrawn.");
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            sr.WriteLine("1 - Deactivate event : This event occurs when the form loses focus and is not the active form.");
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
            sr.WriteLine("1 - Closing event : This event occurs when the form is closing.");
        }
        private void Form1_Closed(object sender, EventArgs e)
        {
            sr.WriteLine("1 - Closed event : This event occurs when the form is being closed.");
        }
    }
}
