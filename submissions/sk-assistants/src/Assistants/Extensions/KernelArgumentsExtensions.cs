﻿// Copyright (c) Kevin BEAUGRAND. All rights reserved.

using Microsoft.SemanticKernel;
using System.Collections.Generic;

namespace SemanticKernel.Assistants.Extensions;

/// <summary>
/// Extensions for <see cref="KernelArguments"/>.
/// </summary>
internal static class KernelArgumentsExtensions
{
    /// <summary>
    /// Converts the <see cref="KernelArguments"/> to a dictionary.
    /// </summary>
    /// <param name="args">The Kernel arguments to convert.</param>
    /// <returns></returns>
    internal static Dictionary<string, object?> ToDictionary(this KernelArguments args)
    {
        var dictionary = new Dictionary<string, object?>();
        foreach (var arg in args)
        {
            dictionary.Add(arg.Key, arg.Value);
        }

        return dictionary;
    }
}
