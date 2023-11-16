using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
    internal class TernaryNode : OperationNode
    {
        internal TernaryNode() : base(7) { }

        internal Node Test { get; set; }
        internal Node True { get; set; }
        internal Node False { get; set; }

        internal override bool IsClosed => (Test?.IsClosed ?? false) && True.IsClosed && False.IsClosed;

        internal override bool TryAddNode(Node node)
        {
            if (True != null)
                False = node;
            else
                True = node;
            return true;
        }

        internal override Expression BuildExpression(Expression callerExpression = null)
        {
            var test = Test.BuildExpression(callerExpression);
            var t = True.BuildExpression(callerExpression);
            var f = False.BuildExpression(callerExpression);

            ConvertTypes(ref t, ref f, typeof(int), typeof(double));
            ConvertTypes(ref t, ref f, typeof(int), typeof(long));
            ConvertTypes(ref t, ref f, typeof(long), typeof(double));

            return Expression.Condition(test, t, f);
        }
    }
}