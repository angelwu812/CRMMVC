using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace CRMMVC.Models
{
    public class 驗證手機電話格式Attribute : DataTypeAttribute
    {
        public 驗證手機電話格式Attribute()
            : base(DataType.Text)
          {
          }

        public override bool IsValid(object value)
        {
            var str = (string)value;
            Regex regEx = new Regex("^09[0-9]{2}-[0-9]{6}");
            return regEx.IsMatch(str.ToString());
           
        }

    }
}
