using System;

namespace GLU.Input
{
    internal static class Events
    {
        internal static T Try<T>(Func<T> callback, string errorMessage)
        {
            try
            {
                return callback();
            }
            catch (Exception e)
            {
                throw new ArgumentOutOfRangeException($"[<color=#ff0000>{errorMessage}</color>]", e);
            }
        }
    }
}
