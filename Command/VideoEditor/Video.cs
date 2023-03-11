using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.VideoEditor
{
    public class Video
    {
        public float Contrast { get; private set; }
        public string Text { get; private set; } = null!;

        public void SetContrast(float contrast)
        {
            Contrast = contrast;
        }
        public void SetText(string text)
        {  
            Text = text;
        }
        public override string ToString()
        {
            return $"Contrast:{Contrast}, Text:{Text}";
        }
    }
}