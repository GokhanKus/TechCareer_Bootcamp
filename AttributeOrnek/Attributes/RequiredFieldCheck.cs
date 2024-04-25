using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeOrnek.Attributes
{
    internal class RequiredFieldCheck
    {
        internal static bool Verify(Ogrenci instanceToVerify) //sadece belirli bir classa ait prop null check yapacaksak object'e gerek yok, genel bir attr ise object kullanılabilir
        {
            Type type = instanceToVerify.GetType();
            PropertyInfo[] propInfos = type.GetProperties();//belirtilen turun tum ozelliklerini dondurecektir BindingFlags'e gerek yok?
            foreach (var propInfo in propInfos)
            {
                //alttaki satir, eger propa birden fazla RequiredFieldAttribute tanimlanmis ise onları da alır
                //object[] requiredFieldsAttr = propInfo.GetCustomAttributes(typeof(RequiredFieldAttribute), true);

                //bu ise prop'a RequiredFieldAttribute tanimlanip tanimlanmadigina bakar
                if (Attribute.IsDefined(propInfo,typeof(RequiredFieldAttribute)))
                {
                    string value = propInfo.GetValue(instanceToVerify) as string;
                    if (string.IsNullOrEmpty(value))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
