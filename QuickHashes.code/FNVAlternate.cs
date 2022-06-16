using System;
using System.Linq;

namespace QuickHashes.code
{
public class FNVAlternate: IFNV
{
    public ulong GetHash(ulong dataToHash) =>
    BitConverter
    .GetBytes(dataToHash)
    .Aggregate(14695981039346656037,
               (accum, current) => (accum ^ current) * 1099511628211);

    public uint GetHash(uint dataToHash) =>
    BitConverter
    .GetBytes(dataToHash)
    .Aggregate(216613626U,
               (accum, current) => (accum ^ current) * 16777619U);

    public long GetHash(long dataToHash) => this.GetHash((uint)dataToHash);
}
}