using System.Collections.Generic;

namespace RegionPrismSample.ViewModels.Regions
{
    public class ContactsViewModel
    {
        public List<string> Contacts { get; private set; }
        public ContactsViewModel()
        {
            Contacts = new List<string> { "Monkey 1", "Monkey 2", "Monkey 3", "Monkey 4" };
        }
    }
}
