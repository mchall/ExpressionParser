using System.Linq.Expressions;

namespace ExpressionParser.Model.Nodes
{
	internal abstract class BinaryNode : OperationNode
	{
		protected BinaryNode(int precedence) : base(precedence) { }

		internal Node Left { get; set; }
		internal Node Right { get; set; }

		internal override bool IsClosed => (Left?.IsClosed ?? false) && Right.IsClosed;

		internal override bool TryAddNode(Node node)
		{
			if (Right != null) return Right.TryAddNode(node);
			Right = node;
			return true;
		}

		protected void BuildAndConvert(Expression callerExpression, out Expression left, out Expression right)
		{
			left = Left.BuildExpression(callerExpression);
			right = Right.BuildExpression(callerExpression);

			if (left.Type != right.Type)
			{
				ConvertTypes(ref left, ref right, typeof(int), typeof(double));
				ConvertTypes(ref left, ref right, typeof(int), typeof(long));
				ConvertTypes(ref left, ref right, typeof(long), typeof(double));
			}
		}
	}
}