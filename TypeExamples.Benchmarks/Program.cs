// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using TypeExamples.Benchmarks;



 var summary = BenchmarkRunner.Run<EqualityBenchmarks>();
