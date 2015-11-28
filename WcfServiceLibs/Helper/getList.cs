using CommonHelpDb.Dataconver;
using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibs.Model;

namespace WcfServiceLibs.Helper
{
    public class getList
    {
          public SchoolFellow getOne(int id)
          {
              string sql = "select top 10 RealName,Sex,HeadPicture,Birthday,Email,QQ,Handset,Address,WorkPlace,SpecialityName,Graduation,ClassName from T_User "
              + "where UserID=@id";
              SqlParameter p = new SqlParameter("@id",id);
              DataTable dt = DbHelperSQL.Query(sql, p).Tables[0];
              Console.WriteLine(dt.Rows[0][1]);
              if(dt!=null)
              {
                   DataRow row =  dt.Rows[0];
                   SchoolFellow schoolFellow = new SchoolFellow(
                       id, row["RealName"].ToString(), 
                       row["Sex"].ToString(), row["SpecialityName"].ToString(),
                       row["ClassName"].ToString(), row["HeadPicture"].ToString(), 
                       row["Graduation"].ToString(), row["WorkPlace"].ToString(),
                       row["Address"].ToString(), row["Handset"].ToString(), 
                       row["Email"].ToString(), row["Birthday"].ToString(), row["QQ"].ToString());
                   Console.WriteLine(schoolFellow.ToString());
                   Console.WriteLine("------" + DateTime.Now.ToString() + "-------");
                   Console.WriteLine(sql);
                   Console.WriteLine(schoolFellow.ToString());
                  return schoolFellow;
              }
              return null;
          }
         public List<SchoolFellow> GetList(SchoolFellow schoolFellow)
         {
            List<SqlParameter> pms = new List<SqlParameter>();
            List<string> sqls = new List<string>();
            string sql = "select top 10 UserID, RealName,Sex,HeadPicture,Birthday,Email,QQ,Handset,Address,CollegeName,SpecialityName,Graduation,ClassName from T_User";
            if(!string.IsNullOrEmpty(schoolFellow.RealName))
            {
                pms.Add(new SqlParameter("@RealName", schoolFellow.RealName));
                sqls.Add("RealName like " + "'%"+schoolFellow.RealName+"%'");
            }
            if (!string.IsNullOrEmpty(schoolFellow.SpecialityName))
            {
                pms.Add(new SqlParameter("@SpecialityName", schoolFellow.SpecialityName));
                sqls.Add("SpecialityName like " + "'%" + schoolFellow.SpecialityName + "%'");
            }
            if (!string.IsNullOrEmpty(schoolFellow.ClassName))
            {
                pms.Add(new SqlParameter("@ClassName", schoolFellow.ClassName));
                sqls.Add("ClassName like " + "'%" + schoolFellow.ClassName + "%'");
            }
            if (!string.IsNullOrEmpty(schoolFellow.Graduation))
            {
                pms.Add(new SqlParameter("@Graduation", schoolFellow.Graduation));
                sqls.Add("Graduation like " + "'%" + schoolFellow.Graduation + "%'");
            }
            if (!string.IsNullOrEmpty(schoolFellow.WorkPlace))
            {
                pms.Add(new SqlParameter("@WorkPlace", schoolFellow.WorkPlace));
                sqls.Add("WorkPlace like " + "'%" + schoolFellow.WorkPlace + "%'");
            }
            if (!string.IsNullOrEmpty(schoolFellow.Address))
            {
                pms.Add(new SqlParameter("@Address", schoolFellow.Address));
                sqls.Add("Address like " + "'%" + schoolFellow.Address + "%'");
            }
            if(sqls.Count>0)
            {
                sql += " where "+ string.Join(" and ", sqls.ToArray());
            }
            Console.WriteLine(sql);
            DataTable data = DbHelperSQL.Query(sql,pms.ToArray()).Tables[0];
            List<SchoolFellow> list = (List<SchoolFellow>)ModelConvertHelper<SchoolFellow>.ConvertToModel(data);
            return list;
        }
        
    }
}
