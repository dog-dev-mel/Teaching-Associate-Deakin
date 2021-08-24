using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Size_Qualifiers
{
    [Activity(Label = "StudentListActivity")]
    public class StudentsListActivity : ListActivity
    {
        StudentData[] studentsData;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            studentsData = new StudentData[] { new StudentData("01", "Alice", "80"), new StudentData("02", "Bill", "75"), new StudentData("03", "Cook", "80"), new StudentData("04", "Dan", "70") };
            ListAdapter = new ArrayAdapter<StudentData>(this, Resource.Layout.SimpleListItem1, studentsData);
        }


        protected override void OnListItemClick(ListView i, View v, int position, long id)
        {
            var t = studentsData[position];
            Android.Widget.Toast.MakeText(this, t.StudentId, Android.Widget.ToastLength.Short).Show();


            var detailsActivity = new Intent(this, typeof(Details));
            detailsActivity.PutExtra("StudentID", t.StudentId);
            detailsActivity.PutExtra("StudentName", t.StudentName);
            detailsActivity.PutExtra("StudentMark", t.StudentMark);
            StartActivity(detailsActivity);
        }
    }
}