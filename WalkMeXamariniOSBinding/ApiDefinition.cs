using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace WalkMeXamariniOSBinding
{
    // @interface WMUserData : NSObject
    [BaseType(typeof(NSObject))]
    interface WMUserData
    {
        // @property (nonatomic, strong) NSDictionary * userAttributes;
        [Export("userAttributes", ArgumentSemantic.Strong)]
        NSDictionary UserAttributes { get; set; }

        // @property (nonatomic, strong) NSDictionary * privateUserAttributes;
        [Export("privateUserAttributes", ArgumentSemantic.Strong)]
        NSDictionary PrivateUserAttributes { get; set; }

        // @property (nonatomic, strong) NSNumber * sessionDuration;
        [Export("sessionDuration", ArgumentSemantic.Strong)]
        NSNumber SessionDuration { get; set; }

        // @property (nonatomic, strong) NSString * systemVersion;
        [Export("systemVersion", ArgumentSemantic.Strong)]
        string SystemVersion { get; set; }

        // @property (nonatomic, strong) NSString * deviceId;
        [Export("deviceId", ArgumentSemantic.Strong)]
        string DeviceId { get; set; }

        // @property (nonatomic, strong) NSString * deviceModel;
        [Export("deviceModel", ArgumentSemantic.Strong)]
        string DeviceModel { get; set; }

        // @property (nonatomic, strong) NSString * deviceOrientation;
        [Export("deviceOrientation", ArgumentSemantic.Strong)]
        string DeviceOrientation { get; set; }

        // @property (nonatomic, strong) NSString * appVersion;
        [Export("appVersion", ArgumentSemantic.Strong)]
        string AppVersion { get; set; }

        // @property (nonatomic, strong) NSString * appName;
        [Export("appName", ArgumentSemantic.Strong)]
        string AppName { get; set; }

        // @property (nonatomic, strong) NSString * locale;
        [Export("locale", ArgumentSemantic.Strong)]
        string Locale { get; set; }

        // @property (nonatomic, strong) NSString * sdkVer;
        [Export("sdkVer", ArgumentSemantic.Strong)]
        string SdkVer { get; set; }

        // @property (nonatomic, strong) NSString * sessionId;
        [Export("sessionId", ArgumentSemantic.Strong)]
        string SessionId { get; set; }

        // @property (nonatomic, strong) NSString * isPushEnabled;
        [Export("isPushEnabled", ArgumentSemantic.Strong)]
        string IsPushEnabled { get; set; }

        // @property (nonatomic, strong) NSString * timezone;
        [Export("timezone", ArgumentSemantic.Strong)]
        string Timezone { get; set; }

        // @property (nonatomic, strong) NSString * network;
        [Export("network", ArgumentSemantic.Strong)]
        string Network { get; set; }

        // @property (nonatomic, strong) NSString * systemName;
        [Export("systemName", ArgumentSemantic.Strong)]
        string SystemName { get; set; }

        // @property (nonatomic, strong) NSNumber * userCreationTimestamp;
        [Export("userCreationTimestamp", ArgumentSemantic.Strong)]
        NSNumber UserCreationTimestamp { get; set; }

        // @property (assign, nonatomic) BOOL isNewUser;
        [Export("isNewUser")]
        bool IsNewUser { get; set; }
    }

    // @interface WMCampaignInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface WMCampaignInfo
    {
        // @property (nonatomic, strong) NSString * campaginCta;
        [Export("campaginCta", ArgumentSemantic.Strong)]
        string CampaginCta { get; set; }

        // @property (nonatomic, strong) NSString * campaignCtaId;
        [Export("campaignCtaId", ArgumentSemantic.Strong)]
        string CampaignCtaId { get; set; }

        // @property (nonatomic, strong) NSString * campaignId;
        [Export("campaignId", ArgumentSemantic.Strong)]
        string CampaignId { get; set; }

        // @property (nonatomic, strong) WMUserData * userData;
        [Export("userData", ArgumentSemantic.Strong)]
        WMUserData UserData { get; set; }

        // @property (nonatomic, strong) NSDictionary * campaignData;
        [Export("campaignData", ArgumentSemantic.Strong)]
        NSDictionary CampaignData { get; set; }
    }

    // @protocol WMCampaignInfoDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface WMCampaignInfoDelegate
    {
        // @required -(void)campaignDidDismiss:(WMCampaignInfo *)campaignInfo;
        [Abstract]
        [Export("campaignDidDismiss:")]
        void CampaignDidDismiss(WMCampaignInfo campaignInfo);
    }

    // @interface ABBI : NSObject
    [BaseType(typeof(NSObject))]
    interface ABBI
    {
        [Wrap("WeakCampaignInfoDelegate")]
        WMCampaignInfoDelegate CampaignInfoDelegate { get; set; }

        // @property (nonatomic, weak) id<WMCampaignInfoDelegate> campaignInfoDelegate;
        [NullAllowed, Export("campaignInfoDelegate", ArgumentSemantic.Weak)]
        NSObject WeakCampaignInfoDelegate { get; set; }

        // +(void)start:(NSString *)appId withSecretKey:(NSString *)appSecretKey;
        [Static]
        [Export("start:withSecretKey:")]
        void Start(string appId, string appSecretKey);

        // +(void)start:(NSString *)appId withSecretKey:(NSString *)appSecretKey andApplicationType:(ABBIAppType)type;
        [Static]
        [Export("start:withSecretKey:andApplicationType:")]
        void Start(string appId, string appSecretKey, ABBIAppType type);

        // +(void)sendGoal:(NSString *)goalName withProperites:(NSDictionary *)properties;
        [Static]
        [Export("sendGoal:withProperites:")]
        void SendGoal(string goalName, NSDictionary properties);

        // +(void)setUserAttributeWithKey:(NSString *)key andValue:(id)value;
        [Static]
        [Export("setUserAttributeWithKey:andValue:")]
        void SetUserAttributeWithKey(string key, NSObject value);

        // +(void)setUserAttributes:(NSDictionary<NSString *,id> *)attributes;
        [Static]
        [Export("setUserAttributes:")]
        void SetUserAttributes(NSDictionary<NSString, NSObject> attributes);

        // +(void)setPrivateUserAttributeWithKey:(NSString *)key andValue:(id)value;
        [Static]
        [Export("setPrivateUserAttributeWithKey:andValue:")]
        void SetPrivateUserAttributeWithKey(string key, NSObject value);

        // +(void)setPrivateUserAttributes:(NSDictionary<NSString *,id> *)attributes;
        [Static]
        [Export("setPrivateUserAttributes:")]
        void SetPrivateUserAttributes(NSDictionary<NSString, NSObject> attributes);

        // +(void)clearPrivateUserAttributes;
        [Static]
        [Export("clearPrivateUserAttributes")]
        void ClearPrivateUserAttributes();

        // +(void)setFlag:(int)n;
        [Static]
        [Export("setFlag:")]
        void SetFlag(int n);

        // +(void)trigger:(NSString *)myTriggerName;
        [Static]
        [Export("trigger:")]
        void Trigger(string myTriggerName);

        // +(void)setUserID:(NSString *)userId;
        [Static]
        [Export("setUserID:")]
        void SetUserID(string userId);

        // +(void)setCampaignInfoDelegate:(id<WMCampaignInfoDelegate>)delegate;
        [Static]
        [Export("setCampaignInfoDelegate:")]
        void SetCampaignInfoDelegate(WMCampaignInfoDelegate @delegate);
    }
}
