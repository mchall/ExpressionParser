using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal class ModuloNode : BinaryNode
	{
		internal ModuloNode() : base(3) { }

		internal override Expression BuildExpression(Expression callerExpression = null)
		{
			Expression left, right;
			BuildAndConvert(callerExpression, out left, out right);
			return Expression.Modulo(left, right);
		}
	}
}