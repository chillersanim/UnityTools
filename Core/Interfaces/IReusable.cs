﻿// Solution:         Unity Tools
// Project:          UnityTools
// Filename:         IReusable.cs
// 
// Created:          29.01.2020  19:27
// Last modified:    05.02.2020  19:39
// 
// --------------------------------------------------------------------------------------
// 
// MIT License
// 
// Copyright (c) 2019 chillersanim
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

namespace UnityTools.Core
{
    /// <summary>
    /// Interface for classes that can be cleaned and reused
    /// </summary>
    public interface IReusable
    {
        /// <summary>
        /// Cleans this instance and restores the initial state as it was directly after construction.
        /// </summary>
        void Reuse();
    }
}
