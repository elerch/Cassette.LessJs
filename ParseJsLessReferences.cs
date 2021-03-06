﻿using System;
using Cassette.BundleProcessing;
using Cassette.Scripts;

namespace Cassette.Stylesheets
{
    public class ParseJsLessReferences : ParseReferences<StylesheetBundle>
    {
        protected override bool ShouldParseAsset(IAsset asset)
        {
            return asset.Path.EndsWith(".less", StringComparison.OrdinalIgnoreCase);
        }

        protected override ICommentParser CreateCommentParser()
        {
            // LESS supports the same comment syntax as JavaScript.
            // So we'll just reuse the JavaScript comment parser!
            return new JavaScriptCommentParser();
        }
    }
}
