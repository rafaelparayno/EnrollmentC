using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models.Timetable
{
    static class TimeTableModel
    {

        public static string start;

        public static string end;

        public static void setStart(string st)
        {
            start = st;
        }

        public static void setEnd(string en)
        {
            end = en;
        }

        public static void addTime(ref ListView lv)
        {
            string selected = start + " " + end;
            ListViewItem lvI = new ListViewItem();
            lv.Text = selected;
        }
    }
}
