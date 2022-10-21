using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JurisUtilityBase
{
    public class ExpAttachment
    {
        public string fileName { get; set; }

        public byte[] fileData { get; set; }

        public int billNo { get; set; }

        public string clicode { get; set; }

        public string matcode { get; set; }
    }
}
