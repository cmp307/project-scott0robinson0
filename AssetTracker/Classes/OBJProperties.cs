using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes
{
    public static class OBJProperties
    {
        public static List<string> GetNames(Object obj)
        {
            List<string> names = new List<string>();
            IList<PropertyInfo> props = new List<PropertyInfo>(obj.GetType().GetProperties());

            foreach (PropertyInfo prop in props)
            {
                // https://stackoverflow.com/questions/672412/how-to-get-name-of-a-class-property
                string propName = prop.Name.ToLower();
                string propValue = prop.GetValue(obj, null).ToString();
                if (propValue != null && propValue != "" && propValue != "-1")
                    names.Add(propName);
            }

            return names;
        }

        public static List<string> GetValues(Object obj)
        {
            List<string> values = new List<string>();
            // https://stackoverflow.com/questions/5508050/how-to-get-a-property-value-based-on-the-name
            IList<PropertyInfo> props = new List<PropertyInfo>(obj.GetType().GetProperties());

            foreach (PropertyInfo prop in props)
            {
                string propValue = prop.GetValue(obj, null).ToString();
                if (propValue != null && propValue != "" && propValue != "-1")
                    values.Add(propValue);
            }

            return values;
        }

        public static Dictionary<string, string> GetProperties(Object obj)
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            // https://stackoverflow.com/questions/5508050/how-to-get-a-property-value-based-on-the-name
            IList<PropertyInfo> props = new List<PropertyInfo>(obj.GetType().GetProperties());

            foreach (PropertyInfo prop in props)
            {
                string propValue = prop.GetValue(obj, null).ToString();
                string propName = prop.Name.ToLower();
                if (propValue != null && propValue != "" && propValue != "-1")
                    properties.Add(propName, propValue);
            }

            return properties;
        }
    }
}
