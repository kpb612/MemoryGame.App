using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryGame.App.Helper
{
    public static class StringExtensions
    {
        public static int ToInteger(this string numberString)
        {
            if (int.TryParse(numberString, out int result))
                return result;
            return 0;
        }
    }

    public static class Utils
    {
        public static bool IsConnectedToInternet()
        {
            return CrossConnectivity.Current.IsConnected;
        }
    }
}
