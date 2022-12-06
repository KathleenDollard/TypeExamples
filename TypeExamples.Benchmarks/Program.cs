// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using TypeExamples.Benchmarks;

//// Reality check
//var eq = new Equality();
//Console.WriteLine($"Class: {eq.CheckEqualsClass()}");
//Console.WriteLine($"Struct: {eq.CheckEqualsStruct()}");
//Console.WriteLine($"StructExplicit: {eq.CheckEqualsStructExplicit()}");
//Console.WriteLine($"Record: {eq.CheckEqualsRecord()}");
//Console.WriteLine($"RecordStruct: {eq.CheckEqualsRecordStruct()}");
//Console.Read();

 var summary = BenchmarkRunner.Run<Equality>();
