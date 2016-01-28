using DevExpress.XtraEditors.Calendar;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Ovjust.WinformTest
{
    public class MyDateNavigator : DateNavigator
    {
        MyDateNavigatorPainter myPainter;
        public MyDateNavigatorPainter MyPainter
        {
            get { return myPainter; }
        }

        protected override DevExpress.XtraEditors.Drawing.DateEditPainter CreatePainter()
        {
            myPainter = new MyDateNavigatorPainter(this);
            return myPainter;
        }
    }

    public class MyDateNavigatorPainter : DateNavigatorPainter
    {
        DateTime currentMonth;
        public DateTime CurrentMonth
        {
            get { return currentMonth; }
        }

        public MyDateNavigatorPainter(DateNavigator control) : base(control) { }

        //protected override void DrawHeader(CalendarObjectInfoArgs info)
        //{
        //    DrawHeaderButton(info);
        //    DateEditInfoArgs args = info as DateEditInfoArgs;
        //    args.HeaderAppearance.DrawString(args.Cache, args.CurrentMonth.ToString("MMMM", args.DateFormat), args.EditMonth, new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
        //    args.HeaderAppearance.DrawString(args.Cache, args.CurrentMonth.ToString("yyyy", args.DateFormat), args.EditYear);
        //    DrawNavigationButtons(info);
        //}
        protected override void DrawHeader(CalendarObjectInfoArgs info)
        {
            base.DrawHeader(info);
            DateEditInfoArgs args = info as DateEditInfoArgs;
            currentMonth = args.CurrentMonth;
        }
    }
}
