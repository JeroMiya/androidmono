namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Settings : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Settings(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class NameValueTable : java.lang.Object, BaseColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected NameValueTable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected static bool putString(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String arg2, java.lang.String arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.NameValueTable._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.NameValueTable._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.NameValueTable.staticClass, "putString", "(Landroid/content/ContentResolver;Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.NameValueTable.staticClass, global::android.provider.Settings.NameValueTable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.net.Uri getUriFor(android.net.Uri arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.NameValueTable._m1.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.NameValueTable._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.NameValueTable.staticClass, "getUriFor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.Settings.NameValueTable.staticClass, global::android.provider.Settings.NameValueTable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public NameValueTable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.NameValueTable._m2.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.NameValueTable._m2 = @__env.GetMethodIDNoThrow(global::android.provider.Settings.NameValueTable.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Settings.NameValueTable.staticClass, global::android.provider.Settings.NameValueTable._m2);
				Init(@__env, handle);
			}
			public static global::java.lang.String NAME
			{
				get
				{
					return "name";
				}
			}
			public static global::java.lang.String VALUE
			{
				get
				{
					return "value";
				}
			}
			static NameValueTable()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Settings.NameValueTable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Settings$NameValueTable"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Secure : android.provider.Settings.NameValueTable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Secure(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)I");
				return @__env.CallStaticIntMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m1.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;)I");
				return @__env.CallStaticIntMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public static bool putInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m2.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m2 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "putInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m3.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m3 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;)J");
				return @__env.CallStaticLongMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m4.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m4 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)J");
				return @__env.CallStaticLongMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public static bool putLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m5.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m5 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "putLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m6.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m6 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)F");
				return @__env.CallStaticFloatMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m7.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m7 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;)F");
				return @__env.CallStaticFloatMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public static bool putFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m8.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m8 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "putFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public static global::java.lang.String getString(android.content.ContentResolver arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m9.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m9 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "getString", "(Landroid/content/ContentResolver;Ljava/lang/String;)Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public static bool putString(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m10.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m10 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "putString", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m11;
			public static global::android.net.Uri getUriFor(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m11.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m11 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "getUriFor", "(Ljava/lang/String;)Landroid/net/Uri;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
			}
			private static global::MonoJavaBridge.MethodId _m12;
			public static bool isLocationProviderEnabled(android.content.ContentResolver arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m12.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m12 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "isLocationProviderEnabled", "(Landroid/content/ContentResolver;Ljava/lang/String;)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m13;
			public static void setLocationProviderEnabled(android.content.ContentResolver arg0, java.lang.String arg1, bool arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m13.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m13 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "setLocationProviderEnabled", "(Landroid/content/ContentResolver;Ljava/lang/String;Z)V");
				@__env.CallStaticVoidMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m14;
			public Secure() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.Secure._m14.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.Secure._m14 = @__env.GetMethodIDNoThrow(global::android.provider.Settings.Secure.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._m14);
				Init(@__env, handle);
			}
			public static global::java.lang.String SYS_PROP_SETTING_VERSION
			{
				get
				{
					return "sys.settings_secure_version";
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4796;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Settings.Secure.staticClass, _CONTENT_URI4796)) as android.net.Uri;
				}
			}
			public static global::java.lang.String ADB_ENABLED
			{
				get
				{
					return "adb_enabled";
				}
			}
			public static global::java.lang.String ALLOW_MOCK_LOCATION
			{
				get
				{
					return "mock_location";
				}
			}
			public static global::java.lang.String ANDROID_ID
			{
				get
				{
					return "android_id";
				}
			}
			public static global::java.lang.String BLUETOOTH_ON
			{
				get
				{
					return "bluetooth_on";
				}
			}
			public static global::java.lang.String DATA_ROAMING
			{
				get
				{
					return "data_roaming";
				}
			}
			public static global::java.lang.String DEFAULT_INPUT_METHOD
			{
				get
				{
					return "default_input_method";
				}
			}
			public static global::java.lang.String DEVICE_PROVISIONED
			{
				get
				{
					return "device_provisioned";
				}
			}
			public static global::java.lang.String ENABLED_INPUT_METHODS
			{
				get
				{
					return "enabled_input_methods";
				}
			}
			public static global::java.lang.String HTTP_PROXY
			{
				get
				{
					return "http_proxy";
				}
			}
			public static global::java.lang.String INSTALL_NON_MARKET_APPS
			{
				get
				{
					return "install_non_market_apps";
				}
			}
			public static global::java.lang.String LOCATION_PROVIDERS_ALLOWED
			{
				get
				{
					return "location_providers_allowed";
				}
			}
			public static global::java.lang.String LOCK_PATTERN_ENABLED
			{
				get
				{
					return "lock_pattern_autolock";
				}
			}
			public static global::java.lang.String LOCK_PATTERN_VISIBLE
			{
				get
				{
					return "lock_pattern_visible_pattern";
				}
			}
			public static global::java.lang.String LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED
			{
				get
				{
					return "lock_pattern_tactile_feedback_enabled";
				}
			}
			public static global::java.lang.String LOGGING_ID
			{
				get
				{
					return "logging_id";
				}
			}
			public static global::java.lang.String NETWORK_PREFERENCE
			{
				get
				{
					return "network_preference";
				}
			}
			public static global::java.lang.String PARENTAL_CONTROL_ENABLED
			{
				get
				{
					return "parental_control_enabled";
				}
			}
			public static global::java.lang.String PARENTAL_CONTROL_LAST_UPDATE
			{
				get
				{
					return "parental_control_last_update";
				}
			}
			public static global::java.lang.String PARENTAL_CONTROL_REDIRECT_URL
			{
				get
				{
					return "parental_control_redirect_url";
				}
			}
			public static global::java.lang.String SETTINGS_CLASSNAME
			{
				get
				{
					return "settings_classname";
				}
			}
			public static global::java.lang.String USB_MASS_STORAGE_ENABLED
			{
				get
				{
					return "usb_mass_storage_enabled";
				}
			}
			public static global::java.lang.String USE_GOOGLE_MAIL
			{
				get
				{
					return "use_google_mail";
				}
			}
			public static global::java.lang.String ACCESSIBILITY_ENABLED
			{
				get
				{
					return "accessibility_enabled";
				}
			}
			public static global::java.lang.String ENABLED_ACCESSIBILITY_SERVICES
			{
				get
				{
					return "enabled_accessibility_services";
				}
			}
			public static global::java.lang.String TTS_USE_DEFAULTS
			{
				get
				{
					return "tts_use_defaults";
				}
			}
			public static global::java.lang.String TTS_DEFAULT_RATE
			{
				get
				{
					return "tts_default_rate";
				}
			}
			public static global::java.lang.String TTS_DEFAULT_PITCH
			{
				get
				{
					return "tts_default_pitch";
				}
			}
			public static global::java.lang.String TTS_DEFAULT_SYNTH
			{
				get
				{
					return "tts_default_synth";
				}
			}
			public static global::java.lang.String TTS_DEFAULT_LANG
			{
				get
				{
					return "tts_default_lang";
				}
			}
			public static global::java.lang.String TTS_DEFAULT_COUNTRY
			{
				get
				{
					return "tts_default_country";
				}
			}
			public static global::java.lang.String TTS_DEFAULT_VARIANT
			{
				get
				{
					return "tts_default_variant";
				}
			}
			public static global::java.lang.String TTS_ENABLED_PLUGINS
			{
				get
				{
					return "tts_enabled_plugins";
				}
			}
			public static global::java.lang.String WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON
			{
				get
				{
					return "wifi_networks_available_notification_on";
				}
			}
			public static global::java.lang.String WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY
			{
				get
				{
					return "wifi_networks_available_repeat_delay";
				}
			}
			public static global::java.lang.String WIFI_NUM_OPEN_NETWORKS_KEPT
			{
				get
				{
					return "wifi_num_open_networks_kept";
				}
			}
			public static global::java.lang.String WIFI_ON
			{
				get
				{
					return "wifi_on";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE
			{
				get
				{
					return "wifi_watchdog_acceptable_packet_loss_percentage";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_AP_COUNT
			{
				get
				{
					return "wifi_watchdog_ap_count";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS
			{
				get
				{
					return "wifi_watchdog_background_check_delay_ms";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED
			{
				get
				{
					return "wifi_watchdog_background_check_enabled";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS
			{
				get
				{
					return "wifi_watchdog_background_check_timeout_ms";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT
			{
				get
				{
					return "wifi_watchdog_initial_ignored_ping_count";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_MAX_AP_CHECKS
			{
				get
				{
					return "wifi_watchdog_max_ap_checks";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_ON
			{
				get
				{
					return "wifi_watchdog_on";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_WATCH_LIST
			{
				get
				{
					return "wifi_watchdog_watch_list";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_PING_COUNT
			{
				get
				{
					return "wifi_watchdog_ping_count";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_PING_DELAY_MS
			{
				get
				{
					return "wifi_watchdog_ping_delay_ms";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_PING_TIMEOUT_MS
			{
				get
				{
					return "wifi_watchdog_ping_timeout_ms";
				}
			}
			public static global::java.lang.String WIFI_MAX_DHCP_RETRY_COUNT
			{
				get
				{
					return "wifi_max_dhcp_retry_count";
				}
			}
			public static global::java.lang.String WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS
			{
				get
				{
					return "wifi_mobile_data_transition_wakelock_timeout_ms";
				}
			}
			public static global::java.lang.String BACKGROUND_DATA
			{
				get
				{
					return "background_data";
				}
			}
			public static global::java.lang.String ALLOWED_GEOLOCATION_ORIGINS
			{
				get
				{
					return "allowed_geolocation_origins";
				}
			}
			static Secure()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Settings.Secure.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Settings$Secure"));
				global::android.provider.Settings.Secure._CONTENT_URI4796 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Settings.Secure.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SettingNotFoundException : android.util.AndroidException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SettingNotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public SettingNotFoundException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.SettingNotFoundException._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.SettingNotFoundException._m0 = @__env.GetMethodIDNoThrow(global::android.provider.Settings.SettingNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Settings.SettingNotFoundException.staticClass, global::android.provider.Settings.SettingNotFoundException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static SettingNotFoundException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Settings.SettingNotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Settings$SettingNotFoundException"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class System : android.provider.Settings.NameValueTable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal System(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)I");
				return @__env.CallStaticIntMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m1.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;)I");
				return @__env.CallStaticIntMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public static bool putInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m2.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m2 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "putInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m3.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m3 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;)J");
				return @__env.CallStaticLongMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m4.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m4 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)J");
				return @__env.CallStaticLongMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public static bool putLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m5.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m5 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "putLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m6.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m6 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)F");
				return @__env.CallStaticFloatMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m7.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m7 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;)F");
				return @__env.CallStaticFloatMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public static bool putFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m8.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m8 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "putFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public static global::java.lang.String getString(android.content.ContentResolver arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m9.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m9 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "getString", "(Landroid/content/ContentResolver;Ljava/lang/String;)Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public static void getConfiguration(android.content.ContentResolver arg0, android.content.res.Configuration arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m10.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m10 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "getConfiguration", "(Landroid/content/ContentResolver;Landroid/content/res/Configuration;)V");
				@__env.CallStaticVoidMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m11;
			public static bool putString(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m11.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m11 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "putString", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m12;
			public static global::android.net.Uri getUriFor(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m12.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m12 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "getUriFor", "(Ljava/lang/String;)Landroid/net/Uri;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
			}
			private static global::MonoJavaBridge.MethodId _m13;
			public static bool putConfiguration(android.content.ContentResolver arg0, android.content.res.Configuration arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m13.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m13 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "putConfiguration", "(Landroid/content/ContentResolver;Landroid/content/res/Configuration;)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m14;
			public static bool getShowGTalkServiceStatus(android.content.ContentResolver arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m14.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m14 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "getShowGTalkServiceStatus", "(Landroid/content/ContentResolver;)Z");
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m15;
			public static void setShowGTalkServiceStatus(android.content.ContentResolver arg0, bool arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m15.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m15 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "setShowGTalkServiceStatus", "(Landroid/content/ContentResolver;Z)V");
				@__env.CallStaticVoidMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m16;
			public System() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Settings.System._m16.native == global::System.IntPtr.Zero)
					global::android.provider.Settings.System._m16 = @__env.GetMethodIDNoThrow(global::android.provider.Settings.System.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._m16);
				Init(@__env, handle);
			}
			public static global::java.lang.String SYS_PROP_SETTING_VERSION
			{
				get
				{
					return "sys.settings_system_version";
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4850;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Settings.System.staticClass, _CONTENT_URI4850)) as android.net.Uri;
				}
			}
			public static global::java.lang.String STAY_ON_WHILE_PLUGGED_IN
			{
				get
				{
					return "stay_on_while_plugged_in";
				}
			}
			public static global::java.lang.String END_BUTTON_BEHAVIOR
			{
				get
				{
					return "end_button_behavior";
				}
			}
			public static global::java.lang.String AIRPLANE_MODE_ON
			{
				get
				{
					return "airplane_mode_on";
				}
			}
			public static global::java.lang.String RADIO_BLUETOOTH
			{
				get
				{
					return "bluetooth";
				}
			}
			public static global::java.lang.String RADIO_WIFI
			{
				get
				{
					return "wifi";
				}
			}
			public static global::java.lang.String RADIO_CELL
			{
				get
				{
					return "cell";
				}
			}
			public static global::java.lang.String AIRPLANE_MODE_RADIOS
			{
				get
				{
					return "airplane_mode_radios";
				}
			}
			public static global::java.lang.String WIFI_SLEEP_POLICY
			{
				get
				{
					return "wifi_sleep_policy";
				}
			}
			public static int WIFI_SLEEP_POLICY_DEFAULT
			{
				get
				{
					return 0;
				}
			}
			public static int WIFI_SLEEP_POLICY_NEVER_WHILE_PLUGGED
			{
				get
				{
					return 1;
				}
			}
			public static int WIFI_SLEEP_POLICY_NEVER
			{
				get
				{
					return 2;
				}
			}
			public static global::java.lang.String WIFI_USE_STATIC_IP
			{
				get
				{
					return "wifi_use_static_ip";
				}
			}
			public static global::java.lang.String WIFI_STATIC_IP
			{
				get
				{
					return "wifi_static_ip";
				}
			}
			public static global::java.lang.String WIFI_STATIC_GATEWAY
			{
				get
				{
					return "wifi_static_gateway";
				}
			}
			public static global::java.lang.String WIFI_STATIC_NETMASK
			{
				get
				{
					return "wifi_static_netmask";
				}
			}
			public static global::java.lang.String WIFI_STATIC_DNS1
			{
				get
				{
					return "wifi_static_dns1";
				}
			}
			public static global::java.lang.String WIFI_STATIC_DNS2
			{
				get
				{
					return "wifi_static_dns2";
				}
			}
			public static global::java.lang.String BLUETOOTH_DISCOVERABILITY
			{
				get
				{
					return "bluetooth_discoverability";
				}
			}
			public static global::java.lang.String BLUETOOTH_DISCOVERABILITY_TIMEOUT
			{
				get
				{
					return "bluetooth_discoverability_timeout";
				}
			}
			public static global::java.lang.String LOCK_PATTERN_ENABLED
			{
				get
				{
					return "lock_pattern_autolock";
				}
			}
			public static global::java.lang.String LOCK_PATTERN_VISIBLE
			{
				get
				{
					return "lock_pattern_visible_pattern";
				}
			}
			public static global::java.lang.String LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED
			{
				get
				{
					return "lock_pattern_tactile_feedback_enabled";
				}
			}
			public static global::java.lang.String NEXT_ALARM_FORMATTED
			{
				get
				{
					return "next_alarm_formatted";
				}
			}
			public static global::java.lang.String FONT_SCALE
			{
				get
				{
					return "font_scale";
				}
			}
			public static global::java.lang.String DEBUG_APP
			{
				get
				{
					return "debug_app";
				}
			}
			public static global::java.lang.String WAIT_FOR_DEBUGGER
			{
				get
				{
					return "wait_for_debugger";
				}
			}
			public static global::java.lang.String DIM_SCREEN
			{
				get
				{
					return "dim_screen";
				}
			}
			public static global::java.lang.String SCREEN_OFF_TIMEOUT
			{
				get
				{
					return "screen_off_timeout";
				}
			}
			public static global::java.lang.String SCREEN_BRIGHTNESS
			{
				get
				{
					return "screen_brightness";
				}
			}
			public static global::java.lang.String SCREEN_BRIGHTNESS_MODE
			{
				get
				{
					return "screen_brightness_mode";
				}
			}
			public static int SCREEN_BRIGHTNESS_MODE_MANUAL
			{
				get
				{
					return 0;
				}
			}
			public static int SCREEN_BRIGHTNESS_MODE_AUTOMATIC
			{
				get
				{
					return 1;
				}
			}
			public static global::java.lang.String SHOW_PROCESSES
			{
				get
				{
					return "show_processes";
				}
			}
			public static global::java.lang.String ALWAYS_FINISH_ACTIVITIES
			{
				get
				{
					return "always_finish_activities";
				}
			}
			public static global::java.lang.String MODE_RINGER
			{
				get
				{
					return "mode_ringer";
				}
			}
			public static global::java.lang.String MODE_RINGER_STREAMS_AFFECTED
			{
				get
				{
					return "mode_ringer_streams_affected";
				}
			}
			public static global::java.lang.String MUTE_STREAMS_AFFECTED
			{
				get
				{
					return "mute_streams_affected";
				}
			}
			public static global::java.lang.String VIBRATE_ON
			{
				get
				{
					return "vibrate_on";
				}
			}
			public static global::java.lang.String VOLUME_RING
			{
				get
				{
					return "volume_ring";
				}
			}
			public static global::java.lang.String VOLUME_SYSTEM
			{
				get
				{
					return "volume_system";
				}
			}
			public static global::java.lang.String VOLUME_VOICE
			{
				get
				{
					return "volume_voice";
				}
			}
			public static global::java.lang.String VOLUME_MUSIC
			{
				get
				{
					return "volume_music";
				}
			}
			public static global::java.lang.String VOLUME_ALARM
			{
				get
				{
					return "volume_alarm";
				}
			}
			public static global::java.lang.String VOLUME_NOTIFICATION
			{
				get
				{
					return "volume_notification";
				}
			}
			public static global::java.lang.String VOLUME_BLUETOOTH_SCO
			{
				get
				{
					return "volume_bluetooth_sco";
				}
			}
			internal static global::MonoJavaBridge.FieldId _VOLUME_SETTINGS4896;
			public static global::java.lang.String[] VOLUME_SETTINGS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.provider.Settings.System.staticClass, _VOLUME_SETTINGS4896)) as java.lang.String[];
				}
			}
			public static global::java.lang.String APPEND_FOR_LAST_AUDIBLE
			{
				get
				{
					return "_last_audible";
				}
			}
			public static global::java.lang.String RINGTONE
			{
				get
				{
					return "ringtone";
				}
			}
			internal static global::MonoJavaBridge.FieldId _DEFAULT_RINGTONE_URI4899;
			public static global::android.net.Uri DEFAULT_RINGTONE_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Settings.System.staticClass, _DEFAULT_RINGTONE_URI4899)) as android.net.Uri;
				}
			}
			public static global::java.lang.String NOTIFICATION_SOUND
			{
				get
				{
					return "notification_sound";
				}
			}
			internal static global::MonoJavaBridge.FieldId _DEFAULT_NOTIFICATION_URI4901;
			public static global::android.net.Uri DEFAULT_NOTIFICATION_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Settings.System.staticClass, _DEFAULT_NOTIFICATION_URI4901)) as android.net.Uri;
				}
			}
			public static global::java.lang.String ALARM_ALERT
			{
				get
				{
					return "alarm_alert";
				}
			}
			internal static global::MonoJavaBridge.FieldId _DEFAULT_ALARM_ALERT_URI4903;
			public static global::android.net.Uri DEFAULT_ALARM_ALERT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Settings.System.staticClass, _DEFAULT_ALARM_ALERT_URI4903)) as android.net.Uri;
				}
			}
			public static global::java.lang.String TEXT_AUTO_REPLACE
			{
				get
				{
					return "auto_replace";
				}
			}
			public static global::java.lang.String TEXT_AUTO_CAPS
			{
				get
				{
					return "auto_caps";
				}
			}
			public static global::java.lang.String TEXT_AUTO_PUNCTUATE
			{
				get
				{
					return "auto_punctuate";
				}
			}
			public static global::java.lang.String TEXT_SHOW_PASSWORD
			{
				get
				{
					return "show_password";
				}
			}
			public static global::java.lang.String SHOW_GTALK_SERVICE_STATUS
			{
				get
				{
					return "SHOW_GTALK_SERVICE_STATUS";
				}
			}
			public static global::java.lang.String WALLPAPER_ACTIVITY
			{
				get
				{
					return "wallpaper_activity";
				}
			}
			public static global::java.lang.String AUTO_TIME
			{
				get
				{
					return "auto_time";
				}
			}
			public static global::java.lang.String TIME_12_24
			{
				get
				{
					return "time_12_24";
				}
			}
			public static global::java.lang.String DATE_FORMAT
			{
				get
				{
					return "date_format";
				}
			}
			public static global::java.lang.String SETUP_WIZARD_HAS_RUN
			{
				get
				{
					return "setup_wizard_has_run";
				}
			}
			public static global::java.lang.String WINDOW_ANIMATION_SCALE
			{
				get
				{
					return "window_animation_scale";
				}
			}
			public static global::java.lang.String TRANSITION_ANIMATION_SCALE
			{
				get
				{
					return "transition_animation_scale";
				}
			}
			public static global::java.lang.String ACCELEROMETER_ROTATION
			{
				get
				{
					return "accelerometer_rotation";
				}
			}
			public static global::java.lang.String DTMF_TONE_WHEN_DIALING
			{
				get
				{
					return "dtmf_tone";
				}
			}
			public static global::java.lang.String SOUND_EFFECTS_ENABLED
			{
				get
				{
					return "sound_effects_enabled";
				}
			}
			public static global::java.lang.String HAPTIC_FEEDBACK_ENABLED
			{
				get
				{
					return "haptic_feedback_enabled";
				}
			}
			public static global::java.lang.String SHOW_WEB_SUGGESTIONS
			{
				get
				{
					return "show_web_suggestions";
				}
			}
			public static global::java.lang.String ADB_ENABLED
			{
				get
				{
					return "adb_enabled";
				}
			}
			public static global::java.lang.String ANDROID_ID
			{
				get
				{
					return "android_id";
				}
			}
			public static global::java.lang.String BLUETOOTH_ON
			{
				get
				{
					return "bluetooth_on";
				}
			}
			public static global::java.lang.String DATA_ROAMING
			{
				get
				{
					return "data_roaming";
				}
			}
			public static global::java.lang.String DEVICE_PROVISIONED
			{
				get
				{
					return "device_provisioned";
				}
			}
			public static global::java.lang.String HTTP_PROXY
			{
				get
				{
					return "http_proxy";
				}
			}
			public static global::java.lang.String INSTALL_NON_MARKET_APPS
			{
				get
				{
					return "install_non_market_apps";
				}
			}
			public static global::java.lang.String LOCATION_PROVIDERS_ALLOWED
			{
				get
				{
					return "location_providers_allowed";
				}
			}
			public static global::java.lang.String LOGGING_ID
			{
				get
				{
					return "logging_id";
				}
			}
			public static global::java.lang.String NETWORK_PREFERENCE
			{
				get
				{
					return "network_preference";
				}
			}
			public static global::java.lang.String PARENTAL_CONTROL_ENABLED
			{
				get
				{
					return "parental_control_enabled";
				}
			}
			public static global::java.lang.String PARENTAL_CONTROL_LAST_UPDATE
			{
				get
				{
					return "parental_control_last_update";
				}
			}
			public static global::java.lang.String PARENTAL_CONTROL_REDIRECT_URL
			{
				get
				{
					return "parental_control_redirect_url";
				}
			}
			public static global::java.lang.String SETTINGS_CLASSNAME
			{
				get
				{
					return "settings_classname";
				}
			}
			public static global::java.lang.String USB_MASS_STORAGE_ENABLED
			{
				get
				{
					return "usb_mass_storage_enabled";
				}
			}
			public static global::java.lang.String USE_GOOGLE_MAIL
			{
				get
				{
					return "use_google_mail";
				}
			}
			public static global::java.lang.String WIFI_MAX_DHCP_RETRY_COUNT
			{
				get
				{
					return "wifi_max_dhcp_retry_count";
				}
			}
			public static global::java.lang.String WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS
			{
				get
				{
					return "wifi_mobile_data_transition_wakelock_timeout_ms";
				}
			}
			public static global::java.lang.String WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON
			{
				get
				{
					return "wifi_networks_available_notification_on";
				}
			}
			public static global::java.lang.String WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY
			{
				get
				{
					return "wifi_networks_available_repeat_delay";
				}
			}
			public static global::java.lang.String WIFI_NUM_OPEN_NETWORKS_KEPT
			{
				get
				{
					return "wifi_num_open_networks_kept";
				}
			}
			public static global::java.lang.String WIFI_ON
			{
				get
				{
					return "wifi_on";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE
			{
				get
				{
					return "wifi_watchdog_acceptable_packet_loss_percentage";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_AP_COUNT
			{
				get
				{
					return "wifi_watchdog_ap_count";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS
			{
				get
				{
					return "wifi_watchdog_background_check_delay_ms";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED
			{
				get
				{
					return "wifi_watchdog_background_check_enabled";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS
			{
				get
				{
					return "wifi_watchdog_background_check_timeout_ms";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT
			{
				get
				{
					return "wifi_watchdog_initial_ignored_ping_count";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_MAX_AP_CHECKS
			{
				get
				{
					return "wifi_watchdog_max_ap_checks";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_ON
			{
				get
				{
					return "wifi_watchdog_on";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_PING_COUNT
			{
				get
				{
					return "wifi_watchdog_ping_count";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_PING_DELAY_MS
			{
				get
				{
					return "wifi_watchdog_ping_delay_ms";
				}
			}
			public static global::java.lang.String WIFI_WATCHDOG_PING_TIMEOUT_MS
			{
				get
				{
					return "wifi_watchdog_ping_timeout_ms";
				}
			}
			static System()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Settings.System.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Settings$System"));
				global::android.provider.Settings.System._CONTENT_URI4850 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Settings.System.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
				global::android.provider.Settings.System._VOLUME_SETTINGS4896 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Settings.System.staticClass, "VOLUME_SETTINGS", "[Ljava/lang/String;");
				global::android.provider.Settings.System._DEFAULT_RINGTONE_URI4899 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Settings.System.staticClass, "DEFAULT_RINGTONE_URI", "Landroid/net/Uri;");
				global::android.provider.Settings.System._DEFAULT_NOTIFICATION_URI4901 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Settings.System.staticClass, "DEFAULT_NOTIFICATION_URI", "Landroid/net/Uri;");
				global::android.provider.Settings.System._DEFAULT_ALARM_ALERT_URI4903 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Settings.System.staticClass, "DEFAULT_ALARM_ALERT_URI", "Landroid/net/Uri;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public Settings() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Settings._m0.native == global::System.IntPtr.Zero)
				global::android.provider.Settings._m0 = @__env.GetMethodIDNoThrow(global::android.provider.Settings.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Settings.staticClass, global::android.provider.Settings._m0);
			Init(@__env, handle);
		}
		public static global::java.lang.String ACTION_SETTINGS
		{
			get
			{
				return "android.settings.SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_APN_SETTINGS
		{
			get
			{
				return "android.settings.APN_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_LOCATION_SOURCE_SETTINGS
		{
			get
			{
				return "android.settings.LOCATION_SOURCE_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_WIRELESS_SETTINGS
		{
			get
			{
				return "android.settings.WIRELESS_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_AIRPLANE_MODE_SETTINGS
		{
			get
			{
				return "android.settings.AIRPLANE_MODE_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_ACCESSIBILITY_SETTINGS
		{
			get
			{
				return "android.settings.ACCESSIBILITY_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_SECURITY_SETTINGS
		{
			get
			{
				return "android.settings.SECURITY_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_PRIVACY_SETTINGS
		{
			get
			{
				return "android.settings.PRIVACY_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_WIFI_SETTINGS
		{
			get
			{
				return "android.settings.WIFI_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_WIFI_IP_SETTINGS
		{
			get
			{
				return "android.settings.WIFI_IP_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_BLUETOOTH_SETTINGS
		{
			get
			{
				return "android.settings.BLUETOOTH_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_DATE_SETTINGS
		{
			get
			{
				return "android.settings.DATE_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_SOUND_SETTINGS
		{
			get
			{
				return "android.settings.SOUND_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_DISPLAY_SETTINGS
		{
			get
			{
				return "android.settings.DISPLAY_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_LOCALE_SETTINGS
		{
			get
			{
				return "android.settings.LOCALE_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_INPUT_METHOD_SETTINGS
		{
			get
			{
				return "android.settings.INPUT_METHOD_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_USER_DICTIONARY_SETTINGS
		{
			get
			{
				return "android.settings.USER_DICTIONARY_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_APPLICATION_SETTINGS
		{
			get
			{
				return "android.settings.APPLICATION_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_APPLICATION_DEVELOPMENT_SETTINGS
		{
			get
			{
				return "android.settings.APPLICATION_DEVELOPMENT_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_QUICK_LAUNCH_SETTINGS
		{
			get
			{
				return "android.settings.QUICK_LAUNCH_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_MANAGE_APPLICATIONS_SETTINGS
		{
			get
			{
				return "android.settings.MANAGE_APPLICATIONS_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_SYNC_SETTINGS
		{
			get
			{
				return "android.settings.SYNC_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_ADD_ACCOUNT
		{
			get
			{
				return "android.settings.ADD_ACCOUNT_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_NETWORK_OPERATOR_SETTINGS
		{
			get
			{
				return "android.settings.NETWORK_OPERATOR_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_DATA_ROAMING_SETTINGS
		{
			get
			{
				return "android.settings.DATA_ROAMING_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_INTERNAL_STORAGE_SETTINGS
		{
			get
			{
				return "android.settings.INTERNAL_STORAGE_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_MEMORY_CARD_SETTINGS
		{
			get
			{
				return "android.settings.MEMORY_CARD_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_SEARCH_SETTINGS
		{
			get
			{
				return "android.search.action.SEARCH_SETTINGS";
			}
		}
		public static global::java.lang.String ACTION_DEVICE_INFO_SETTINGS
		{
			get
			{
				return "android.settings.DEVICE_INFO_SETTINGS";
			}
		}
		public static global::java.lang.String EXTRA_AUTHORITIES
		{
			get
			{
				return "authorities";
			}
		}
		public static global::java.lang.String AUTHORITY
		{
			get
			{
				return "settings";
			}
		}
		static Settings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.Settings.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Settings"));
		}
	}
}
