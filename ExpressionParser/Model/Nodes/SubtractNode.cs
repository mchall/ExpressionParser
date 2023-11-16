using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal class SubtractNode : BinaryNode
	{
		internal SubtractNode() : base(4) { }

		internal override Expression BuildExpression(Expression callerExpression = null)
		{
			Expression left, right;
			BuildAndConvert(callerExpression, out left, out right);
			return Expression.Subtract(left, right);
		}
	}
}