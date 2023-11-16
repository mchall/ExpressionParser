using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal class AndNode : BinaryNode
	{
		internal AndNode() : base(11) { }
		internal override Expression BuildExpression(Expression callerExpression = null)
		{
			Expression left, right;
			BuildAndConvert(callerExpression, out left, out right);
			return Expression.And(left, right);
		}
	}
}