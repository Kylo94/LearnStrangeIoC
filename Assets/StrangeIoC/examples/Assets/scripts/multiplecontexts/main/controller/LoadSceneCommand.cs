/*
 * Copyright 2013 ThirdMotion, Inc.
 *
 *	Licensed under the Apache License, Version 2.0 (the "License");
 *	you may not use this file except in compliance with the License.
 *	You may obtain a copy of the License at
 *
 *		http://www.apache.org/licenses/LICENSE-2.0
 *
 *		Unless required by applicable law or agreed to in writing, software
 *		distributed under the License is distributed on an "AS IS" BASIS,
 *		WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *		See the License for the specific language governing permissions and
 *		limitations under the License.
 */

/// LoadSceneCommand
/// ============================
/// This Command adds a Scene to the current one

using System;
using strange.extensions.command.impl;
using UnityEngine;

namespace strange.examples.multiplecontexts.main
{
    public class LoadSceneCommand : EventCommand
    {
        public override void Execute()
        {
            var filepath = evt.data as string;

            //Load the component
            if (string.IsNullOrEmpty(filepath))
                throw new Exception("Can't load a module with a null or empty filepath.");
#pragma warning disable 618
            Application.LoadLevelAdditive(filepath);
#pragma warning restore 618
        }
    }
}
