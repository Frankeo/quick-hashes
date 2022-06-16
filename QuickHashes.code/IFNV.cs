namespace QuickHashes.code {
  public interface IFNV {
    ulong GetHash(ulong dataToHash);

    uint GetHash(uint dataToHash);

    long GetHash(long dataToHash);
  }
}
