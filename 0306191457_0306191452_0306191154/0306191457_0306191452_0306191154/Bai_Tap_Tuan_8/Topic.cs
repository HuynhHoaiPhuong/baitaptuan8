using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Tuan_8
{
    public class Topic
    {
        private int Topic_Id { get; set; }
        private String Title { get; set; }
        private String Description { get; set; }
        private String ImagePath { get; set; }
        private DateTime DataUpload { get; set; }
        private bool Status { get; set; }
    }
}
