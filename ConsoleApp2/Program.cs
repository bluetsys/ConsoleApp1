﻿long add = 0;
var st = System.DateTime.Now;

/*
for (int index = 0; index <= 100000000; index++)
{
    add = add + index;
}
*/
var ee = System.Text.Encoding.ASCII.GetBytes("111" + System.DateTime.UtcNow.ToString());
for( int i = 0; i < 1_000_000; i++ )
{
    MD5HashFunc(ee);
}

Console.WriteLine(System.Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));

var ed = System.DateTime.Now - st;

Console.WriteLine($"MachineName - {System.Environment.MachineName}");
Console.WriteLine($"OSVersion - {System.Environment.OSVersion}");
Console.WriteLine($"UtcNow - {System.DateTime.UtcNow}");
Console.WriteLine(System.DateTime.UtcNow);
Console.WriteLine("==========================");
Console.WriteLine("C# 테스트");
Console.WriteLine(add);
Console.WriteLine(ed);
Console.WriteLine("==========================");

/*
byte[] MD5HashFunc(string str)
{
    byte[] byteArr = System.Text.Encoding.ASCII.GetBytes(str);
    return System.Security.Cryptography.MD5.Create().ComputeHash(byteArr);
}
*/

byte[] MD5HashFunc(byte[] byteArr)
{
    return System.Security.Cryptography.MD5.Create().ComputeHash(byteArr);
}