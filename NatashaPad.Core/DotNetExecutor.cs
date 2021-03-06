﻿using System;
using WeihanLi.Common.Helpers;

namespace NatashaPad
{
    public class DotNetExecutor : ProcessExecutor
    {
        public DotNetExecutor(string dllPath, Action<string> outputHandler) : base("dotnet", dllPath)
        {
            if (outputHandler != null)
            {
                OnOutputDataReceived += (sender, args) =>
                {
                    outputHandler(args);
                };
            }
        }
    }
}