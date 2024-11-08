using System;

namespace Common.CustomException
{
    public class NotAuthorizeResourceException : Exception
    {
        public NotAuthorizeResourceException()
        {

        }

        public NotAuthorizeResourceException(string name) : base( string.Format("You are not authorized for this resource: {0}", name)) { }
    }
}
