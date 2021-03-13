using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter.Interpreter
{
    public class EnumExpression : TypeExpression
    {
        protected override string TypeExpressionReservedWord => "enum";
    }
}
