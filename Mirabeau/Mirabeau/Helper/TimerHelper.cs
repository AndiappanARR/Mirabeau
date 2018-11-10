using Mirabeau.Common.Common;
using Mirabeau.Service.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mirabeau.Helper
{
    /// <summary>
    /// TimerHelper
    /// </summary>
    public static class TimerHelper
    {
        /// <summary>
        /// t_Elapsed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            SignleTon.ActivateSigleTonData();
        }

        /// <summary>
        /// Init
        /// </summary>
        public static void Init()
        {
            SignleTon.ActivateSigleTonData();
            System.Timers.Timer t = new System.Timers.Timer(Convert.ToInt32(Constants.JsonFeederRefreshRate));

            t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);

            t.Start();
        }
    }
}