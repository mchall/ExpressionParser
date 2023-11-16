using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal class LessNode : BinaryNode
	{
		internal LessNode() : base(6) { }

		internal override Expression BuildExpression(Expression callerExpression = null)
		{
			Expression left, right;
			BuildAndConvert(callerExpression, out left, out right);
			return Expression.LessThan(left, right);
		}
	}
}