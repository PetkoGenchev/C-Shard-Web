namespace CarShop.Models.Issues
{
    using System.Collections.Generic;

    public class CarIssuesViewModel
    {
        public string Id { get; init; }

        public string Model { get; init; }

        public int Year { get; set; }

        public IEnumerable<IssueListingViewModel> Issues { get; init; }
    }
}
