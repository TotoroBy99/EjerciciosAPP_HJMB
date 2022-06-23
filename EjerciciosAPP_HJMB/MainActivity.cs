using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.RecyclerView;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;

namespace EjerciciosAPP_HJMB
{
    [Activity(Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView listaPais;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            listaPais = FindViewById<ListView>(Resource.Id.listView1);
            listaPais.Adapter = new Continentes_Adapter(this, Global._continentes);

            listaPais.ItemClick += ListaPais_ItemClick;

        }

        private void ListaPais_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(Paises_Activity));
            Continentes cont = Global._continentes[e.Position];
            i.PutExtra("id", cont.Id);
            StartActivity(i);
        }
    }
}