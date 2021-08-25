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

namespace Size_Qualifiers
{
    public class StudentData
    {
        public StudentData(string v1, string v2, string v3)
        {
            this.StudentId = v1;
            this.StudentName = v2;
            this.StudentMark = v3;
        }

        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentMark { get; set; }

        public override string ToString()
        {
            return string.Format("[StudentId={0}, StudentName={1}, StudentMark={2}]", StudentId, StudentName, StudentMark);
        }
    }
}