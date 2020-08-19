using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace L06_Lifecycle_HW1.Modules
{
    public class TimerModule : IHttpModule
    {
        private Stopwatch timer;

        public void Init(HttpApplication app)
        {
            app.BeginRequest += HandleBeginRequest;
            app.EndRequest += HandleEndRequest;
        }

        private void HandleBeginRequest(object sender, EventArgs e)
        {
            timer = Stopwatch.StartNew();
        }

        private void HandleEndRequest(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            context.Response.Write($"На виконання запиту затрачено {((float)timer.ElapsedTicks / Stopwatch.Frequency)} секунд.");
        }

        public void Dispose() { }
    }
}