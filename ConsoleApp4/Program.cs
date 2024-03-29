﻿using System.Security.Cryptography;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
Console.WriteLine("Hello, World!");

[RPlotExporter]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net70)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
 public class Md5VsSha256
    {
        private const int N = 1000;
        private readonly byte[] data;

        private readonly SHA256 sha256 = SHA256.Create();
        private readonly MD5 md5 = MD5.Create();

        public Md5VsSha256()
        {
            data = new byte[N];
            new Random(42).NextBytes(data);
        }

        [Benchmark]
        public byte[] Sha256() => sha256.ComputeHash(data);

        [Benchmark]
        public byte[] Md5() => md5.ComputeHash(data);

        [Benchmark]
        public byte[] Bytes() => data;

 /*        [Benchmark]
        public int Gauß()
        {
            var add = 0;
            for (var index = 0; index <= 100_000_000; index++)

            {
                add = add + index;
            }

            return add;
        } */
    }
