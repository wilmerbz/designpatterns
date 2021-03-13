using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter.Interpreter
{
    public class InterfaceExpression : TypeExpression
    {
        protected override string TypeExpressionReservedWord => "interface";
    }
}
