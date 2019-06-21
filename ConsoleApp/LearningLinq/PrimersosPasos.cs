using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.LearningLinq
{
    public class PrimersosPasos
    {
        public PrimersosPasos()
        {
            String[] QueryString = { "One", "Two", "Three", "Four", "Five" };
            var ThisQuery =
            from StringValue
            in QueryString
            select StringValue;
        }


    }
}
