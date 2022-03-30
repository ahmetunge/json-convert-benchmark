using BenchmarkDotNet.Running;
using JsonConvertBenchmark.Deserialize.OneThousandItem;

//BenchmarkRunner.Run<JsonSerializerOneHundredPersonBenchmark>();
//BenchmarkRunner.Run<JsonSerializerOneHundredEmployeeBenchmark>();

//BenchmarkRunner.Run<JsonSerializerOneThousandPersonBenchmark>();
//BenchmarkRunner.Run<JsonSerializerOneThousandEmployeeBenchmark>();

//BenchmarkRunner.Run<JsonDeserializerOneHundredPersonBenchmark>();
//BenchmarkRunner.Run<JsonDeserializerOneHundredEmployeeBenchmark>();

//BenchmarkRunner.Run<JsonDeserializerOneThousandPersonBenchmark>();
BenchmarkRunner.Run<JsonDeserializerOneThousandEmployeeBenchmark>();

