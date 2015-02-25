// Guids.cs
// MUST match guids.h
using System;

namespace Company.AddButtonToFrame
{
    static class GuidList
    {
        public const string guidAddButtonToFramePkgString = "b1b3c420-e0e5-4c41-9210-1b9a1530e1a6";
        public const string guidAddButtonToFrameCmdSetString = "ead14691-fb02-40f2-bee3-9f9c40c992fe";
        public const string guidUIFactoryString = "A4D21FA7-B7C2-47CF-9B68-E6662F3C700D";
        public const string guidBadgeString = "26B3579D-884F-4939-89E7-3E2169CC3976";
        
        
        public static readonly Guid guidAddButtonToFrameCmdSet = new Guid(guidAddButtonToFrameCmdSetString);
        public static readonly Guid guidUIFactory = new Guid(guidUIFactoryString);
    };
}