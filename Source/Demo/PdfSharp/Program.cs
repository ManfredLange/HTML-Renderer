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

using PdfSharp;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.IO;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace HtmlRenderer.Demo.PdfSharp {

   // This demo shows how to use custom fonts with PdfSharp and HtmlRenderer. Based on some HTML
   // and styles in a CSS, this demo writes both a PDF using a custom font as well as an HTML
   // file using the exact same content. It then also launches the application that is associated
   // with the extensions "PDF" and "HTML" respectively. This is typically Adobe Acrobat Reader
   // and a web browser.
   //
   // The code in this example is not production ready. You will need to embed it in your
   // code base in an appropriate way.
   //
   // The example is provided "as-is" with no warranty, implied or explicit, as to suitability 
   // for a given scenario. If you choose to use this code or parts thereof you do so at your 
   // own risk.

   class Program {
      static void Main(string[] args) {
         // PdfSharp does not allow setting the font resolver more than once.
         GlobalFontSettings.FontResolver = new FontResolver();

         // Load stylesheet from file, e.g. using File.ReadAllText() or assign it a value here:
         var styleSheet = "h1 { font-family: 'Indie Flower'; font-size: 36px; }" +
            "body { font-family: 'Indie Flower'; font-size: 14px; }"
            ;

         // Surround the stylesheet with a <style> tag:
         var inlineCss = "<style type=\"text/css\">" +
            styleSheet +
         "</style>";

         // Next we need some HTML code:
         var html = "<!DOCTYPE html>" +
            "<html>" +
               "<head>" +
                  "<meta name=\"viewport\" content=\"width=device-width\" />" +
                  // The link will be ignored by HtmlRenderer.PdfSharp but is required for the HTML file:
                  "<link href=\"https://fonts.googleapis.com/css?family=Indie+Flower\" rel=\"stylesheet\">" +
                  "<title>Hello, world!</title>" +
                  inlineCss +
               "</head>" +
               "<body>" +
                  "<h1>Welcome!</h1>" +
                  "<p>Hello, world!</p>" +
               "</body>" +
            "</html>";
         
         // Create PDF document from HTML:
         PdfDocument pdf = new PdfDocument();
         pdf.Info.Title = "Created by Urnextgig";
         PdfGenerator.AddPdfPages(pdf, html, PageSize.A4);
         const string filename = "HelloWorld.pdf";
         pdf.Save(filename);
         Process.Start(filename);

         // Also write HTML to a file for display in a browser:
         const string htmlFileName = "HelloWorld.html";
         File.WriteAllText(htmlFileName, html);
         Process.Start(htmlFileName);
      }
   }
}
