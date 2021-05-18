using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOef3
{
	static class Filter<T>
	{
        public static List<T> FilterMethod(List<T> lijst, string propName, Predicate<object> filterMethod)
        {
            List<T> tempProduct = new List<T>();
            foreach (var product in lijst)
            {
                if (filterMethod(product.GetType().GetProperty(propName).GetValue(product)))
                    tempProduct.Add(product);
            }
            return tempProduct;
        }
    }
}
