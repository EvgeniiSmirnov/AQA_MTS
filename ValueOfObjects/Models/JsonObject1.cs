using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueOfObjects.Models;

public class JsonObject1
{
    public string Name { get; set; }
    public int FieldValue { get; set; }
    public bool IsEnabled { get; set; }
    public object AnyObject { get; set; }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(FieldValue)}: {FieldValue}, {nameof(IsEnabled)}: {IsEnabled}, {nameof(AnyObject)}: {AnyObject}";
    }
}
