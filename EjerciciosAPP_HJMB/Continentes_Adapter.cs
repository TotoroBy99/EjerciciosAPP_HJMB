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
using Java.Lang;

namespace EjerciciosAPP_HJMB
{
    class Continentes_Adapter : BaseAdapter
    {
        //Campos principales de la clase
        Activity contex;
        List<Continentes> lista;

        public Continentes_Adapter(Activity contex, List<Continentes> lista)
        {
            this.contex = contex;
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
            var item = lista[position];
            View view = convertView;
            if (view == null)
                view = contex.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nombre;
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = "Contiene " + Global._paises.Where(x => x.CodContinente == item.Id).Count().ToString() + " Paises";
            return view;
        }
    }
}