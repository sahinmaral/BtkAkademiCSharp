using System;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = false)]
    internal class RequiredPropertyAttribute : Attribute
    {
        
    }
}
