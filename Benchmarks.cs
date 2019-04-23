using BenchmarkDotNet.Attributes;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace InstanciateBenchmarks
{
    [ClrJob(baseline: true), CoreJob, CoreRtJob]
    [RPlotExporter, RankColumn]
    public class Benchmarks
    {

        private Type _type;
        private ConstructorInfo _constructor;
        private Delegate _delegate;
        private Func<object> _func;
        private Func<TestClass> _typedFunc;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _type = typeof(TestClass);
            _constructor = _type.GetConstructor(Type.EmptyTypes);
            _delegate = Expression.Lambda(Expression.New(_type)).Compile();
            _func = Expression.Lambda<Func<object>>(Expression.New(_type)).Compile();
            _typedFunc = Expression.Lambda<Func<TestClass>>(Expression.New(_type)).Compile();
        }

        [Benchmark(Baseline = true)]
        public TestClass New()
        {
            return new TestClass();
        }

        [Benchmark]
        public TestClass Activator()
        {
            return (TestClass)System.Activator.CreateInstance(_type);
        }

        [Benchmark]
        public TestClass Constructor()
        {
            return (TestClass)_constructor.Invoke(null);
        }

        [Benchmark]
        public TestClass Delegate()
        {
            return (TestClass)_delegate.DynamicInvoke();
        }

        [Benchmark]
        public TestClass Func()
        {
            return (TestClass)_func();
        }

        [Benchmark]
        public TestClass TypedFunc()
        {
            return _typedFunc();
        }

    }
}
