public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        var buffer = new byte[9];
        byte prefix;
        byte[] bytes;

        if (reading >= 0 && reading <= ushort.MaxValue)
        {
            // ushort 0~65535
            prefix = 2;
            bytes = BitConverter.GetBytes((ushort)reading);
        }
        else if (reading >= short.MinValue && reading <= -1)
        {
            // short -32768 ~ -1
            prefix = 254;
            bytes = BitConverter.GetBytes((short)reading);
        }
        else if (reading >= int.MinValue && reading <= int.MaxValue)
        {
            // int 整个int范围：-2147483648 ~ 2147483647
            prefix = 252;
            bytes = BitConverter.GetBytes((int)reading);
        }
        else if (reading > int.MaxValue && reading <= uint.MaxValue)
        {
            // uint 2147483648 ~ 4294967295
            prefix = 4;
            bytes = BitConverter.GetBytes((uint)reading);
        }
        else
        {
            // 剩下的全部long
            prefix = 248;
            bytes = BitConverter.GetBytes(reading);
        }

        buffer[0] = prefix;
        Array.Copy(bytes, 0, buffer, 1, bytes.Length);
        return buffer;
    }
    

    public static long FromBuffer(byte[] buffer)
    {
        byte prefix = buffer[0];
        // 截取数据部分（从索引1开始）
        byte[] data = buffer.Skip(1).ToArray();

        return prefix switch
        {
            2 => BitConverter.ToUInt16(data, 0),
            254 => BitConverter.ToInt16(data, 0),
            4 => BitConverter.ToUInt32(data, 0),
            252 => BitConverter.ToInt32(data, 0),
            248 => BitConverter.ToInt64(data, 0),
            _ => 0 // 非法前缀返回0
        };
    }
}
