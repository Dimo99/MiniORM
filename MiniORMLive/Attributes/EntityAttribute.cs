using System;

namespace MiniORMLive.Attributes
{
    class EntityAttribute : Attribute
    {
        public string TableName { get; set; }
    }
}
