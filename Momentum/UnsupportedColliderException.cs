using System;

namespace Momentum;

public class UnsupportedColliderException : Exception
{
    public UnsupportedColliderException() : base()
    {
    }

    public UnsupportedColliderException(string message) : base(message)
    {
    }

    public UnsupportedColliderException(string message, Exception inner) : base(message, inner)
    {
    }
}