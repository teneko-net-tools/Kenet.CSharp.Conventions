﻿namespace Kenet.CSharp.Conventions.Base
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="TSomething"></typeparam>
    public class PublicClassConventions<TSomething>
    {
        public PublicClassConventions(TSomething _)
        {
        }

        public string Test { get; } = null!;
    }
}
