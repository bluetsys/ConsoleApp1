``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.1 (21C52) [Darwin 21.2.0]
Apple M1 Pro, 1 CPU, 8 logical and 8 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT


```
| Method |          Mean |     Error |    StdDev |        Median |
|------- |--------------:|----------:|----------:|--------------:|
| Sha256 |   525.8242 ns | 2.4100 ns | 2.2543 ns |   524.4131 ns |
|    Md5 | 2,027.2733 ns | 0.9704 ns | 0.8103 ns | 2,027.2045 ns |
|  Bytes |     0.0004 ns | 0.0008 ns | 0.0007 ns |     0.0000 ns |



``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.928 (21H1/May2021Update)
12th Gen Intel Core i9-12900K, 1 CPU, 24 logical and 16 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
| Method |          Mean |     Error |    StdDev |
|------- |--------------:|----------:|----------:|
| Sha256 |   482.1391 ns | 3.9579 ns | 3.7023 ns |
|    Md5 | 1,412.0901 ns | 8.0887 ns | 7.5662 ns |
|  Bytes |     0.0000 ns | 0.0000 ns | 0.0000 ns |


``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
12th Gen Intel Core i9-12900K, 1 CPU, 24 logical and 16 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
| Method |          Mean |     Error |    StdDev |        Median |
|------- |--------------:|----------:|----------:|--------------:|
| Sha256 |   484.6380 ns | 1.4059 ns | 1.3151 ns |   485.2187 ns |
|    Md5 | 1,398.0980 ns | 8.4759 ns | 7.9284 ns | 1,399.1964 ns |
|  Bytes |     0.0369 ns | 0.0297 ns | 0.0278 ns |     0.0535 ns |

``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.1 (21C52) [Darwin 21.2.0]
Intel Core i5-8279U CPU 2.40GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
| Method |          Mean |      Error |      StdDev |
|------- |--------------:|-----------:|------------:|
| Sha256 | 2,757.0725 ns | 65.4903 ns | 186.8476 ns |
|    Md5 | 1,936.4278 ns | 28.8352 ns |  25.5616 ns |
|  Bytes |     0.2307 ns |  0.0159 ns |   0.0141 ns |

