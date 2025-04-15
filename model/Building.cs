using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Tools.model
{
    internal class Building
    {
        public string Name { get; set; } = string.Empty;
        public List<Recipe> Recipes { get; set; } = [];

        public override string ToString()
        {
            return Name;  // So wird es in der ComboBox angezeigt
        }
    }
}
