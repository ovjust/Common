//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Web.sc

//namespace DotNet_Utilities.Json
//{
//    class Json2Obj
//    {
//        //使用示例
//        //staticvoid Main(string[] args)
//        //{
//        //    string json = "{name:'hooyes',pwd:'hooyespwd',books:{a:'红楼梦',b:'水浒传',c:{arr:['宝玉','林黛玉']}},arr:['good','very good']}";

//        //    dynamic dy = ConvertJson(json);

//        //    Console.WriteLine(dy.name);

//        //    Console.WriteLine(dy.books.a);

//        //    Console.WriteLine(dy.arr[1]);

//        //    foreach (var s in dy.books.c.arr)
//        //    {
//        //        Console.WriteLine(s);
//        //    }

//        //    Console.Read();

//        //}


//        static dynamic ConvertJson(string json)
//        {
//            JavaScriptSerializer jss = new JavaScriptSerializer();
//            jss.RegisterConverters(new JavaScriptConverter[] { new DynamicJsonConverter() });
//            dynamic dy = jss.Deserialize(json, typeof(object)) as dynamic;
//            return dy;
//        }


       

//public class DynamicJsonConverter : JavaScriptConverter
//    {
//        public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
//        {
//            if (dictionary ==null)
//                throw new ArgumentNullException("dictionary");

//            if (type ==typeof(object))
//            {
//                return new DynamicJsonObject(dictionary);
//            }

//            return null;
//        }

//        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
//        {
//            throw new NotImplementedException();
//        }

//        public override IEnumerable<Type> SupportedTypes
//        {
//            get { return new ReadOnlyCollection<Type>(new List<Type>(new Type[] { typeof(object) })); }
//        }
//    }



//public class DynamicJsonObject : DynamicObject
//    {
//        private IDictionary<string, object> Dictionary { get; set; }

//        public DynamicJsonObject(IDictionary<string, object> dictionary)
//        {
//            this.Dictionary = dictionary;
//        }

//        public override bool TryGetMember(GetMemberBinder binder, outobject result)
//        {
//            result =this.Dictionary[binder.Name];

//            if (result is IDictionary<string, object>)
//            {
//                result =new DynamicJsonObject(result as IDictionary<string, object>);
//            }
//            else if (result is ArrayList && (result as ArrayList) is IDictionary<string, object>)
//            {
//                result =new List<DynamicJsonObject>((result as ArrayList).ToArray().Select(x =>new DynamicJsonObject(x as IDictionary<string, object>)));
//            }
//            else if (result is ArrayList)
//            {
//                result =new List<object>((result as ArrayList).ToArray());
//            }

//            return this.Dictionary.ContainsKey(binder.Name);
//        }
//    }
//    }
//}
