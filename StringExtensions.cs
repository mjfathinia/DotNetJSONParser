using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Drawing;
using System.IO;
using System.Web.UI;
using System.Web.Script.Serialization;
using Cheraq.Utilities;

namespace Cheraq.Extensions
{
    /// <summary>
    /// Contains list of usefull extensions for String type
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Parses this string and returns equivalent dynamic object, always check for null values :)
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public static dynamic ParseJSON(this string phrase)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            jss.RegisterConverters(new JavaScriptConverter[] { new DynamicJsonConverter() });
            dynamic obj = jss.Deserialize(phrase, typeof(object));
            return obj;
        }

    }
}
