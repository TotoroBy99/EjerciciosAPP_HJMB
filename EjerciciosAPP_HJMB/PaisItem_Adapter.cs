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

namespace EjerciciosAPP_HJMB
{
    class PaisesItem_Adapter : BaseAdapter
    {
        Activity contex;
        List<Paises> paises;

        public PaisesItem_Adapter(Activity contex, List<Paises> paises)
        {
            this.contex = contex;
            this.paises = paises;
        }

        public override int Count => paises.Count;

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
            var item = paises[position];
            View view = convertView;
            if (view == null)
                view = contex.LayoutInflater.Inflate(Resource.Layout.PaisItem_Layout, null);
            view.FindViewById<TextView>(Resource.Id.txtIso2).Text = item.CodISO2;
            view.FindViewById<TextView>(Resource.Id.txtIso3).Text = item.CodISO3;
            view.FindViewById<TextView>(Resource.Id.txtPais).Text = item.Pais;
            view.FindViewById<TextView>(Resource.Id.txtCapital).Text = item.Capital;
            view.FindViewById<TextView>(Resource.Id.txtPrefijo).Text = item.Prefijo;
            return view;
        }
    }
}