using System;
using Xunit;
using QuickHashes.code;

namespace QuickHashes.tests {
  public class FNVTest {
    [Fact]
    public void ComputeSameHashSameWords() {
      IHash hashFunction = new FNV();
      hashFunction.GetHash();
    }

    [Fact]
    public void Compute2DifferentHashesDifferentWords() {
      IHash hashFunction = new FNV();
      hashFunction.GetHash();
    }
  }
}
