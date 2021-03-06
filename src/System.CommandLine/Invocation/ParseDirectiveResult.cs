﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;

namespace System.CommandLine.Invocation
{
    public class ParseDirectiveResult : IInvocationResult
    {
        public void Apply(InvocationContext context)
        {
            var parseResult = context.ParseResult;
            context.Console.Out.WriteLine(parseResult.Diagram());
            context.ResultCode = parseResult.Errors.Count == 0
                                     ? 0
                                     : 1;
        }
    }
}
