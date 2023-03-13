using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Artifact
{
    public class MainArtifact : IArtifact
    {
        private IArtifact _artifact;

        public MainArtifact(IArtifact artifact)
        {
            _artifact = artifact;
        }

        public void Render()
        {
            setMain();
            _artifact.Render();
        }
        private void setMain()
        {
            System.Console.WriteLine("add triangle playing sign");
        }
    }
}