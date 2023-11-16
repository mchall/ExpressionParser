using System;
using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal abstract class OperationNode : Node
	{
		protected OperationNode(int precedence) : base(precedence) { }

		protected static void ConvertTypes(ref Expression left, ref Expression right, Type t1, Type t2)
		{
			if (left.Type == t1 && right.Type == t2)
				left = Expression.Convert(left, t2);
			if (left.Type == t2 && right.Type == t1)
				right = Expression.Convert(right, t2);
		}
	}
}