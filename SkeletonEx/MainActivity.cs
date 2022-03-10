using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;

namespace SkeletonEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private RecyclerView mrecyclerView;
        private RecyclerView.LayoutManager manager;
        private Adapter myAdapter;
        private Details _friendsDetails;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main);

            mrecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView1);
            mrecyclerView.AddItemDecoration(new DividerItemDecoration(this, DividerItemDecoration.Vertical));

            manager = new LinearLayoutManager(this);
            mrecyclerView.SetLayoutManager(manager);

            _friendsDetails = new Details();
            myAdapter = new Adapter(_friendsDetails, this);
            mrecyclerView.SetAdapter(myAdapter);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}