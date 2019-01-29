﻿using JTNE.Protocol.Attributes;
using JTNE.Protocol.Formatters.MessageBodyFormatters;
using JTNE.Protocol.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace JTNE.Protocol.MessageBody
{
    /// <summary>
    ///  车载终端报警
    /// </summary>
    [JTNEFormatter(typeof(JTNE_0x82_0x06Formatter))]
   public  class JTNE_0x82_0x06 : JTNE_0x82_Body
    {
        public override byte ParamId { get; set; } = 0x06;
        public override byte ParamLength { get; set; }
        public AlarmCommand AlarmCommand { get; set; }
    }
}

