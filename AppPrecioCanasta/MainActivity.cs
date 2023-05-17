using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace AppPrecioCanasta
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lv_Anios;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            lv_Anios = FindViewById<ListView>(Resource.Id.listView1);

            lv_Anios.Adapter = new AdapterAnios(this, Global.años);
            lv_Anios.ItemClick += lv_Anios_ItemClick;
        }

        private void lv_Anios_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityDetalleAño));

            Global.Anio año = Global.años[e.Position];

            //Pasamos como parametro el id de la region al ActivityDetalleRegion
            i.PutExtra("anio", año.Año);

            StartActivity(i);
        }

    }
}