using PdfSharp.Fonts;
using TheArtOfDev.HtmlRenderer.Demo.Common;

namespace TheArtOfDev.HtmlRenderer.Demo.WinForms {
   public class FontResolver : IFontResolver {
      const string OneSmoothyDna = "1 Smoothy DNA";

      public byte[] GetFont(string faceName) {
         switch (faceName) {
            //case "1 Smoothy DNA":
            case OneSmoothyDna:
               return Resources.CustomFont;
         }
         return null;
      }

      public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic) {
         // Ignore case of font names.
         var name = familyName.ToLower();

         switch (name) {
            case "1 smoothy dna":
               return new FontResolverInfo(OneSmoothyDna);
         }

         // We pass all other font requests to the default handler.
         // When running on a web server without sufficient permission, you can return a default font at this stage.
         return PlatformFontResolver.ResolveTypeface(familyName, isBold, isItalic);
      }
   }
}
