﻿// <copyright file="MoveInFileSystemTests.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using FubarDev.WebDavServer.Props.Dead;

namespace FubarDev.WebDavServer.Tests.Handlers
{
    public class MoveInFileSystemTests : MoveTestsBase
    {
        public MoveInFileSystemTests()
            : base(RecursiveProcessingMode.PreferFastest)
        {
        }
    }
}
