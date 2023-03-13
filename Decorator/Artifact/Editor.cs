using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Artifact
{
    public static class Editor
    {
        public static void OpenProject()
        {
            var artifacts = new IArtifact[]{
                new MainArtifact(new NormalArtifact("Main")),
                new NormalArtifact("Demo"),
                new ErrorArtifact(new NormalArtifact("EmailClient")),
                new NormalArtifact("EmailProvider")
            };
            foreach (var artifact in artifacts)
            {
                artifact.Render();
            }
        }
    }
}