using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

class Program
{
    static void Main(string[] args)
    {
        TwilioClient.Init("YOU_PROJECT_ID",
                          "YOU_PROJECT_ID",
                           new Dictionary<string, object> { ["signalwireSpaceUrl"] = "joshebosh.signalwire.com" });

	string toNumber = "+1XXXYYYZZZZ";

        var message = MessageResource.Create(
            to: new Twilio.Types.PhoneNumber(toNumber),
            //to: new Twilio.Types.PhoneNumber("+1XXXYYYZZZZ"),
            from: new Twilio.Types.PhoneNumber("+1XXXYYYZZZZ"),
            body: "Hello World!"
        );

        Console.WriteLine(message.Sid);
    }
}
