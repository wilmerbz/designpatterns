using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter.Interpreter
{
    public class ClassExpression : TypeExpression
    {
        protected override string TypeExpressionReservedWord => "class";
    }
}
