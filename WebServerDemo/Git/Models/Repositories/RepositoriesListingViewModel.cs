using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Models.Repositories
{
    public class RepositoriesListingViewModel
    {
        public string Name { get; init; }
        public string Owner { get; init; }
        public string Id { get; init; }
        public DateTime CreatedOn { get; init; }
        public int Commits { get; init; }


    }
}
