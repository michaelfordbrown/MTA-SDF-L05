using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace WindowsService
{
    class WindowsService : ServiceBase
    {
        /// &lt;summary>
        /// Public Constructor for WindowsService.
        /// - Put all of your Initialization code here.
        /// &lt;/summary>
        public WindowsService()
        {
            this.ServiceName = "My Windows Service";
            this.EventLog.Log = "Application";

            // These Flags set whether or not to handle that specific
            //  type of event. Set to true if you need it, false otherwise.
            this.CanHandlePowerEvent = true;
            this.CanHandleSessionChangeEvent = true;
            this.CanPauseAndContinue = true;
            this.CanShutdown = true;
            this.CanStop = true;
        }

        /// &lt;summary>
        /// The Main Thread: This is where your Service is Run.
        /// &lt;/summary>
        static void Main()
        {
            ServiceBase.Run(new WindowsService());
        }

        /// &lt;summary>
        /// Dispose of objects that need it here.
        /// &lt;/summary>
        /// &lt;param name="disposing">Whether
        ///    or not disposing is going on.&lt;/param>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        /// &lt;summary>
        /// OnStart(): Put startup code here
        ///  - Start threads, get inital data, etc.
        /// &lt;/summary>
        /// &lt;param name="args">&lt;/param>
        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
        }

        /// &lt;summary>
        /// OnStop(): Put your stop code here
        /// - Stop threads, set final data, etc.
        /// &lt;/summary>
        protected override void OnStop()
        {
            base.OnStop();
        }

        /// &lt;summary>
        /// OnPause: Put your pause code here
        /// - Pause working threads, etc.
        /// &lt;/summary>
        protected override void OnPause()
        {
            base.OnPause();
        }

        /// &lt;summary>
        /// OnContinue(): Put your continue code here
        /// - Un-pause working threads, etc.
        /// &lt;/summary>
        protected override void OnContinue()
        {
            base.OnContinue();
        }

        /// &lt;summary>
        /// OnShutdown(): Called when the System is shutting down
        /// - Put code here when you need special handling
        ///   of code that deals with a system shutdown, such
        ///   as saving special data before shutdown.
        /// &lt;/summary>
        protected override void OnShutdown()
        {
            base.OnShutdown();
        }

        /// &lt;summary>
        /// OnCustomCommand(): If you need to send a command to your
        ///   service without the need for Remoting or Sockets, use
        ///   this method to do custom methods.
        /// &lt;/summary>
        /// &lt;param name="command">Arbitrary Integer between 128 & 256&lt;/param>
        protected override void OnCustomCommand(int command)
        {
            //  A custom command can be sent to a service by using this method:
            //#  int command = 128; //Some Arbitrary number between 128 & 256
            //#  ServiceController sc = new ServiceController("NameOfService");
            //#  sc.ExecuteCommand(command);

            base.OnCustomCommand(command);
        }

        /// &lt;summary>
        /// OnPowerEvent(): Useful for detecting power status changes,
        ///   such as going into Suspend mode or Low Battery for laptops.
        /// &lt;/summary>
        /// &lt;param name="powerStatus">The Power Broadcast Status
        /// (BatteryLow, Suspend, etc.)&lt;/param>
        protected override bool OnPowerEvent(PowerBroadcastStatus powerStatus)
        {
            return base.OnPowerEvent(powerStatus);
        }

        /// &lt;summary>
        /// OnSessionChange(): To handle a change event
        ///   from a Terminal Server session.
        ///   Useful if you need to determine
        ///   when a user logs in remotely or logs off,
        ///   or when someone logs into the console.
        /// &lt;/summary>
        /// &lt;param name="changeDescription">The Session Change
        /// Event that occured.&lt;/param>
        protected override void OnSessionChange(
                  SessionChangeDescription changeDescription)
        {
            base.OnSessionChange(changeDescription);
        }
    }
}
