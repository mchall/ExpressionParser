﻿using System;
using System.Collections.Generic;

namespace ExpressionParser
{
	public interface IExpressionParser
	{
		Delegate Parse(string input);

		Func<TOutput> Parse<TOutput>(string input);

		Delegate ParseFor<TInput>(string input);
		Delegate ParseFor<TInput>(string input, string parameterName);

		Func<TInput, TOutput> ParseFor<TInput, TOutput>(string input);
		Func<TInput, TOutput> ParseFor<TInput, TOutput>(string input, string parameterName);

		IExpressionParser Using(Type type, string alias = null);
		IExpressionParser Using(IEnumerable<Type> types);
		IExpressionParser Using(IDictionary<Type, string> typeMaps);
	}
}