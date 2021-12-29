``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.1 (21C52) [Darwin 21.2.0]
Apple M1 Pro, 1 CPU, 8 logical and 8 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT


```
| Method |               Mean |          Error |         StdDev |             Median |
|------- |-------------------:|---------------:|---------------:|-------------------:|
| Sha256 |      4,184.1249 ns |     11.7079 ns |     10.3788 ns |      4,178.2851 ns |
|    Md5 |     18,579.3798 ns |      9.4405 ns |      7.8832 ns |     18,577.4511 ns |
|  Bytes |          0.0009 ns |      0.0016 ns |      0.0014 ns |          0.0001 ns |
|   Gauß | 31,048,199.6004 ns | 14,591.7855 ns | 12,935.2378 ns | 31,046,257.8281 ns |
