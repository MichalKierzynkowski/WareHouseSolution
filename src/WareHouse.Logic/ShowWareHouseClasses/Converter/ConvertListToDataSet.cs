using System;
using System.Collections.Generic;
using System.Data;

namespace WareHouse.Logic.ShowWareHouseClasses.Converter
{
    public static class ConvertListToDataSet
    {
        public static DataSet ToDataSet<T>(this IEnumerable<T> list)
        {

            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                t.Columns.Add(propInfo.Name, propInfo.PropertyType);
            }

            //go through each property on T and add each value to the table
            foreach (T item in list)
            {
                DataRow row = t.NewRow();
                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null);
                }

                //This line was missing:
                t.Rows.Add(row);
            }


            return ds;
        }
    }
}
