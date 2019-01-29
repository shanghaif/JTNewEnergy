﻿using JTNE.Protocol.Extensions;
using JTNE.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace JTNE.Protocol.Formatters.MessageBodyFormatters
{
    public class JTNE_0x81_0x05Formatter : IJTNEFormatter<JTNE_0x81_0x05>
    {
        public JTNE_0x81_0x05 Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JTNE_0x81_0x05 jTNE_0x81_0x05 = new JTNE_0x81_0x05();
            jTNE_0x81_0x05.ParamValue = JTNEBinaryExtensions.ReadBytesLittle(bytes, ref offset);
            jTNE_0x81_0x05.ParamLength = (byte)bytes.Length;
            readSize = offset;
            return jTNE_0x81_0x05;
        }

        public int Serialize(ref byte[] bytes, int offset, JTNE_0x81_0x05 value)
        {
            offset += JTNEBinaryExtensions.WriteBytesLittle(bytes, offset, value.ParamValue);
            return offset;
        }
    }
}
