using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovjust.UnitTest.VirturlOverwriteNew
{
    public class ClassA
    {
        string text = "a";
        string editValue = "b";
        string newValue = "c";

        public virtual string VirtualNullText
        {
            get { return text; }
            set { text = value; }
        }




        public virtual string VirtualVirtualValue
        {
            get { return editValue; }
            set { editValue = value; }
        }


        public  string NullVirtualValue
        {
            get { return editValue; }
            set { editValue = value; }
        }

        public  string NullOverrideValue
        {
            get { return editValue; }
            set { editValue = value; }
        }

        public virtual string VirtualOverrideValue
        {
            get { return editValue; }
            set { editValue = value; }
        }



        public string NullNewValue
        {
            get { return newValue; }
            set { newValue = value; }
        }

        public string NullNewVirtualValue
        {
            get { return newValue; }
            set { newValue = value; }
        }

        public virtual string VirtualNewValue
        {
            get { return newValue; }
            set { newValue = value; }
        }

        public virtual string VirtualNewVirtualValue
        {
            get { return newValue; }
            set { newValue = value; }
        }
    }
}
