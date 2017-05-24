// Turn on logging to the event log.
#define LOGEVENTS

using System;
using System.ServiceProcess;
using System.IO;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {

        public Service1()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "OnStart.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                File.Create(path);
            }
            catch (IOException e)
            {

                Console.WriteLine("Error {0} While Creating OnStart.txt file", e.Message);
            }
            finally
            {

            }

        }
        protected override void OnStop()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "OnStop.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                File.Create(path);
            }
            catch (IOException e)
            {

                Console.WriteLine("Error {0} While Creating OnStop.txt file", e.Message);
            }
            finally
            {

            }

        }

        private void InitializeComponent()
        {
            // 
            // Service1
            // 
            this.ServiceName = "Service1";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}