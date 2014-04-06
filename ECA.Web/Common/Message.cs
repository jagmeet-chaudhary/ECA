using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECA.Web.Common
{
    public class Message
    {
        public Message()
        {
        }
        public Message(String strGeneralMessage, String strSpecificMessage)
        {
            GeneralMessage = strGeneralMessage;
            SpecificMessage = strSpecificMessage;
        }
        public String GeneralMessage { get; set; }
        public String SpecificMessage { get; set; }
    }
}