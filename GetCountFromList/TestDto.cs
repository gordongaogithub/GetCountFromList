using System;
using System.Collections.Generic;
using System.Text;

namespace GetCountFromList
{
    public class TestDto
    {
        public TestDto()
        {
        }
        //
        public TestDto(int type)
        {
            this.Type = type;
        }

        public int Type { get; set; }

        public int Qty { get; set; }

        
    }
}
