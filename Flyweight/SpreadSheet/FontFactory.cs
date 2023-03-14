using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight.SpreadSheet
{
    public class FontFactory
    {
        private Dictionary<FontType, Font> _fonts = new();

        public Font GetFont(FontType type)
        {
            if (!_fonts.ContainsKey(type))
            {
                var font = type switch
                {
                    FontType.TITLE => new Font { FontFamily = "cabri", FontSize = 16, IsBold = true },
                    FontType.SUBTITLE => new Font { FontFamily = "cabri", FontSize = 14, IsBold = true },
                    FontType.BODY => new Font { FontFamily = "monoli", FontSize = 12, IsBold = false },
                    _ => new Font { FontFamily = "monoli", FontSize = 12, IsBold = false }
                };
                _fonts.Add(type, font);
            }
            return _fonts[type];
        }
    }
}