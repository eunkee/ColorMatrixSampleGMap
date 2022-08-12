using GMap.NET;
using Microsoft.Win32;
using System;

namespace TestGMap
{
    public class RegistyTestGMap
    {
        private static readonly RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TestGMap", true);
        private static readonly RegistryKey RegKey = registryKey;
        private static readonly object regObject = new object();
        public static PointLatLng DEFAULT_POSITION = new PointLatLng(35.1933977, 129.0763879);

        public static double LastGMapLat
        {
            get
            {
                double rslt = DEFAULT_POSITION.Lat;
                if (RegKey != null)
                {
                    lock (regObject)
                    {
                        try
                        {
                            rslt = Convert.ToDouble(RegKey.GetValue("LastGMapLat", rslt));
                            rslt = Math.Round(rslt, 7);
                        }
                        catch { }
                    }
                }
                return rslt;
            }
            set
            {
                lock (regObject)
                {
                    if (RegKey != null)
                    {
                        try
                        {
                            RegKey.SetValue("LastGMapLat", value.ToString("0.0000000"));
                        }
                        catch { }
                    }
                }
            }
        }

        public static double LastGMapLng
        {
            get
            {
                double rslt = DEFAULT_POSITION.Lng;
                if (RegKey != null)
                {
                    lock (regObject)
                    {
                        try
                        {
                            rslt = Convert.ToDouble(RegKey.GetValue("LastGMapLng", rslt));
                            rslt = Math.Round(rslt, 7);
                        }
                        catch { }
                    }
                }
                return rslt;
            }
            set
            {
                lock (regObject)
                {
                    if (RegKey != null)
                    {
                        try
                        {
                            RegKey.SetValue("LastGMapLng", value.ToString("0.0000000"));
                        }
                        catch { }
                    }
                }
            }
        }

        public static double LastGMapZoom
        {
            get
            {
                double rslt = 16d;
                if (RegKey != null)
                {
                    lock (regObject)
                    {
                        try
                        {
                            rslt = Convert.ToDouble(RegKey.GetValue("LastGMapZoom", rslt));
                        }
                        catch { }
                    }
                }
                return rslt;
            }
            set
            {
                lock (regObject)
                {
                    if (RegKey != null)
                    {
                        try
                        {
                            RegKey.SetValue("LastGMapZoom", value.ToString());
                        }
                        catch { }
                    }
                }
            }
        }

    }
}
