using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal class GreaterNode : BinaryNode
	{
		internal GreaterNode() : base(6) { }

		internal override Expression BuildExpression(Expression callerExpression = null)
		{
			Expression left, right;
			BuildAndConvert(callerExpression, out left, out right);
			return Expression.GreaterThan(left, right);
		}
	}
}