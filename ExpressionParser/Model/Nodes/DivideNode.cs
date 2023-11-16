using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal class DivideNode : BinaryNode
	{
		internal DivideNode() : base(3) { }

		internal override Expression BuildExpression(Expression callerExpression = null)
		{
			Expression left, right;
			BuildAndConvert(callerExpression, out left, out right);
			return Expression.Divide(left, right);
		}
	}
}