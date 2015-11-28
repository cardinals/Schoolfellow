using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibs.Model
{
   
    [DataContract]
    public class SchoolFellow
    {
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string RealName { get; set; } //姓名  金义刚
        [DataMember]
        public string Sex { get; set; }//性别 
        [DataMember]
        public string SpecialityName { get; set; } //专业  有色金属冶炼
      
        [DataMember]
        public string ClassName { get; set; } //班级  1班
        [DataMember]
        public string HeadPicture { get; set; } // 照片  ../images/likeness/men_tiny.gif
        [DataMember]
        public string Graduation { get; set; }  //毕业时间，如1993   
        [DataMember]
        public string WorkPlace { get; set; }  //工作地点  
        [DataMember]
        public string Address { get; set; }   //通讯地址  江西省核工业地质局二六四大队
        [DataMember]
        public string Handset { get; set; }   //手机号码  13211144546
        [DataMember]
        public string Email { get; set; }    //邮箱
        [DataMember]
        public string Birthday { get; set; }
        [DataMember]
        public string QQ { get; set; }
        public SchoolFellow() { }
        public SchoolFellow(int UserID, string RealName, string Sex, string SpecialityName,
          string ClassName, string HeadPicture, string Graduation, string WorkPlace,
          string Address, string Handset, string Email,string Birthday,string QQ)
        {
            this.UserID = UserID;
            this.RealName = RealName;
            this.Sex = Sex;
            this.SpecialityName = SpecialityName;
            this.ClassName = ClassName;
            this.HeadPicture = HeadPicture;
            this.Graduation = Graduation;
            this.WorkPlace = WorkPlace;
            this.Address = Address;
            this.Handset = Handset;
            this.Email = Email;
            this.Birthday = Birthday;
            this.QQ = QQ;
        }
        public override string ToString()
        {
            return " RealName: " + RealName + "Sex:" + Sex + "SpecialityName:"
                + SpecialityName + "ClassName: " + ClassName + " HeadPicture: "
                + HeadPicture + " Graduation: " + Graduation + " WorkPlace : " +
                WorkPlace + "Address: " + Address + " Handset: " + Handset +
                " Email: " + Email + "QQ" + QQ + "Birthday" + Birthday;
        }
    }
}


// 姓名，性别，专业，班级，毕业时间，工作单位，通讯地址，电话号码，照片,邮箱
//[In_ClassID] [int] NOT NULL,
//UserID, UserName, UserPassword, RealName, Images, Min_Image, PasswordHint, HintAnswer, NickName, Sex, HeadPicture, Min_HeadPicture, 
//                   Birthday, Email, HomePage, QQ, MSN, HomePhone, WorkPhone, Handset, WorkPlace, Postalcode, Address, Maxim, In_ClassID, In_Schoolfellow, 
//                   IsConfirmRegist, UserPower, UserNameUp, CollegeName, SpecialityName, Graduation, ClassName
// 151010	sxan1	13612621937	宋小安	<二进制数据>	<二进制数据>				男	../images/likeness/20081214093509209_DSCF2260 副本.jpg	../images/likeness/x_20081214093509209_DSCF2260 副本.jpg		sxan1@sina.com					0757-26695050	13380549713		528300	广东省佛山市顺德区勒流职业技术学校		1918	0	0	0	0	机电工程学院	机械制造与工艺	1989	1班
// 
