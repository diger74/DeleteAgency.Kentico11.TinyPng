using System;
using CMS.DataEngine;
using DeleteAgency.Kentico11.TinyPng.Models;

namespace DeleteAgency.Kentico11.TinyPng.Events
{
    public class TinyPngImageOptimizerEventArgs : EventArgs
    {
        public BaseInfo Image { get; set; }

        public TinyPngShrinkResponse ShrinkResponse { get; set; }

        public bool CancelImageOptimization { get; set; }

        public bool ImageOptimizationSuccessful { get; set; }

        public Exception Error { get; set; }

        public TinyPngImageOptimizerEventArgs()
        {
            ImageOptimizationSuccessful = false;
            CancelImageOptimization = false;
        }
    }
}