using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExtendedOperator
{
    public static class Core
    {
        public static OperatorBuilder Or(this OperatorBuilder builder)
        {
            return builder;
        }
    }

    public class OperatorBuilder
    {
        public OperatorBuilder()
        {
            OrValues = new List<bool>();
            AndValues = new List<bool>();
        }
        public List<bool> OrValues { private get; set; }
        public List<bool> AndValues { private get; set; }

    }
}
