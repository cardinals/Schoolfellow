using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using WcfServiceLibs.Helper;
using WcfServiceLibs.Model;


namespace WcfServiceLibs
{      
    public class GetFellowInfo:  IGetFellowInfo
    {
        public List<SchoolFellow> getSchoolFellowsList(Stream data)
        {
            StreamReader reader = new StreamReader(data, Encoding.UTF8);
            string json = reader.ReadToEnd();
            Console.WriteLine(json);
            JavaScriptSerializer js = new JavaScriptSerializer();
            SchoolFellow list = js.Deserialize<SchoolFellow>(json);
            Console.WriteLine(list.ToString());
            List<SchoolFellow> jsonbackLists = new getList().GetList(list);
            Console.WriteLine("------"+DateTime.Now.ToString()+"-------");
            foreach (SchoolFellow stu in jsonbackLists)
            {
                Console.WriteLine(stu.RealName 
                    + "---" + stu.Address + "---" + stu.Sex+ "---" + stu.SpecialityName);
            }
            return jsonbackLists;
        }

        public SchoolFellow getSchoolFellows(string id="0")
        {
            try
            {
                 int Int_id = Convert.ToInt32(id);
                 Console.WriteLine(Int_id);
                 return new getList().getOne(Int_id);
            }catch(Exception e){}
            return null;
        }
    }
}
