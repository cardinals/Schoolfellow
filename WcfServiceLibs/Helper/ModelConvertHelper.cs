using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibs.Helper
{
    /// <summary>
    /// 实体转换辅助类
    /// </summary>
    public class ModelConvertHelper<T> where T : new()
    {
        public static IList<T>  ConvertToModel(DataTable dt)
        {
            // 定义集合
            IList<T> ts = new List<T>();
            // 获得此模型的类型
            Type type = typeof(T);
            string tempName = "";
            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                // 获得此模型的公共属性
                PropertyInfo[] propertys = t.GetType().GetProperties();

                foreach (PropertyInfo p in propertys)
                {
                    tempName = p.Name;

                    // 检查DataTable是否包含此列
                    if (dt.Columns.Contains(tempName))
                    {
                        // 判断此属性是否有Setter
                        if (!p.CanWrite) continue;

                        object value = dr[tempName];
                        if (p.PropertyType == typeof(string))
                        {
                            p.SetValue(t, dr[tempName], null);
                        }
                        else if (p.PropertyType == typeof(int))
                        {
                            p.SetValue(t, int.Parse(dr[tempName].ToString()), null);
                        }
                        else if (p.PropertyType == typeof(DateTime))
                        {
                            p.SetValue(t, DateTime.Parse(dr[tempName].ToString()), null);
                        }
                        else if (p.PropertyType == typeof(float))
                        {
                            p.SetValue(t, float.Parse(dr[tempName].ToString()), null);
                        }
                        else if (p.PropertyType == typeof(double))
                        {
                            p.SetValue(t, double.Parse(dr[tempName].ToString()), null);
                        }
                    }
                }
                ts.Add(t);
            }
            return ts;
        }
    }
}