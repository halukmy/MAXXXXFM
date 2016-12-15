using Android.App;
using Android.Widget;
using Android.OS;
using Plugin.MediaManager;
using System.Threading.Tasks;
using Plugin.MediaManager.Abstractions.Enums;
using Java.Lang;

namespace MAXFM
{
    [Activity(Label = "MAXFM", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            Android.Net.Uri soundString = Android.Net.Uri.Parse("http://live2.radyotvonline.com:8025");

            await CrossMediaManager.Current.Play("http://live2.radyotvonline.com:8025/", Plugin.MediaManager.Abstractions.Enums.MediaFileType.AudioUrl);

            // Android.Net.Uri soundString = Android.Net.Uri.Parse("http://live2.radyotvonline.com:8025");


        }
    }





}

