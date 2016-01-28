using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DotNet_Utilities
{
    public class GradientColorHelper
    {
        #region 双色渐变
        /// <summary>
        /// 获取渐变色
        /// </summary>
        /// <param name="color1">value1对应颜色</param>
        /// <param name="color2">value2对应颜色</param>
        /// <param name="value1">value1小于value2</param>
        /// <param name="value2"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Color GetColorByValue(Color color1, Color color2,decimal value1,decimal value2, decimal value)
        {
            //if (value > value2)
            //    value = value2;
            //else if (value < value1)
            //    value = value1;
            var posi = (value - value1) / (value2 - value1);
            var c = GetColorByValue(color1, color2, posi);
            return c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color1"></param>
        /// <param name="color2"></param>
        /// <param name="value">0~1</param>
        /// <returns></returns>
        public static Color GetColorByValue(Color color1, Color color2, decimal value)
        {
            if (value < 0)
                value = 0;
            else if (value > 1)
                value = 1;
            var a= GetPositionValue(color1,color2 ,"A",value ) ;
            var r = GetPositionValue(color1, color2, "R", value);
            var g = GetPositionValue(color1, color2, "G", value);
            var b = GetPositionValue(color1, color2, "B", value);
            Color colorNew =Color.FromArgb(a,r,g,b);
            return colorNew;
        }
        #endregion
        #region 带中间色 三色渐变
        /// <summary>
        /// 获取渐变色
        /// </summary>
        /// <param name="color1">value1对应颜色</param>
        /// <param name="color2">value2对应颜色</param>
        /// <param name="value1">value1小于value2</param>
        /// <param name="value2"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Color GetColorByValue(Color color1, Color color2, Color middle, decimal value1, decimal value2, decimal value)
        {
            //if (value > value2)
            //    value = value2;
            //else if (value < value1)
            //    value = value1;
            var posi = (value - value1) / (value2 - value1);
            var c = GetColorByValue(color1, color2, middle, posi);
            return c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color1"></param>
        /// <param name="color2"></param>
        /// <param name="value">0~1</param>
        /// <returns></returns>
        public static Color GetColorByValue(Color color1, Color color2, Color middle, decimal value)
        {
            if (value < 0)
                value = 0;
            else if (value > 1)
                value = 1;
            var half = 0.5m;
            if (value <= half)
            {
                color2 = middle;
                value = value * 2;
            }
            else
            {
                color1 = middle;
                value = (value - half) * 2;
            }
            var a = GetPositionValue(color1, color2, "A", value);
            var r = GetPositionValue(color1, color2, "R", value);
            var g = GetPositionValue(color1, color2, "G", value);
            var b = GetPositionValue(color1, color2, "B", value);
            Color colorNew = Color.FromArgb(a, r, g, b);
            return colorNew;
        }
        #endregion

        private static byte GetPositionValue( byte color1,  byte color2, decimal value)
        {
            var b = (color2 - color1) * value + color1;
            return Convert.ToByte( b);
        }

        private static byte GetPositionValue(Color color1, Color color2,string prop, decimal value)
        {
            PropertyInfo info = typeof(Color).GetProperty(prop);
            var c1 = (byte)info.GetValue(color1, null);
            var c2 = (byte)info.GetValue(color2, null);
            var b = GetPositionValue(c1,c2,value);
            return b;
        }
    }
}
