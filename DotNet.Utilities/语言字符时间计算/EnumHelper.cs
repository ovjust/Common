using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DotNet_Utilities
{
    public static class EnumHelper
    {
        /// <summary> 
        /// 获得枚举类型数据项（不包括空项）
        /// </summary> 
        /// <param name="enumType">枚举类型</param> 
        /// <returns>Value/Text列表</returns> 
        public static IList<object> GetItems(this Type enumType)
        {
            if (!enumType.IsEnum)
                throw new InvalidOperationException();

            IList<object> list = new List<object>();

            // 获取Description特性 
            Type typeDescription = typeof(DescriptionAttribute);
            // 获取枚举字段
            FieldInfo[] fields = enumType.GetFields();
            foreach (FieldInfo field in fields)
            {
                string _values = string.Empty;

                if (!field.FieldType.IsEnum)
                    continue;

                // 获取枚举值
                int value = (int)enumType.InvokeMember(field.Name, BindingFlags.GetField, null, null, null);

                // 不包括空项
                if (value > 0)
                {
                    string text = string.Empty;
                    object[] array = field.GetCustomAttributes(typeDescription, false);

                    if (array.Length > 0)
                    {
                        _values = ((DescriptionAttribute)array[0]).Description;
                        text = field.Name;
                    }

                    //添加到列表
                    list.Add(new { Value = _values, Text = text });
                }
            }
            return list;
        }


        /// <summary> 
        /// 获得枚举类型数据项（不包括空项）
        /// </summary> 
        /// <param name="enumType">枚举类型</param> 
        /// <returns>Value/Text列表</returns> 
        public static IList<object> GetItems<T>()
        {
            Type enumType = typeof(T);
            if (!enumType.IsEnum)
                throw new InvalidOperationException();

            IList<object> list = new List<object>();

            // 获取Description特性 
            Type typeDescription = typeof(DescriptionAttribute);
            // 获取枚举字段
            FieldInfo[] fields = enumType.GetFields();
            foreach (FieldInfo field in fields)
            {
                string _values = string.Empty;

                if (!field.FieldType.IsEnum)
                    continue;

                // 获取枚举值
                int value = (int)enumType.InvokeMember(field.Name, BindingFlags.GetField, null, null, null);

                // 不包括空项
                if (value > 0)
                {
                    string text = string.Empty;
                    object[] array = field.GetCustomAttributes(typeDescription, false);

                    if (array.Length > 0)
                    {
                        _values = ((DescriptionAttribute)array[0]).Description;
                        text = field.Name;
                    }

                    //添加到列表
                    list.Add(new { Value = _values, Text = text });
                }
            }
            return list;
        }

        /// <summary>
        /// 获得枚举value对应的名称
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetEnumName<T>(object value) where T : struct
        {
            try
            {
                return System.Enum.GetName(typeof(T), value);
            }
            catch
            {
                return string.Empty;
            }
        }

        public static Dictionary<string, int> GetDictionarys(Type EnumType)
        {
            Dictionary<string, int> Dict = new Dictionary<string, int>();
            Array valueArray = Enum.GetValues(EnumType);
            Array nameArray = Enum.GetNames(EnumType);
            if (nameArray == null) return Dict;
            for (int i = 0; i < nameArray.Length; i++)
            {
                if (nameArray.GetValue(i) != null && !Dict.ContainsKey(nameArray.GetValue(i).ToString()))
                {
                    Dict.Add(nameArray.GetValue(i).ToString(), (int)valueArray.GetValue(i));
                }
            }
            return Dict;
        }

    }
}
