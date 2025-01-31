using System;

namespace GLU.Input
{
    internal class Events
    {
        public static T Try<T>(Func<T> callback, string errorMessage)
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
