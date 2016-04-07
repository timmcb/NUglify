﻿// ArrayHandling.cs
//
// Copyright 2010 Microsoft Corporation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.Ajax.Utilities;
using NUnit.Framework;

namespace JSUnitTest
{
    /// <summary>
    ///This is a test class for Microsoft.Ajax.Utilities.MainClass and is intended
    ///to contain all Microsoft.Ajax.Utilities.MainClass Unit Tests
    ///</summary>
    [TestFixture]
    public class ArrayHandling
    {
        [Test]
        public void Array()
        {
            TestHelper.Instance.RunErrorTest(JSError.UndeclaredFunction, JSError.ArrayLiteralTrailingComma, JSError.ArrayLiteralTrailingComma, JSError.ArrayLiteralTrailingComma, JSError.ArrayLiteralTrailingComma);
        }

        [Test]
        public void Array_L()
        {
            TestHelper.Instance.RunTest("-new:keep");
        }

        [Test]
        public void Join()
        {
            TestHelper.Instance.RunTest();
        }

        [Test]
        public void Length()
        {
            TestHelper.Instance.RunTest();
        }

        [Test]
        public void Reverse()
        {
            TestHelper.Instance.RunTest();
        }

        [Test]
        public void Sort()
        {
            TestHelper.Instance.RunTest();
        }

        [Test]
        public void Spread()
        {
            TestHelper.Instance.RunTest();
        }
    }
}