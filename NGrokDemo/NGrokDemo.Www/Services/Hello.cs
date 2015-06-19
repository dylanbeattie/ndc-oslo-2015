using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using ServiceStack;

namespace NGrokDemo.Www.Services {
    /// <summary>
    /// Define your ServiceStack web service request (i.e. the Request DTO).
    /// </summary>    
    public class Hello {
        public string Language { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// Define your ServiceStack web service response (i.e. Response DTO).
    /// </summary>
    public class HelloResponse {
        public string Greeting { get; set; }
    }

    /// <summary>
    /// Create your ServiceStack web service implementation.
    /// </summary>
    public class HelloService : IService {
        public object Any(Hello request) {
            var template = "Hello, {0}!";
            switch (request.Language) {
                case "no":
                    template = "Hei, {0}!";
                    break;
                case "tlh":
                    template = "nuqneH {0}";
                    break;
                case "fr":
                    template = "Bonjour, {0}!";
                    break;
            }
            //Looks strange when the name is null so we replace with a generic name.
            var name = request.Name ?? "NDC Oslo";
            return new HelloResponse { Greeting = String.Format(template, name) };
        }
    }
}