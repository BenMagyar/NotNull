using System;
using System.Collections.Generic;

namespace NotNull
{
    public static class Helper
    {
        /// <summary>
        /// Returns <c>null</c> when null, otherwise it returns the output of the applied function.
        /// </summary>
        /// <returns><c>null</c> when item is null otherwise it returns the output of the applied function.</returns>
        /// <param name="item">Input Object.</param>
        /// <param name="function">Method called when the input object is not null</param>
        /// <typeparam name="TIn">Input Type.</typeparam>
        /// <typeparam name="TOut">Output Type.</typeparam>
        public static TOut IfNotNull<TIn, TOut>(this TIn item, Func<TIn, TOut> function) where TOut : class
        {
            return item != null ? function(item) : null;
        }

        /// <summary>
        /// Returns default value of <typeparamref>TOut</typeparamref> when null, otherwise it returns the 
        /// output of the applied function.
        /// </summary>
        /// <returns><c>null</c> when item is null otherwise it returns the output of the applied function.</returns>
        /// <param name="item">Input Object.</param>
        /// <param name="function">Method called when the input object is not null</param>
        /// <typeparam name="TIn">Input Type.</typeparam>
        /// <typeparam name="TOut">Output Type.</typeparam>
        public static TOut IfNotNullElseDefault<TIn, TOut>(this TIn item, Func<TIn, TOut> function)
        {
            return item != null ? function(item) : default(TOut); 
        }

        /// <summary>
        /// Runs the action when not null
        /// </summary>
        /// <param name="item">Input Object.</param>
        /// <param name="action">Action to run.</param>
        /// <typeparam name="TIn">Input Type.</typeparam>
        public static void IfNotNull<TIn>(this TIn item, Action<TIn> action)
        {
            if (item != null)
                action(item);
        }

        /// <summary>
        /// Returns default value of <typeparamref cref="TOut"/> when null or default, otherwise it returns the 
        /// output of the applied funciton.
        /// </summary>
        /// <param name="item">Item.</param>
        /// <param name="function">Function.</param>
        /// <typeparam name="TIn">Input Type.</typeparam>
        /// <typeparam name="TOut">Output Type.</typeparam>
        public static TOut IfNotNullOrDefault<TIn, TOut>(this TIn item, Func<TIn, TOut> function)
        {
            return item != null && !item.Equals(default(TIn)) ? function(item) : default(TOut);
        }

        /// <summary>
        /// Runs the action when not null or default value.
        /// </summary>
        /// <param name="item">Item.</param>
        /// <param name="action">Action to run.</param>
        /// <typeparam name="TIn">Input Type.</typeparam>
        public static void IfNotNullOrDefault<TIn>(this TIn item, Action<TIn> action)
        {
            if (item != null && !item.Equals(default(TIn)))
                action(item);
        }
    }
}

