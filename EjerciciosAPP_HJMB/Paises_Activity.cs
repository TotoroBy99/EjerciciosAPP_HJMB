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
    [Activity(Label = "Paises_Activity")]
    public class Paises_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here

            SetContentView(Resource.Layout.Paises_Layout);

            var listaPais = FindViewById<ListView>(Resource.Id.listView1);
            var txttitulo = FindViewById<TextView>(Resource.Id.txtCabezera);
            
            var id = Intent.GetIntExtra("id", 0);
            Continentes cont = Global._continentes.Where(x => x.Id == id).FirstOrDefault();

            if (cont.Id == 1)
                txttitulo.Text = "PAISES DE AFRICA";
            else
            if (cont.Id == 2)
                txttitulo.Text = "PAISES DE AMERICA";
            else
            if (cont.Id == 3)
                txttitulo.Text = "PAISES DE ASIA";
            else
            if (cont.Id == 4)
                txttitulo.Text = "PAISES DE EUROPA";

            listaPais.Adapter = new PaisesItem_Adapter(this, Global._paises.Where(x => x.CodContinente == cont.Id).ToList());
        }
    }
}