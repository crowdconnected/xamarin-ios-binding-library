using System;
using Foundation;
using ObjCRuntime;


namespace CCLocation {

	// @interface CCLocation : NSObject
	[BaseType(typeof(NSObject))]
	interface CCLocation
	{
        [Wrap("WeakDelegate")]
        [NullAllowed]
        CCLocationDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<CCLocation> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong, class) CCLocation * _Nonnull sharedInstance;
		[Static]
		[Export("sharedInstance", ArgumentSemantic.Strong)]
		CCLocation SharedInstance { get; }

		// -(void)startWithApiKey:(NSString * _Nonnull)apiKey urlString:(NSString * _Nullable)urlString;
		[Export("startWithApiKey:urlString:")]
		void StartWithApiKey(string apiKey, [NullAllowed] string urlString);

		// -(void)stop;
		[Export("stop")]
		void Stop();

		// -(void)setLoggerLevelsWithVerbose:(BOOL)verbose info:(BOOL)info debug:(BOOL)debug warning:(BOOL)warning error:(BOOL)error severe:(BOOL)severe;
		[Export("setLoggerLevelsWithVerbose:info:debug:warning:error:severe:")]
		void SetLoggerLevelsWithVerbose(bool verbose, bool info, bool debug, bool warning, bool error, bool severe);

		// -(void)setSurveyModeWithState:(BOOL)state;
		[Export("setSurveyModeWithState:")]
		void SetSurveyModeWithState(bool state);

		// -(NSString * _Nullable)getDeviceId __attribute__((warn_unused_result));
		[NullAllowed, Export("getDeviceId")]
		string DeviceId { get; }

		// -(void)setAliasesWithAliases:(NSDictionary<NSString *,NSString *> * _Nonnull)aliases __attribute__((deprecated("Replaced by addAlias(key, value) method")));
		[Export("setAliasesWithAliases:")]
		void SetAliasesWithAliases(NSDictionary<NSString, NSString> aliases);

		// -(void)addAliasWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		[Export("addAliasWithKey:value:")]
		void AddAliasWithKey(string key, string value);

		// +(void)askMotionPermissions __attribute__((deprecated("Replaced by triggerMotionPermissionPopUp() method")));
		[Static]
		[Export("askMotionPermissions")]
		void AskMotionPermissions();

		// -(void)triggerMotionPermissionPopUp;
		[Export("triggerMotionPermissionPopUp")]
		void TriggerMotionPermissionPopUp();

		// -(void)triggerBluetoothPermissionPopUp;
		[Export("triggerBluetoothPermissionPopUp")]
		void TriggerBluetoothPermissionPopUp();

		// -(void)receivedSilentNotificationWithUserInfo:(NSDictionary * _Nonnull)userInfo clientKey:(NSString * _Nonnull)key completion:(void (^ _Nonnull)(BOOL))completion;
		[Export("receivedSilentNotificationWithUserInfo:clientKey:completion:")]
		void ReceivedSilentNotificationWithUserInfo(NSDictionary userInfo, string key, Action<bool> completion);

		// -(void)updateLibraryBasedOnClientStatusWithClientKey:(NSString * _Nonnull)key isSilentNotification:(BOOL)isSilentNotification completion:(void (^ _Nonnull)(BOOL))completion;
		[Export("updateLibraryBasedOnClientStatusWithClientKey:isSilentNotification:completion:")]
		void UpdateLibraryBasedOnClientStatusWithClientKey(string key, bool isSilentNotification, Action<bool> completion);

		// -(void)requestLocation;
		[Export("requestLocation")]
		void RequestLocation();

		// -(void)registerLocationListener;
		[Export("registerLocationListener")]
		void RegisterLocationListener();

		// -(void)unregisterLocationListener;
		[Export("unregisterLocationListener")]
		void UnregisterLocationListener();

		// -(NSString * _Nonnull)testLibraryIntegration __attribute__((warn_unused_result));
		[Export("testLibraryIntegration")]
		string TestLibraryIntegration { get; }
	}

    // @protocol CCLocationDelegate
    [BaseType(typeof(NSObject))]
    [Model]
    interface CCLocationDelegate
    {

        //@required -(void) ccLocationDidConnect;
        [Abstract]
        [Export("ccLocationDidConnect")]
        void CcLocationDidConnect();

        // @required -(void)ccLocationDidFailWithErrorWithError:(NSError * _Nonnull)error;
        [Abstract]
        [Export("ccLocationDidFailWithErrorWithError:")]
        void CcLocationDidFailWithErrorWithError(NSError error);

        // @required -(void)didReceiveCCLocation:(LocationResponse * _Nonnull)location;
        [Abstract]
        [Export("didReceiveCCLocation:")]
        void DidReceiveCCLocation(LocationResponse location);
    }

    // @interface LocationResponse : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10CCLocation16LocationResponse")]
    [DisableDefaultCtor]
    interface LocationResponse
    {
	    // @property (nonatomic) double latitude;
	    [Export("latitude")]
	    double Latitude { get; set; }

	    // @property (nonatomic) double longitude;
	    [Export("longitude")]
	    double Longitude { get; set; }

	    // @property (nonatomic) double headingOffSet;
	    [Export("headingOffSet")]
	    double HeadingOffSet { get; set; }

	    // @property (nonatomic) double error;
	    [Export("error")]
	    double Error { get; set; }

	    // @property (nonatomic) uint64_t timestamp;
	    [Export("timestamp")]
	    ulong Timestamp { get; set; }

	    // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	    [Static]
	    [Export("new")]
	    LocationResponse New();
    }
}