using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeForums.Models.ForumModels
{
    public class ForumIndexModel
    {
        //model passes down to view
        public IEnumerable<ForumListModel> ForumList { get; set; }
    }
}
