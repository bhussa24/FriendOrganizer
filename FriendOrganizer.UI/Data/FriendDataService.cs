using System.Collections.Generic;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            //TODO: Load data from real database
            yield return new Friend {FirstName = "Bilal", LastName = "Hussain"};
            yield return new Friend {FirstName = "Haleem", LastName = "Sagar"};
            yield return new Friend {FirstName = "Sagar", LastName = "Haleem"};
        }
    }
}
