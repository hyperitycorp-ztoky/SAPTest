using System;
namespace SAPTest.Helpers
{
    public class OpentokTestConstants
    {
        //Fill this 3 values to make app work, GenerateSessionAndTokenWithServer must be false, otherwise you need to setup web server with generating session and token
        public const string OpentokAPI = "45986182";
        public const string SessionId = "1_MX40NTk4NjE4Mn5-MTUwODk5OTQ2MTk2NH5BNmJCeGdVYURPejVEQUM1bW5HaCtBTXZ-UH4";
#if __IOS__
        public const string Token = "T1==cGFydG5lcl9pZD00NTk4NjE4MiZzaWc9NTBjMDkyOWY4OWIzNTdmMDNmMzJhNTVkMGMzZDBlOTIzOWI4ODZiNDpzZXNzaW9uX2lkPTFfTVg0ME5UazROakU0TW41LU1UVXdPRGs1T1RRMk1UazJOSDVCTm1KQ2VHZFZZVVJQZWpWRVFVTTFiVzVIYUN0QlRYWi1VSDQmY3JlYXRlX3RpbWU9MTUwODk5OTQ4MSZub25jZT0wLjUxOTk5NzgxOTUwNjgwOTEmcm9sZT1wdWJsaXNoZXImZXhwaXJlX3RpbWU9MTUxMTU5MTQ4MyZpbml0aWFsX2xheW91dF9jbGFzc19saXN0PQ==";
#else
        public const string Token = "T1==cGFydG5lcl9pZD00NTk4NjE4MiZzaWc9YjNkMDBkNDI2M2Y4MmExYTcwNDliODQ3MGMwZTJkM2M5ZmJkYTg5YzpzZXNzaW9uX2lkPTFfTVg0ME5UazROakU0TW41LU1UVXdPRGs1T1RRMk1UazJOSDVCTm1KQ2VHZFZZVVJQZWpWRVFVTTFiVzVIYUN0QlRYWi1VSDQmY3JlYXRlX3RpbWU9MTUwOTAxMTM4OCZub25jZT0wLjM3NzIwMjMwMTU3MDI3OTkmcm9sZT1wdWJsaXNoZXImZXhwaXJlX3RpbWU9MTUxMTYwMzM4NyZpbml0aWFsX2xheW91dF9jbGFzc19saXN0PQ==";
#endif
        public const bool GenerateSessionAndTokenWithServer = false;
        public const string ShareString = "Hey check out Xamarin Opentok sample app at: https://drmtm.us/videosample";
    }
}
