using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Tuan_8
{
    public class Post
    {
        private int Post_Id { get; set; }

        private String Title { get; set; }
        private String Content { get; set; }
        private DateTime DataPost { get; set; }
        private DateTime DateEditPost { get; set; }
        private Account account { get; set; }
        private Topic topic { get; set; }
        private bool Status { get; set; }
    }
}
