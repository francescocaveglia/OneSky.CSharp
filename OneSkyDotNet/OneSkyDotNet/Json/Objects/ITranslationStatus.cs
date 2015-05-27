﻿namespace OneSkyDotNet.Json
{
    interface ITranslationStatus
    {
        string FileName { get; }

        ILocale Locale { get; }

        string Progress { get; }

        int StringCount { get; }

        int WordCount { get; }
    }
}
