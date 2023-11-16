using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal class OrNode : BinaryNode
	{
		internal OrNode() : base(12) { }

		internal override Expression BuildExpression(Expression callerExpression = null)
		{
			Expression left, right;
			BuildAndConvert(callerExpression, out left, out right);
			return Expression.Or(left, right);
		}
	}
}