using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Artifact
{
    public class ErrorArtifact : IArtifact
    {
        private IArtifact _artifact;

        public ErrorArtifact(IArtifact artifact)
        {
            _artifact = artifact;
        }

        public void Render()
        {
            setError();
            _artifact.Render();
        }
        private void setError()
        {
            System.Console.WriteLine("add red squiggly line");
        }
    }
}