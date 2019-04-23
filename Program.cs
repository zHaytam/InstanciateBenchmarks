using BenchmarkDotNet.Running;
using System;
using System.Linq.Expressions;

namespace InstanciateBenchmarks
{
    class Program
    {

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Benchmarks>();

            //var _type = typeof(TestClass);
            //var _delegate = Expression.Lambda(Expression.New(_type)).Compile();
            //var _func = Expression.Lambda<Func<object>>(Expression.New(_type)).Compile();

            //var obj1 = _delegate.DynamicInvoke();
            //var obj2 = _func();
        }

    }
}
