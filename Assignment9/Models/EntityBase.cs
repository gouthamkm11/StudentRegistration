using Assignment9.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace Assignment9.Models
{
    public class EntityBase : IEntity
    {
        public void SetFields(DataRow dr)
        {
            Type tp = this.GetType();
            foreach (PropertyInfo pi in tp.GetProperties())
            {
                if (null != pi && pi.CanWrite)
                {
                    string nm = pi.PropertyType.Name.ToUpper();
                    if (pi.PropertyType.Name.ToUpper() != "BINARY")
                        pi.SetValue(this, dr[pi.Name], null);
                }
            }
        }
    }
}
