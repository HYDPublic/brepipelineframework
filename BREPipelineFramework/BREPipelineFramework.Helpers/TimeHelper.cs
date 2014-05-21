﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BREPipelineFramework.Helpers
{
    public static class TimeHelper
    {
        public static int GetTimeInMilliseconds(int expiryTime, TimeEnum expiryUnits)
        {
            switch(expiryUnits)
            {
                case TimeEnum.Milliseconds:
                    return expiryTime;
                case TimeEnum.Seconds:
                    return expiryTime * 1000;
                case TimeEnum.Minutes:
                    return expiryTime * 60 * 1000;
                case TimeEnum.Hours:
                    return expiryTime * 60 * 60 * 1000;
                default:
                    throw new Exception("Unexcepted value found in TimeEnum");
            }
        }
    }
}
