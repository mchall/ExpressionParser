using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal class MultiplyNode : BinaryNode
	{
		internal MultiplyNode() : base(3) { }

		internal override Expression BuildExpression(Expression callerExpression = null)
		{
			Expression left, right;
			BuildAndConvert(callerExpression, out left, out right);
			return Expression.Multiply(left, right);
		}
	}
}