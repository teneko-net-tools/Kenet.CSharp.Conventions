﻿namespace Teronis.DotNet.EditorConfig.Base
{
    // The disabling of such warnings is the assertion
#pragma warning disable RCS1138 // Add summary to documentation comment.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="TSomething"></typeparam>
    public class PublicClass<TSomething>
    {
        public static readonly PublicClass<TSomething> Default = new(default!);

        public PublicClass(TSomething _)
        {
        }

        public string Test { get; }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore RCS1138 // Add summary to documentation comment.
}
