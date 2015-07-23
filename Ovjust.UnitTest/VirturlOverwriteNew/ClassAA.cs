using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovjust.UnitTest.VirturlOverwriteNew
{
    public class ClassAA:ClassA
    {
        string text = "aa";
        string editValue = "bb";
        string newValue = "cc";

        public  string VirtualNullText
        {
            get { return text; }
            set { text = value; }
        }




        public virtual string VirtualVirtualValue
        {
            get { return editValue; }
            set { editValue = value; }
        }


        public virtual string NullVirtualValue
        {
            get { return editValue; }
            set { editValue = value; }
        }

        //public override string NullOverrideValue
        //{
        //    get { return editValue; }
        //    set { editValue = value; }
        //}

        public  override string VirtualOverrideValue
        {
            get { return editValue; }
            set { editValue = value; }
        }



        public new string NullNewValue
        {
            get { return newValue; }
            set { newValue = value; }
        }

        public virtual new string NullNewVirtualValue
        {
            get { return newValue; }
            set { newValue = value; }
        }

        public virtual new string VirtualNewValue
        {
            get { return newValue; }
            set { newValue = value; }
        }

        public virtual new string VirtualNewVirtualValue
        {
            get { return newValue; }
            set { newValue = value; }
        }

    }
}
