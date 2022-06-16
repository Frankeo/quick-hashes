using System;

namespace QuickHashes.tests
{
public static class Extensions
{
    public static ulong NextULong(this Random random)
    {
        byte[] buffer = new byte[8];
        random.NextBytes(buffer);
        return BitConverter.ToUInt64(buffer, 0);
    }

    public static long NextLong(this Random random)
    {
        byte[] buffer = new byte[8];
        random.NextBytes(buffer);
        return BitConverter.ToInt64(buffer, 0);
    }

    public static uint NextUInt(this Random random)
    {
        byte[] buffer = new byte[4];
        random.NextBytes(buffer);
        return BitConverter.ToUInt32(buffer, 0);
    }
}
}