using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovjust.DevBasic
{
    public class DevCommon
    {
        public static void ColumnFormatNumber(GridView grid, string fieldName, string format = "N")
        {
            grid.Columns[fieldName].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            grid.Columns[fieldName].DisplayFormat.FormatString = format;
        }

        public static void ColumnFormatDate(GridView grid, string fieldName, string format = "yyyy-MM-dd HH:mm")
        {
            grid.Columns[fieldName].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            grid.Columns[fieldName].DisplayFormat.FormatString = format;
        }

        /// <summary>
        /// 日期控件格式化
        /// </summary>
        /// <param name="edits"></param>
        public static void DateEditFormate(params DateEdit[] edits)
        {
            foreach (var edit in edits)
            {
                edit.Properties.DisplayFormat.FormatType = FormatType.DateTime;
                edit.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
                //edit.Properties.EditFormat.FormatType = FormatType.DateTime;
                //edit.Properties.EditFormat.FormatString = "yyyy-MM-dd";
                edit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                edit.Properties.Mask.EditMask = "yyyy-MM-dd";
                edit.Properties.TextEditStyle = TextEditStyles.Standard;
                //edit.Properties.ImmediatePopup
            }
        }

        /// <summary>
        /// 日期控件格式化
        /// </summary>
        /// <param name="edits"></param>
        public static void DateEditFormate(string formate = "yyyy-MM-dd", params RepositoryItemDateEdit[] edits)
        {
            foreach (var edit in edits)
            {
                edit.Properties.DisplayFormat.FormatType = FormatType.DateTime;
                edit.Properties.DisplayFormat.FormatString = formate;
                //edit.Properties.EditFormat.FormatType = FormatType.DateTime;
                //edit.Properties.EditFormat.FormatString = "yyyy-MM-dd";
                edit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                edit.Properties.Mask.EditMask = formate;
                edit.Properties.TextEditStyle = TextEditStyles.Standard;
                //edit.Properties.ImmediatePopup
            }
        }

        /// <summary>
        /// 日期(含时间)控件格式化
        /// </summary>
        /// <param name="edits"></param>
        public static void DateTimeEditFormate(params DateEdit[] edits)
        {
            foreach (var edit in edits)
            {
                edit.Properties.DisplayFormat.FormatType = FormatType.DateTime;
                edit.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
                edit.Properties.EditFormat.FormatType = FormatType.DateTime;
                edit.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
                edit.Properties.VistaEditTime = DefaultBoolean.True;
            }
        }

        /// <summary>
        /// 时间控件格式化
        /// </summary>
        /// <param name="edits"></param>
        public static void TimeEditFormate(params TimeEdit[] edits)
        {
            foreach (var edit in edits)
            {
                edit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                edit.Properties.Mask.EditMask = "HH:mm:ss";
            }
        }

    }
}
