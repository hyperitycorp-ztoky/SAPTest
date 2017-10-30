using System;
namespace SAPTest
{
    public interface IOpentokStreamingService
    {
        void InitNewSession(string apiKey, string sessionId, string userToken);
        void EndSession();
        void Dispose();
        bool IsVideoPublishingEnabled
        {
            get;
            set;
        }
        bool IsAudioPublishingEnabled
        {
            get;
            set;
        }
        bool IsVideoSubscriptionEnabled
        {
            get;
            set;
        }
        bool IsAudioSubscriptionEnabled
        {
            get;
            set;
        }
        bool IsSubscriberVideoEnabled
        {
            get;
        }
        void SwapCamera();
        void SetStreamContainer(object container, bool myStream);
    }
}
