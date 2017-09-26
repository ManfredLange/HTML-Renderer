#region Copyright Notice
// Copyright(c) 2017, Manfred Lange
// All rights reserved.
//   
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//   
//   Redistributions of source code must retain the above copyright notice, this
//   list of conditions and the following disclaimer.
//   
//   Redistributions in binary form must reproduce the above copyright notice, this
//   list of conditions and the following disclaimer in the documentation and/or
//   other materials provided with the distribution.
//   
//   Neither the name Manfred Lange nor the names of its contributors may be used 
//   to endorse or promote products derived from this software without specific 
//   prior written permission.
//   
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED.IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
// ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion Copyright

// The font used in this demo is called "Indie Flower" and is designed by Kimberly Geswein.
// It is also available at:
//    https://fonts.google.com/specimen/Indie+Flower
// It is used under the terms and conditions of the Open Font License available at:
//    http://scripts.sil.org/cms/scripts/page.php?site_id=nrsi&id=OFL_web

using PdfSharp.Fonts;
using System;
using System.IO;
using System.Reflection;

namespace HtmlRenderer.Demo.PdfSharp {
   public class FontResolver : IFontResolver {
      public byte[] GetFont(string faceName) {
         switch (faceName) {
            case "IndieFlower":
               return FontHelper.IndieFlower;
         }

         return null;
      }

      public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic) {
         // Ignore case of font names.
         var name = familyName.ToLower();

         switch (name) {
            case "indie flower":
               return new FontResolverInfo("IndieFlower");
         }

         // We pass all other font requests to the default handler.
         // When running on a web server without sufficient permission, you can return a default font at this stage.
         return PlatformFontResolver.ResolveTypeface(familyName, isBold, isItalic);
      }
   }

   /// <summary>
   /// Helper class that reads font data from embedded resources.
   /// </summary>
   public static class FontHelper {
      public static byte[] IndieFlower {
         get { return LoadFontData("HtmlRenderer.Demo.PdfSharp.fonts.IndieFlower.ttf"); }
      }

      // Tip: I used JetBrains dotPeek to find the names of the resources (just look how dots in folder names are encoded).
      // Make sure the fonts have compile type "Embedded Resource". Names are case-sensitive.

      /// <summary>
      /// Returns the specified font from an embedded resource. Alternatively, you can 
      /// change the code to read from a file.
      /// </summary>
      static byte[] LoadFontData(string name) {
         var assembly = Assembly.GetExecutingAssembly();

         using (Stream stream = assembly.GetManifestResourceStream(name)) {
            if (stream == null)
               throw new ArgumentException("No resource with name " + name);

            int count = (int)stream.Length;
            byte[] data = new byte[count];
            stream.Read(data, 0, count);
            return data;
         }
      }
   }
}
