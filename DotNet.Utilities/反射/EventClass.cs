using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace TfsTest1
{
    public class EventClass
    {
        public delegate void EventHandler1(object sender, EventArgs e);
        public EventHandler1 handle1;

        //public delegate 
//public delegate void RoutedEventHandler(object sender, RoutedEventArgs e);  


        public delegate string MyAction();
        public MyAction Action1;
        public Delegate Action2;
        public EventHandler EventHandlerField;
        public EventHandler EventHandlerProp { set; get; }
        public event EventHandler EventField; 
        public List<Delegate> EventProps = new List<Delegate>();
        public event EventHandler EventProp { add { EventProps.Add(value); } remove { EventProps.Remove(value); } }
        // base.Events.AddHandler(AspNetPager.EventPageChanging, value);
        public void DoEvents()
        {
            //if (Event1 != null)
            //    Event1(null,null);
        }

        /// <summary>
        /// 为控件清除已绑定事件
        /// </summary>
        /// <param name="control"></param>
        /// <param name="eventname"></param>
       public static  void ClearEvent(Control control, string eventname)
        {
            if (control == null) return;
            if (string.IsNullOrEmpty(eventname)) return;
            BindingFlags mPropertyFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic;
            BindingFlags mFieldFlags = BindingFlags.Static | BindingFlags.NonPublic;
            Type controlType = typeof(System.Windows.Forms.Control);
            PropertyInfo propertyInfo = controlType.GetProperty("Events", mPropertyFlags);
            EventHandlerList eventHandlerList = (EventHandlerList)propertyInfo.GetValue(control, null);
            FieldInfo fieldInfo = (typeof(Control)).GetField("Event" + eventname, mFieldFlags);
            Delegate d = eventHandlerList[fieldInfo.GetValue(control)];
            if (d == null) return;
            EventInfo eventInfo = controlType.GetEvent(eventname);
            foreach (Delegate dx in d.GetInvocationList())
                eventInfo.RemoveEventHandler(control, dx);
        }


       void TestClearClassEvent()
       {
           EventClass ec = new EventClass();
           var len = ec.EventProps.Count;
           for (var i = len - 1; i >= 0; i--)
           {
               ec.EventProp -= ec.EventProps[i] as EventHandler;
           }

           ec.Action1=null;// = TestClearClassEvent;
       }
    }
}
