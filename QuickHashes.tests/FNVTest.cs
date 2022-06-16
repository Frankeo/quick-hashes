using System;
using Xunit;
using QuickHashes.code;
using System.Collections.Generic;

namespace QuickHashes.tests {
  public class FNVTest {

    private readonly Random Random;

    public FNVTest() { this.Random = new Random(); }

    public static IEnumerable<object[]> HashClasses =>
        new List<object[]> { new object[] { new FNVAlternate() },
                             new object[] { new FNV() } };

    [Theory]
    [MemberData(nameof(HashClasses))]
    public void Compute_Same_Hash_Same_UInt(IFNV HashFunction) {
      var randomUInt = this.Random.NextUInt();
      var hash1 = HashFunction.GetHash(randomUInt);
      var hash2 = HashFunction.GetHash(randomUInt);

      Assert.Equal((uint)hash1, (uint)hash2);
    }

    [Theory]
    [MemberData(nameof(HashClasses))]
    public void Compute_2_Different_Hashes_Different_UInt(IFNV HashFunction) {
      var hash1 = HashFunction.GetHash(this.Random.NextUInt());
      var hash2 = HashFunction.GetHash(this.Random.NextUInt());

      Assert.NotEqual((uint)hash1, (uint)hash2);
    }

    [Theory]
    [MemberData(nameof(HashClasses))]
    public void Compute_Same_Hash_Same_ULong(IFNV HashFunction) {
      var randomULong = this.Random.NextULong();
      var hash1 = HashFunction.GetHash(randomULong);
      var hash2 = HashFunction.GetHash(randomULong);

      Assert.Equal((ulong)hash1, (ulong)hash2);
    }

    [Theory]
    [MemberData(nameof(HashClasses))]
    public void Compute_2_Different_Hashes_Different_ULong(IFNV HashFunction) {
      var hash1 = HashFunction.GetHash(this.Random.NextULong());
      var hash2 = HashFunction.GetHash(this.Random.NextULong());

      Assert.NotEqual((ulong)hash1, (ulong)hash2);
    }

    [Theory]
    [MemberData(nameof(HashClasses))]
    public void Compute_Same_Hash_Same_Long(IFNV HashFunction) {
      var randomLong = this.Random.NextLong();
      var hash1 = HashFunction.GetHash(randomLong);
      var hash2 = HashFunction.GetHash(randomLong);

      Assert.Equal((uint)hash1, (uint)hash2);
    }

    [Theory]
    [MemberData(nameof(HashClasses))]
    public void Compute_2_Different_Hashes_Different_Long(IFNV HashFunction) {
      var hash1 = HashFunction.GetHash(this.Random.NextULong());
      var hash2 = HashFunction.GetHash(this.Random.NextULong());

      Assert.NotEqual((uint)hash1, (uint)hash2);
    }
  }
}
