#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#define DEBUG 1
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@class UIApplicationDelegate;
@class Foundation_NSDispatcher;
@class __MonoMac_NSSynchronizationContextDispatcher;
@class Foundation_NSAsyncDispatcher;
@class __MonoMac_NSAsyncSynchronizationContextDispatcher;
@class AppDelegate;
@class ViewController;
@class __NSObject_Disposer;
@class ABBI;
@class WMCampaignInfo;
@protocol WMCampaignInfoDelegate;
@class WMCampaignInfoDelegate;
@class WMUserData;

@interface UIApplicationDelegate : NSObject<UIApplicationDelegate> {
}
	-(id) init;
@end

@interface AppDelegate : NSObject<UIApplicationDelegate, UIApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(void) applicationWillResignActive:(UIApplication *)p0;
	-(void) applicationDidEnterBackground:(UIApplication *)p0;
	-(void) applicationWillEnterForeground:(UIApplication *)p0;
	-(void) applicationDidBecomeActive:(UIApplication *)p0;
	-(void) applicationWillTerminate:(UIApplication *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface ViewController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ABBI : NSObject {
}
	-(NSObject *) campaignInfoDelegate;
	-(void) setCampaignInfoDelegate:(NSObject *)p0;
	-(id) init;
@end

@interface WMCampaignInfo : NSObject {
}
	-(NSString *) campaginCta;
	-(void) setCampaginCta:(NSString *)p0;
	-(NSString *) campaignCtaId;
	-(void) setCampaignCtaId:(NSString *)p0;
	-(NSDictionary *) campaignData;
	-(void) setCampaignData:(NSDictionary *)p0;
	-(NSString *) campaignId;
	-(void) setCampaignId:(NSString *)p0;
	-(id) userData;
	-(void) setUserData:(id)p0;
	-(id) init;
@end

@protocol WMCampaignInfoDelegate
	@required -(void) campaignDidDismiss:(id)p0;
@end

@interface WMCampaignInfoDelegate : NSObject<WMCampaignInfoDelegate> {
}
	-(id) init;
@end

@interface WMUserData : NSObject {
}
	-(NSString *) appName;
	-(void) setAppName:(NSString *)p0;
	-(NSString *) appVersion;
	-(void) setAppVersion:(NSString *)p0;
	-(NSString *) deviceId;
	-(void) setDeviceId:(NSString *)p0;
	-(NSString *) deviceModel;
	-(void) setDeviceModel:(NSString *)p0;
	-(NSString *) deviceOrientation;
	-(void) setDeviceOrientation:(NSString *)p0;
	-(BOOL) isNewUser;
	-(void) setIsNewUser:(BOOL)p0;
	-(NSString *) isPushEnabled;
	-(void) setIsPushEnabled:(NSString *)p0;
	-(NSString *) locale;
	-(void) setLocale:(NSString *)p0;
	-(NSString *) network;
	-(void) setNetwork:(NSString *)p0;
	-(NSDictionary *) privateUserAttributes;
	-(void) setPrivateUserAttributes:(NSDictionary *)p0;
	-(NSString *) sdkVer;
	-(void) setSdkVer:(NSString *)p0;
	-(NSNumber *) sessionDuration;
	-(void) setSessionDuration:(NSNumber *)p0;
	-(NSString *) sessionId;
	-(void) setSessionId:(NSString *)p0;
	-(NSString *) systemName;
	-(void) setSystemName:(NSString *)p0;
	-(NSString *) systemVersion;
	-(void) setSystemVersion:(NSString *)p0;
	-(NSString *) timezone;
	-(void) setTimezone:(NSString *)p0;
	-(NSDictionary *) userAttributes;
	-(void) setUserAttributes:(NSDictionary *)p0;
	-(NSNumber *) userCreationTimestamp;
	-(void) setUserCreationTimestamp:(NSNumber *)p0;
	-(id) init;
@end


