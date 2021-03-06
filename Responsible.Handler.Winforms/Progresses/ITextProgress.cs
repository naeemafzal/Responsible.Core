﻿namespace Responsible.Handler.Winforms.Progresses
{
    /// <summary>
    /// To be used reporting text messages
    /// </summary>
    public interface ITextProgress
    {
        /// <summary>
        /// The message to report
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// A flag to specify to remove already reported messages from Reporting Alert
        /// </summary>
        bool CurrentMessageOnly { get; set; }
    }

    /// <summary>
    /// To be used reporting text messages
    /// </summary>
    public interface ITextProgressOutput
    {
        /// <summary>
        /// The message to report
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// A flag to specify to remove already reported messages from Reporting Alert
        /// </summary>
        bool CurrentMessageOnly { get; set; }

        /// <summary>
        /// An optional object which can be used to pass back information
        /// </summary>
        object Output { get; set; }
    }
}