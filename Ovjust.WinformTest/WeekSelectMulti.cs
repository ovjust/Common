using DevExpress.Skins;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ovjust.WinformTest
{
    public partial class WeekSelectMulti : Form
    {
        public WeekSelectMulti()
        {
            InitializeComponent();
            //dateNavigator1.SelectedDatesChanged+=
            Skin skin = CommonSkins.GetSkin(dateNavigator1.LookAndFeel);
            SkinElement elem = skin[CommonSkins.SkinButton];
            elem.Image.ImageCount = 0;
            elem.Color.BackColor = Color.Blue;

            dateNavigator1.Multiselect = false;
        }

        List<DateTime> listDates = new List<DateTime>();
        List<DateModel> listModel = new List<DateModel>();
        private void dateNavigator1_DoubleClick(object sender, EventArgs e)
        {
            var date=dateNavigator1.SelectionStart;
            if (listDates.Contains(date))
            {
                listDates.Remove(date);
            }
            else
            {
                listDates.Add(date);
            }
            //dateNavigator1.Refresh();
        }

        private void dateNavigator1_CustomDrawDayNumberCell(object sender, DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
           // //e.View=DevExpress.XtraEditors.Controls.DateEditCalendarViewType.
           //var style= e.BackgroundElementInfo;
           //if (e.Date.DayOfWeek == DayOfWeek.Monday)
           //{
           //    style.BackAppearance.BackColor = Color.Red;
           //    style.BackAppearance.BackColor2 = Color.Green;
           //    style.BackAppearance.BorderColor = Color.Yellow;
           //}
           //if (listDates.Contains(e.Date))
           //{

           //}


            //AppointmentBaseCollection collection = schedulerStorage.GetAppointments(new TimeInterval(e.Date, e.Date.AddDays(1)));
            //for (int i = 1; i < schedulerStorage.Appointments.Labels.Count; i++)
            //{
            //    AppointmentLabel label = schedulerStorage.Appointments.Labels[i];
            //    for (int j = 0; j < collection.Count; j++)
            //    {
            //        Appointment apt = collection[j];
            //        if (apt.LabelId == i)
            //        {
            //            e.Style.ForeColor = label.Color;
            //            return;
            //        }
            //    }
            //}
            var hotDate=dateNavigator1.HotDate;
            //dateNavigator1.d
            if (e.Date.DayOfWeek == DayOfWeek.Monday )
            {
                e.Style.ForeColor = Color.Green;
            }
            else
            {
                DisableDateCell(e);
            }
            if (listDates.Contains(e.Date))
            {
                DisableDateCell(e);
            }
        }

        private static void DisableDateCell(DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
            Rectangle rect = e.Bounds;
            rect.Inflate(-1, -1);
            e.Cache.FillRectangle(new SolidBrush(Color.Gray),new Rectangle( e.Bounds.Left+3,e.Bounds.Top+3,e.Bounds.Width-4,e.Bounds.Height-4));
            e.Cache.DrawString(e.Date.Day.ToString(), new Font(e.Style.Font, FontStyle.Bold), e.Cache.GetSolidBrush(e.Style.ForeColor), rect, e.Style.TextOptions.GetStringFormat());
            e.Handled = true;
        }

        private void imageListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WeekSelectMulti_Load(object sender, EventArgs e)
        {

        }

        private void imageListBoxControl1_DoubleClick(object sender, EventArgs e)
        {
            var index = imageListBoxControl1.SelectedIndex;
            imageListBoxControl1.Items.RemoveAt(index);
            imageListBoxControl1.ValueMember = "";
            var item = new ImageListBoxItem();
           
            //imageListBoxControl1.Items.Add(
        }


        class DateModel
        {
            public DateTime Date { set; get; }
            public string DateString
            {
                get
                {
                    var dateEnd = Date.AddDays(6);
                    var s = string.Format("{0:YY-mm-dd}~{1:mm-dd}", Date, dateEnd);
                    return Date.ToString();
                }
            }
            public DateModel(DateTime date)
            {
                Date = date;
            }
        }
    }
}
