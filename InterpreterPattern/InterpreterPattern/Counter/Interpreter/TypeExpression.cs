using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter.Interpreter
{
    public abstract class TypeExpression : Expression
    {
        protected abstract string TypeExpressionReservedWord { get; }

        protected override bool InterpretLine(Context context)
        {
            var line = context.Line;
            bool isType = ContainsReservedWord(line, TypeExpressionReservedWord);

            if (isType)
            {
                var typeExpressionParts = line.Split(':');
                var leftTypeExpressionPart = typeExpressionParts[0];

                var typeDefinitionParts = leftTypeExpressionPart.Split(" ");
                var typeName = typeDefinitionParts[typeDefinitionParts.Length - 1];
                context.PartName = typeName;
                context.LineHandled = true;
            }
            return isType;
        }

        protected virtual bool ContainsReservedWord(string line, string reservedWord)
        {
            var result = line.StartsWith($"{reservedWord} ") || line.Contains($" {reservedWord} ");

            return result;
        }
    }
}
