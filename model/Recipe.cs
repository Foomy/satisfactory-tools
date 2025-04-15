using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Tools.model
{
    internal class Recipe
    {
        public string Name { get; set; } = string.Empty;
        public int Input {  get; set; } = 0;
        public List<Material> Materials { get; set; } = [];

        public override string ToString()
        {
            return Name;  // So wird es in der ComboBox angezeigt
        }
    }
}
