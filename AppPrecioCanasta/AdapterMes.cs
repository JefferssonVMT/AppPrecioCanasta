﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPrecioCanasta
{
    class AdapterMes : BaseAdapter
    {
        Activity context;
        List<Global.Mes> lista;

        public AdapterMes(Activity context, List<Global.Mes> lista)
        {
            this.context = context;
            this.lista = lista;
        }

        public override int Count => lista.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //Definimos el formato en que se van a presentar cada uno de los elementos de la lista
            var item = lista[position];

            View view = convertView;

            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);
            }

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nombre.ToString();
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = "Alimentos: " + item.CAlimentos.ToString() +
                                           "\nHogar: " + item.CHogar.ToString() +
                                           "\nVestuario: " + item.CVestuario.ToString() +
                                            "\nPrecio total promedio: " + (item.CAlimentos + item.CHogar + item.CVestuario).ToString();

            view.FindViewById<TextView>(Android.Resource.Id.Text1).TextAlignment = TextAlignment.Center;
            view.FindViewById<TextView>(Android.Resource.Id.Text2).TextAlignment = TextAlignment.Center;

            return view;
        }
    }
}

        