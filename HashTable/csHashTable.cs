using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class csHashTable
{
    public List<object> keys = new List<object>();
    public List<object> values = new List<object>();
    public object this[object key]
    {
        get 
        {
            int index = keys.IndexOf(key);
            if (index == -1)
            { return null; }
            else 
            { return values[index]; }
        }
        set 
        {
            if (keys.Contains(key))
            {
                int index = keys.IndexOf(key);
                values[index] = value;
            }
            else
            {
                keys.Add(key);
                values.Add(value);
            }
        }
    }

    public object Get(object key)
    {
        int index = keys.IndexOf(key);
        return values[index];
    }

    public void Add(object key, object value)
    {
        keys.Add(key);
        values.Add(value);
    }

    public void Remove(object key)
    {
        int index = keys.IndexOf(key);
        keys.RemoveAt(index);
        values.RemoveAt(index);
    }

    public void Clear()
    {
        keys = new List<object>();
        values = new List<object>();
    }
}
