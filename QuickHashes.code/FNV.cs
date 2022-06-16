using System.Linq;
using System;

namespace QuickHashes.code
{
  public class FNV: IFNV
  {
    public ulong GetHash(ulong dataToHash) =>
      BitConverter
        .GetBytes(dataToHash)
        .Aggregate(14695981039346656037,
        (accum, current) => (accum * 1099511628211) ^ current);

    public uint GetHash(uint dataToHash) =>
      BitConverter
        .GetBytes(dataToHash)
        .Aggregate(216613626U,
        (accum, current) => (accum * 16777619U) ^ current);

    public long GetHash(long dataToHash) => this.GetHash((uint)dataToHash);
  }
}
