// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Diagnostics.Contracts;

namespace System.Runtime.Remoting
{

    public class ActivatedClientTypeEntry
    {

        public string ApplicationUrl
        {
          get;
        }

        public Type ObjectType
        {
          get;
        }

        public System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes
        {
          get;
          set;
        }

        [Pure][Reads(ReadsAttribute.Reads.Owned)]
        public string ToString () {

          return default(string);
        }
        public ActivatedClientTypeEntry (Type! type, string! appUrl) {
            CodeContract.Requires(type != null);
            CodeContract.Requires(appUrl != null);

          return default(ActivatedClientTypeEntry);
        }
        public ActivatedClientTypeEntry (string! typeName, string! assemblyName, string! appUrl) {
            CodeContract.Requires(typeName != null);
            CodeContract.Requires(assemblyName != null);
            CodeContract.Requires(appUrl != null);
          return default(ActivatedClientTypeEntry);
        }
    }
}
