using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal class LessOrEqualNode : BinaryNode
	{
		internal LessOrEqualNode() : base(6) { }

		internal override Expression BuildExpression(Expression callerExpression = null)
		{
			Expression left, right;
			BuildAndConvert(callerExpression, out left, out right);
			return Expression.LessThanOrEqual(left, right);
		}
	}
}