using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        int counter = 5;
        Button btnPlus, btnMinus;
        EditText et;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnPlus = (Button)FindViewById(Resource.Id.btnPlus);
            btnMinus = (Button)FindViewById(Resource.Id.btnMinus);
            et = (EditText)FindViewById(Resource.Id.et);

            btnPlus.Click += BtnPlus_Click;

        }

        private void BtnPlus_Click(object sender, System.EventArgs e)
        {
            counter++;
            et.Text = "" + counter;
        }
    }
}