using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static AppPrecioCanasta.Global;

namespace AppPrecioCanasta
{
    [Activity(Label = "ActivityDetalleAño")]
    public class ActivityDetalleAño : Activity
    {
        int anio;
        Anio datos;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.detalleanio);

            //Recuperamos el valor pasado como parametro atravez del Intent
            anio = Intent.GetIntExtra("anio", 0);
            datos = Global.años.Where(x => x.Año == anio).FirstOrDefault();

            TextView tituloAnio = FindViewById<TextView>(Resource.Id.textView1);
            

            ListView lv_Meses = FindViewById<ListView>(Resource.Id.listView1);

            if(datos.Meses != null)
            {
                tituloAnio.Text = "Año " + datos.Año.ToString();
                lv_Meses.Adapter = new AdapterMes(this, datos.Meses);
            }
            else
            {
                tituloAnio.Text = "\n\n\n\nAño " + datos.Año.ToString() + "\n\n\nNO HAY INFORMACION DE ESTE AÑO";
                tituloAnio.SetTextColor(Android.Graphics.Color.Red);
            }
                
        }
    }
}