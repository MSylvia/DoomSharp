using System;
using System.Reflection;
using System.Reflection.Emit;

namespace DoomSharp
{
    public sealed class LessOrEqualExpression : GreaterExpression
    {
        public LessOrEqualExpression(Expression left,Expression right) : base(left,right)
        {
        }

        public override Type Evaluate(CodeContext c)
        {
            if (base.Evaluate(c) != typeof(bool))
            {
                throw new ApplicationException();
            }
            c.IL.Emit(OpCodes.Ldc_I4_0);
            c.IL.Emit(OpCodes.Ceq);
            return typeof(bool);
        }
    }
}
