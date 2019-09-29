using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOClasses
{
    public enum DbAck
    {
        [CustomDecription("Ok ừ thì là Ok! ừ Ok!")]
        Ok,
        [CustomDecription("Lỗi kết nối!")]
        NetworkError,
        [CustomDecription("Lỗi không xác định!")]
        Unknown,
        [CustomDecription("Lỗi Không tìm tìm thấy thao tác!")]
        MethoodNotFound,
        [CustomDecription("Lỗi dữ liệu không phù hợp!")]
        TypeDataErro,
        [CustomDecription("Dữ liệu null!")]
        DataNull,
        [CustomDecription("Tuổi độc giả phải từ 18 đến 55!")]
        AgeError,
        [CustomDecription("Năm xuất bản không đạt yêu cầu!")]
        PublishingYearError,




    };


    public class EnumUtils
    {
        static CustomDecription[] attributes;
        public static string stringValueOf(Enum value)
        {
            System.Reflection.FieldInfo fi = value.GetType().GetField(value.ToString());

            if (attributes.Length > 0)
            {

                return attributes[0].Descriptions;
            }
            else
            {
                return value.ToString();
            }
        }

        public static object enumValueOf(string value, Type enumType)
        {
            string[] names = Enum.GetNames(enumType);
            foreach (string name in names)
            {
                if (stringValueOf((Enum)Enum.Parse(enumType, name)).Equals(value))
                {
                    return Enum.Parse(enumType, name);
                }
            }

            throw new ArgumentException("The string is not a description or value of the specified enum.");
        }

        public static Enum SetstringValueOf(Enum value, String Description1)
        {
            System.Reflection.FieldInfo fi = value.GetType().GetField(value.ToString());
            attributes = (CustomDecription[])fi.GetCustomAttributes(typeof(CustomDecription), false);
            if (attributes.Length > 0)
            {
                attributes[0].Descriptions = Description1;
                return value;
            }
            else
            {
                return null;
            }
        }
    }

    public class CustomDecription : DescriptionAttribute
    {
        public string Descriptions { get; set; }


        public CustomDecription(String Description1)
        {
            Descriptions = Description1;
        }
        public CustomDecription()
        {

        }


    }

}
