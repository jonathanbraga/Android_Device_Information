using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace DeviceInformation
{
    [Activity(Label = "DeviceInformation", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.Main);

            TextView txtSerial = FindViewById<TextView>(Resource.Id.txtSerial);
            TextView txtModel = FindViewById<TextView>(Resource.Id.txtModel);
            TextView txtID = FindViewById<TextView>(Resource.Id.txtID);
            TextView txtManufacture = FindViewById<TextView>(Resource.Id.txtmanufacture);
            TextView txtBrand = FindViewById<TextView>(Resource.Id.txtBrand);
            TextView txtType = FindViewById<TextView>(Resource.Id.txtType);
            TextView txtUser = FindViewById<TextView>(Resource.Id.txtUser);
            TextView txtSdk = FindViewById<TextView>(Resource.Id.txtSdk);
            TextView txtFingerPrint = FindViewById<TextView>(Resource.Id.txtFingerPrint);
            TextView txtVersionCode = FindViewById<TextView>(Resource.Id.txtVersionCode);


            txtSerial.Text = Build.Serial.ToString();
            txtModel.Text = Build.Model.ToString();
            txtID.Text = Build.Id.ToString();
            txtManufacture.Text = Build.Manufacturer.ToString();
            txtBrand.Text = Build.Brand.ToString();
            txtType.Text = Build.Type.ToString();
            txtUser.Text = Build.User.ToString();
            txtSdk.Text = Build.VERSION.Sdk.ToString();
            txtFingerPrint.Text = Build.Fingerprint.ToString();
            txtVersionCode.Text = Build.VERSION.Release.ToString();

        }
    }
}

