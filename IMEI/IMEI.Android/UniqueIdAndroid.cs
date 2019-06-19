using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using IMEI.Droid;
using IMEI.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(UniqueIdAndroid))]
namespace IMEI.Droid
{
    public class UniqueIdAndroid :IDevice
    {
        Android.Telephony.TelephonyManager mTelephonyMgr;
        public string GetIdentifier()
        {
            mTelephonyMgr = (Android.Telephony.TelephonyManager)Forms.Context.GetSystemService(Context.TelephonyService);
            return mTelephonyMgr.DeviceId;
        }
    }
}