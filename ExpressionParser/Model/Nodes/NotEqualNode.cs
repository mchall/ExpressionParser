using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal class NotEqualNode : BinaryNode
	{
		internal NotEqualNode() : base(7) { }

		internal override Expression BuildExpression(Expression callerExpression = null)
		{
			Expression left, right;
			BuildAndConvert(callerExpression, out left, out right);
			return Expression.NotEqual(left, right);
		}
	}
}