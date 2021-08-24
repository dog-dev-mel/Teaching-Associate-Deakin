using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Size_Qualifiers
{
    [Activity(Label = "Details")]
    public class Details : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Details);

            EditText id = FindViewById<EditText>(Resource.Id.textstudentid);
            id.Text = Intent.GetStringExtra("StudentID");

            EditText name = FindViewById<EditText>(Resource.Id.textstudentname);
            name.Text = Intent.GetStringExtra("StudentName");

            EditText mark = FindViewById<EditText>(Resource.Id.textstudentmark);
            mark.Text = Intent.GetStringExtra("StudentMark");

            Button backBtn = FindViewById<Button>(Resource.Id.backBtn);
            backBtn.Click += (sender, e) => { base.OnBackPressed(); };
        }
    }
}