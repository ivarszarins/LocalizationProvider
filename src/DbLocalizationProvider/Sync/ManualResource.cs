// Copyright (c) Valdis Iljuconoks. All rights reserved.
// Licensed under Apache-2.0. See the LICENSE file in the project root for more information

using System;

namespace DbLocalizationProvider.Sync
{
    public class ManualResource
    {
        public ManualResource(string key, string translation)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));

            Key = key;
            Translation = translation ?? throw new ArgumentNullException(nameof(translation));
        }

        public string Key { get; }

        public string Translation { get; }
    }
}
