using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    public class  Rectangle : shap
    {
        public override float getArea(float width, float height)
        {
            return width * height;
        }

    }
}
