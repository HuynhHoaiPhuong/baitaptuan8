using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Tuan_8
{
    public class Comment
    {
        private int Comment_Id { get; set; }
        private String Description { get; set; }
        private DateTime DateComment { get; set; }
        private Account account { get; set; }
        private Post post { get; set; }
        private bool Status { get; set; }
    }
}
