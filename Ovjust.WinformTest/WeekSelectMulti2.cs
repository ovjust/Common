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
    public partial class WeekSelectMulti2 : Form
    {
        public WeekSelectMulti2()
        {
            InitializeComponent();
            //dateNavigator1.SelectedDatesChanged+=
            Skin skin = CommonSkins.GetSkin(dateNavigator1.LookAndFeel);
            SkinElement elem = skin[CommonSkins.SkinButton];
            elem.Image.ImageCount = 0;
            elem.Color.BackColor = Color.Blue;

            dateNavigator1.Multiselect = false;
        }

        private void WeekSelectMulti_Load(object sender, EventArgs e)
        {
            ImageListBoxBind();
        }

        //List<DateTime> listDates = new List<DateTime>();
        //List<DateModel> listModel = new List<DateModel>();
        SortedList<DateTime, DateModel> listModel = new SortedList<DateTime, DateModel>();
        DayOfWeek firstDay = DayOfWeek.Monday;

        private void dateNavigator1_DoubleClick(object sender, EventArgs e)
        {
            var date = dateNavigator1.SelectionStart;

            if (date.DayOfWeek == firstDay)
            {
                if (listModel.Keys.Contains(date))
                {
                    RemoveDate(date);
                }
                else
                {
                    var model = new DateModel(date);
                    listModel.Add(date, model);
                    var index = listModel.IndexOfKey(date);
                    //imageListBoxControl1.Items.Insert(index,new ImageListBoxItem( model));
                    ImageListBoxRebind();
                    dateNavigator1.Refresh();
                }
            }
        }

        private void RemoveDate(DateTime date)
        {
            var model = listModel[date];
            listModel.Remove(date);
            ImageListBoxRebind();
            dateNavigator1.Refresh();
        }

        private void ImageListBoxRebind()
        {
            imageListBoxControl1.DataSource = listModel.Values.ToList();
        }

        void ImageListBoxBind()
        {
            imageListBoxControl1.DisplayMember = "DateString";
            imageListBoxControl1.ValueMember = "Date";
            imageListBoxControl1.ImageIndexMember = "ImageIndex";
            //imageListBoxControl1.DataSource = listModel.Values;//.ToList()
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
            //var hotDate = dateNavigator1.HotDate;
            //dateNavigator1.d


             //var month = dateNavigator1.MyPainter.CurrentMonth.Month;
          

            if (e.Date.DayOfWeek == DayOfWeek.Monday)
            {
                e.Style.ForeColor = Color.Green;
            }
            else
            {
                DisableDateCell(e);
            }
            if (listModel.Keys.Contains(e.Date))
            {
                DisableDateCell(e);
            }
        }

        private static void DisableDateCell(DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
            //var color = Color.LightGray;
            Rectangle rect = e.Bounds;
            rect.Inflate(-1, -1);
            e.Cache.FillRectangle(new SolidBrush(Color.LightSteelBlue), new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, e.Bounds.Width - 4, e.Bounds.Height - 4));
            e.Cache.DrawString(e.Date.Day.ToString(), new Font(e.Style.Font, FontStyle.Bold), e.Cache.GetSolidBrush(e.Style.ForeColor), rect, e.Style.TextOptions.GetStringFormat());
            e.Handled = true;
        }





        private void imageListBoxControl1_DoubleClick(object sender, EventArgs e)
        {
            if (imageListBoxControl1.SelectedItem == null)
                return;
            var item = imageListBoxControl1.SelectedItem;
            //imageListBoxControl1.Items.RemoveAt(imageListBoxControl1.SelectedIndex);
            var date = (item as DateModel).Date;
            //listModel.Remove(date);
            //dateNavigator1.Refresh();
            RemoveDate(date);
        }



        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listModel.Clear();
            dateNavigator1.Refresh();
            ImageListBoxRebind();
        }

        private void btnAddMonth_Click(object sender, EventArgs e)
        {
            var date = dateNavigator1.MyPainter.CurrentMonth;
            var month = date.Month;
            if(date.DayOfWeek!=firstDay)
            {
                if (date.DayOfWeek < firstDay)
                    date = date.AddDays((int)firstDay);
                else
                    date = date.AddDays(7 + (int)firstDay - (int)date.DayOfWeek);
                }
            while (date.Month == month)
            {
                if (!listModel.Keys.Contains(date))
                {
                    listModel.Add(date, new DateModel(date));
                }
                date=  date.AddDays(7);
            }
            dateNavigator1.Refresh();
            ImageListBoxRebind();
        }

        private void btnClearMonth_Click(object sender, EventArgs e)
        {
            var month = dateNavigator1.MyPainter.CurrentMonth;
            var dates=listModel.Keys.Where(p=>p.Year==month.Year&&p.Month==month.Month).ToList();
            foreach (var date in dates)
            {
                listModel.Remove(date);
            }
            dateNavigator1.Refresh();
            ImageListBoxRebind();
        }


        class DateModel
        {
            public DateTime Date { set; get; }
            public string DateString
            {
                get
                {
                    var dateEnd = Date.AddDays(6);
                    var s = string.Format("{0:yyyy年MM月 dd}~{1:dd}", Date, dateEnd);
                    return s;
                }
            }
            public int imageIndex { set; get; }
            public DateModel(DateTime date)
            {
                Date = date;
            }
        }

    }
}
