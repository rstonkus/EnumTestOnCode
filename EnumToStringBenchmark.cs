using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace EnumBenchmarkApplication
{
public class EnumToStringBenchmark
    {
        private Random _rnd;
        private SomeEnum[] _possibleValues;
        private static int _count;

        [Setup]
        public void SetupData()
        {
            _possibleValues = Enum.GetValues(typeof(SomeEnum))
                .Cast<SomeEnum>()
                .ToArray();
            _count = _possibleValues.Length;
            _rnd = new Random();
        }

        [Benchmark]
        public string EnumToString()
        {
            return _possibleValues[_rnd.Next(_count)].ToString();
        }
        [Benchmark]
        public string EnumToStringCustom()
        {
            return _possibleValues[_rnd.Next(_count)].ToStringFromDictionary();
        }
    }
}