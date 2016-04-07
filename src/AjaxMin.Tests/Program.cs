﻿// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.

using System;

namespace AjaxMin.Tests
{
    public class Program
    {
        public static void Main()
        {
            var minifier = new Microsoft.Ajax.Utilities.Minifier();
            var result = minifier.MinifyStyleSheet("div { color: #FFF; }");
        }
    }
}