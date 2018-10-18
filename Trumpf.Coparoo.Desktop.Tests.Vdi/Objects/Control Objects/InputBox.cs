﻿// Copyright 2016, 2017, 2018 TRUMPF Werkzeugmaschinen GmbH + Co. KG.
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

namespace VDI.ControlObjects
{
    using SmartBear.TestLeft.TestObjects;
    using SmartBear.TestLeft.TestObjects.Web;
    using Trumpf.Coparoo.Desktop.Web;

    public class InputBox : ControlObject, IInputBox
    {
        protected override Search SearchPattern
            => Search.ByClassName("input_box");

        public string Content
        {
            set
            {
                Node.Find<ITextEdit>(new WebElementPattern() { ObjectType = "Textbox" }).SetText(value);
            }
        }
    }
}