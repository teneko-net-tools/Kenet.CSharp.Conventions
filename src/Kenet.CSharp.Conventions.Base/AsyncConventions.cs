﻿using System.Threading.Tasks;

namespace Kenet.CSharp.Conventions.Base
{
    internal class AsyncConventions
    {
#pragma warning disable CA1822 // Mark members as static
        public async Task DoSomething()
#pragma warning restore CA1822 // Mark members as static
        {
            await Task.Yield();
        }
    }
}
