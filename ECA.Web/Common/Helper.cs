using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Security.Policy;
using System.Web.Mvc;


namespace ECA.Web.Common
{
    public static  class Helper
    {
       public static Message GetMessage(string strCode)
       {
           
           XElement root = XElement.Load(HttpContext.Current.Server.MapPath("~/Config/MessageConfig.xml"));
           var message = (from el in root.Elements("Message")
                          where el.Attribute("Code").Value == strCode
                              select el ).Single();

           Message objMessage = new Message(message.Elements("General").Single().Value, message.Elements("Specific").Single().Value);
           return objMessage;

       }
    }
}