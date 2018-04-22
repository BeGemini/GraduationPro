using System;
using System.Text.RegularExpressions;

namespace GraduationCore.Common.Helper
{
    public class RegularHelper
    {
        //18位身份证号正则表达式
        private static readonly string IdNumberRegular18 = @"^[1-9]\d{5}(18|19|([23]\d))\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]$";
        //15位身份证号正则表达式
        private static readonly string IdNumberRegular15 = @"^[1-9]\d{5}\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{2}$";
        //2018年最新手机号正则表达式
        public static readonly string MobileRagular = @"^((13[0-9])|(14[5,7])|(15[0-3,5-9])|(17[0,3,5-8])|(18[0-9])|166|198|199|(147))\\d{8}$";
        //邮箱正则表达式
        private static readonly string MailRegular = @"^[A-Za-z0-9\u4e00-\u9fa5]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$";
        //固话正则表达式
        private static readonly string PhoneRegular = @"/^0?(13[0-9]|15[012356789]|17[013678]|18[0-9]|14[57])[0-9]{8}$/";
        //验证身份证
        public static bool CheckIdNumber18(string idNumber)
        {
            MatchCollection matchCollection = Regex.Matches(idNumber, IdNumberRegular18);
            return matchCollection.Count == 0 ? false : true;
        }
        public static bool CheckIdNumber15(string idNumber)
        {
            MatchCollection matchCollection = Regex.Matches(idNumber, IdNumberRegular15);
            return matchCollection.Count == 0 ? false : true;
        }

        //验证手机号
        public static bool CheckMobileNumber(string mobileNumber)
        {
            MatchCollection matchCollection = Regex.Matches(mobileNumber, MobileRagular);
            return matchCollection.Count == 0 ? false : true;
        }

        //验证电话号
        public static bool CheckPhoneNumber(string phoneNumber)
        {
            MatchCollection matchCollection = Regex.Matches(phoneNumber, PhoneRegular);
            return matchCollection.Count == 0 ? false : true;
        }

        public static bool CheckMail(string mail)
        {
            MatchCollection matchCollection = Regex.Matches(mail, MailRegular);
            return matchCollection.Count == 0 ? false : true;
        }
    }
}