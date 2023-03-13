using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Artifact
{
    public class NormalArtifact : IArtifact
    {
        public string Name { get; private set; }
        public NormalArtifact(string name)
        {
            Name = name;
        }
        public void Render()
        {
            System.Console.WriteLine("Render " + Name + " Icon");
        }
    }
}