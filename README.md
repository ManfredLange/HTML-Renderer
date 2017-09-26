Welcome!
=============

This fork adds the following changes:
* All projects moved to .NET Framework 4.6.1
* Projects now use nuget package PDFsharp version 1.50.4619-beta4c where needed
* custom font handling for HtmlRenderer.PdfSharp
* new demo for converting HTML to PDF including custom font handling

Notes:
* Solution was successfully build using Visual Studio 2017 version 15.3.5
* This fork has not been tested on Mono
* If your application targets a .NET Framework older than version 4.6.1 you may not be able to use binaries from this fork
* You can either use custom fonts that are an embedded resource, or you can load the font from a file.
* Use TrueType fonts on Windows platforms (may also work on non-Windows platforms)
* Looking for fonts? [Google Fonts](https://fonts.google.com) may be worth a look. As of writing 847 fonts are listed there.

I do not have time to provide support for this library. However, if you have a fix, improvement, addition, etc. please fork from here and send a pull request (PR). The simpler and more self-explanatory the PR the more likely it is that it will be merged.

This repository is a fork of [Arthur Hub's HtmlRenderer](https://github.com/ArthurHub/HTML-Renderer). More details available there.


### Features and Benefits
* Extensive HTML 4.01 and CSS level 2 specifications support.
* Support separating CSS from HTML by loading stylesheet code separately.
* Convert HTML to PDF
* Support text selection, copy-paste and context menu.
* WinForms controls: HtmlPanel, HtmlLabel and HtmlToolTip.
* WPF controls: HtmlPanel and HtmlLabel.
* Create images from HTML snippets.
* Handles "real world" malformed HTML, it doesn't have to be XHTML.
* 100% managed code and no external dependencies.
* Supports .NET 2.0 or higher including Client Profile.
* Lightweight, just two DLLs (~300K).
* High performance and low memory footprint.
* Extendable and configurable.
* Includes sample applications to explore and learn the library.
* Sample for a console application, a WinForms application and a WPF application 
