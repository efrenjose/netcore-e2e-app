using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace netcore_e2e_app.Models.Resources
{
    public class MakeResource : KeyValuePairResource
    {
        public ICollection<KeyValuePairResource> Models { get; set; }
        public MakeResource()
        {
            Models = new Collection<KeyValuePairResource>();
        }
    }
}