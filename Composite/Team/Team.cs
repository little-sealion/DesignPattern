using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite.Team
{
    public class Team : IResource
    {
        private List<IResource> _resources = new();
        public void Add(IResource resource)
        {
            _resources.Add(resource);
        }
        public void Deploy()
        {
            foreach (var resource in _resources)
            {
                resource.Deploy();
            }
        }
    }
}