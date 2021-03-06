﻿namespace Responsible.Handler.Winforms.Progresses
{
    /// <inheritdoc />
    public sealed class TextProgress : ITextProgress
    {
        /// <inheritdoc />
        public string Message { get; set; }

        /// <inheritdoc />
        public bool CurrentMessageOnly { get; set; }
    }

    /// <inheritdoc />
    public sealed class TextProgressOutput : ITextProgressOutput
    {
        /// <inheritdoc />
        public string Message { get; set; }

        /// <inheritdoc />
        public bool CurrentMessageOnly { get; set; }

        /// <inheritdoc />
        public object Output { get; set; }
    }
}