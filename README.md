# InstanciateBenchmarks

``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.379 (1809/October2018Update/Redstone5)
Intel Core i5-6600K CPU 3.50GHz (Skylake), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=2.2.104
  [Host] : .NET Core 2.1.9 (CoreCLR 4.6.27414.06, CoreFX 4.6.27415.01), 64bit RyuJIT
  Clr    : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  Core   : .NET Core 2.1.9 (CoreCLR 4.6.27414.06, CoreFX 4.6.27415.01), 64bit RyuJIT
  CoreRT : .NET CoreRT 1.0.27527.01 @BuiltBy: dlab14-DDVSOWINAGE101 @Branch: master @Commit: bd07c4e0727fa104d50e28ed70ca9bb480dcbc1b, 64bit AOT


```
|      Method |    Job | Runtime |       Mean |     Error |    StdDev |  Ratio | RatioSD | Rank |
|------------ |------- |-------- |-----------:|----------:|----------:|-------:|--------:|-----:|
|         New |    Clr |     Clr |   3.722 ns | 0.0581 ns | 0.0544 ns |   1.00 |    0.00 |    2 |
|   Activator |    Clr |     Clr |  48.439 ns | 0.1852 ns | 0.1733 ns |  13.02 |    0.20 |    9 |
| Constructor |    Clr |     Clr | 137.333 ns | 0.3617 ns | 0.3383 ns |  36.91 |    0.54 |   11 |
|    Delegate |    Clr |     Clr | 727.431 ns | 1.6431 ns | 1.2829 ns | 195.50 |    3.15 |   17 |
|        Func |    Clr |     Clr |  11.439 ns | 0.0742 ns | 0.0658 ns |   3.07 |    0.04 |    7 |
|   TypedFunc |    Clr |     Clr |  10.749 ns | 0.0752 ns | 0.0703 ns |   2.89 |    0.04 |    6 |
|         New |   Core |    Core |   3.973 ns | 0.0417 ns | 0.0370 ns |   1.07 |    0.02 |    3 |
|   Activator |   Core |    Core |  43.673 ns | 0.1425 ns | 0.1333 ns |  11.74 |    0.16 |    8 |
| Constructor |   Core |    Core |  96.602 ns | 0.3215 ns | 0.3007 ns |  25.96 |    0.39 |   10 |
|    Delegate |   Core |    Core | 524.034 ns | 1.1478 ns | 1.0736 ns | 140.84 |    2.10 |   16 |
|        Func |   Core |    Core |   6.282 ns | 0.2092 ns | 0.3195 ns |   1.72 |    0.09 |    5 |
|   TypedFunc |   Core |    Core |   4.538 ns | 0.0891 ns | 0.0833 ns |   1.22 |    0.02 |    4 |
|         New | CoreRT |  CoreRT |   3.187 ns | 0.0759 ns | 0.0710 ns |   0.86 |    0.02 |    1 |
|   Activator | CoreRT |  CoreRT | 328.310 ns | 1.3142 ns | 1.2293 ns |  88.23 |    1.24 |   15 |
| Constructor | CoreRT |  CoreRT | 142.282 ns | 0.7171 ns | 0.6708 ns |  38.24 |    0.55 |   12 |
|    Delegate | CoreRT |  CoreRT | 298.431 ns | 2.0301 ns | 1.8990 ns |  80.21 |    1.36 |   14 |
|        Func | CoreRT |  CoreRT | 220.747 ns | 0.5149 ns | 0.4816 ns |  59.33 |    0.84 |   13 |
|   TypedFunc | CoreRT |  CoreRT | 219.806 ns | 1.5278 ns | 1.4291 ns |  59.08 |    1.02 |   13 |
