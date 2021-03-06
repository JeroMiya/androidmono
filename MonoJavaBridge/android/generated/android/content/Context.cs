namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.Context_))]
	public abstract partial class Context : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Context(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.ClassLoader getClassLoader();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract int checkPermission(java.lang.String arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::android.content.res.Resources getResources();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.lang.String getPackageName();
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Context.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.content.Context._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getString(int arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Context.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", ref global::android.content.Context._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::android.content.res.AssetManager getAssets();
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::android.content.pm.PackageManager getPackageManager();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::android.content.ContentResolver getContentResolver();
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::android.os.Looper getMainLooper();
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract global::android.content.Context getApplicationContext();
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract void setTheme(int arg0);
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract global::android.content.res.Resources.Theme getTheme();
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract global::android.content.pm.ApplicationInfo getApplicationInfo();
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract global::java.lang.String getPackageResourcePath();
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract global::java.lang.String getPackageCodePath();
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract global::java.io.FileInputStream openFileInput(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract bool deleteFile(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract global::java.io.File getFileStreamPath(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract global::java.lang.String[] fileList();
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract global::java.io.File getFilesDir();
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract global::java.io.File getExternalFilesDir(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract global::java.io.File getCacheDir();
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract global::java.io.File getExternalCacheDir();
		private static global::MonoJavaBridge.MethodId _m26;
		public abstract global::java.io.File getDir(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m27;
		public abstract global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2);
		private static global::MonoJavaBridge.MethodId _m28;
		public abstract bool deleteDatabase(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m29;
		public abstract global::java.io.File getDatabasePath(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m30;
		public abstract global::java.lang.String[] databaseList();
		private static global::MonoJavaBridge.MethodId _m31;
		public abstract global::android.graphics.drawable.Drawable getWallpaper();
		private static global::MonoJavaBridge.MethodId _m32;
		public abstract global::android.graphics.drawable.Drawable peekWallpaper();
		private static global::MonoJavaBridge.MethodId _m33;
		public abstract int getWallpaperDesiredMinimumWidth();
		private static global::MonoJavaBridge.MethodId _m34;
		public abstract int getWallpaperDesiredMinimumHeight();
		private static global::MonoJavaBridge.MethodId _m35;
		public abstract void setWallpaper(android.graphics.Bitmap arg0);
		private static global::MonoJavaBridge.MethodId _m36;
		public abstract void setWallpaper(java.io.InputStream arg0);
		private static global::MonoJavaBridge.MethodId _m37;
		public abstract void clearWallpaper();
		private static global::MonoJavaBridge.MethodId _m38;
		public abstract void startActivity(android.content.Intent arg0);
		private static global::MonoJavaBridge.MethodId _m39;
		public abstract void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4);
		private static global::MonoJavaBridge.MethodId _m40;
		public abstract void sendBroadcast(android.content.Intent arg0);
		private static global::MonoJavaBridge.MethodId _m41;
		public abstract void sendBroadcast(android.content.Intent arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m42;
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m43;
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6);
		private static global::MonoJavaBridge.MethodId _m44;
		public abstract void sendStickyBroadcast(android.content.Intent arg0);
		private static global::MonoJavaBridge.MethodId _m45;
		public abstract void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5);
		private static global::MonoJavaBridge.MethodId _m46;
		public abstract void removeStickyBroadcast(android.content.Intent arg0);
		private static global::MonoJavaBridge.MethodId _m47;
		public abstract global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1);
		private static global::MonoJavaBridge.MethodId _m48;
		public abstract global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3);
		private static global::MonoJavaBridge.MethodId _m49;
		public abstract void unregisterReceiver(android.content.BroadcastReceiver arg0);
		private static global::MonoJavaBridge.MethodId _m50;
		public abstract global::android.content.ComponentName startService(android.content.Intent arg0);
		private static global::MonoJavaBridge.MethodId _m51;
		public abstract bool stopService(android.content.Intent arg0);
		private static global::MonoJavaBridge.MethodId _m52;
		public abstract bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m53;
		public abstract void unbindService(android.content.ServiceConnection arg0);
		private static global::MonoJavaBridge.MethodId _m54;
		public abstract bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2);
		private static global::MonoJavaBridge.MethodId _m55;
		public abstract global::java.lang.Object getSystemService(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m56;
		public abstract int checkCallingPermission(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m57;
		public abstract int checkCallingOrSelfPermission(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m58;
		public abstract void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3);
		private static global::MonoJavaBridge.MethodId _m59;
		public abstract void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m60;
		public abstract void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m61;
		public abstract void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m62;
		public abstract void revokeUriPermission(android.net.Uri arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m63;
		public abstract int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5);
		private static global::MonoJavaBridge.MethodId _m64;
		public abstract int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3);
		private static global::MonoJavaBridge.MethodId _m65;
		public abstract int checkCallingUriPermission(android.net.Uri arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m66;
		public abstract int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m67;
		public abstract void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4);
		private static global::MonoJavaBridge.MethodId _m68;
		public abstract void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6);
		private static global::MonoJavaBridge.MethodId _m69;
		public abstract void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2);
		private static global::MonoJavaBridge.MethodId _m70;
		public abstract void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2);
		private static global::MonoJavaBridge.MethodId _m71;
		public abstract global::android.content.Context createPackageContext(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual bool isRestricted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context.staticClass, "isRestricted", "()Z", ref global::android.content.Context._m72);
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual global::java.lang.CharSequence getText(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.Context.staticClass, "getText", "(I)Ljava/lang/CharSequence;", ref global::android.content.Context._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;", ref global::android.content.Context._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.content.res.TypedArray;
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;", ref global::android.content.Context._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.TypedArray;
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(int arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context.staticClass, "obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;", ref global::android.content.Context._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.TypedArray;
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context.staticClass, "obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;", ref global::android.content.Context._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.TypedArray;
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public Context() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Context._m78.native == global::System.IntPtr.Zero)
				global::android.content.Context._m78 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Context.staticClass, global::android.content.Context._m78);
			Init(@__env, handle);
		}
		public static int MODE_PRIVATE
		{
			get
			{
				return 0;
			}
		}
		public static int MODE_WORLD_READABLE
		{
			get
			{
				return 1;
			}
		}
		public static int MODE_WORLD_WRITEABLE
		{
			get
			{
				return 2;
			}
		}
		public static int MODE_APPEND
		{
			get
			{
				return 32768;
			}
		}
		public static int BIND_AUTO_CREATE
		{
			get
			{
				return 1;
			}
		}
		public static int BIND_DEBUG_UNBIND
		{
			get
			{
				return 2;
			}
		}
		public static int BIND_NOT_FOREGROUND
		{
			get
			{
				return 4;
			}
		}
		public static global::java.lang.String POWER_SERVICE
		{
			get
			{
				return "power";
			}
		}
		public static global::java.lang.String WINDOW_SERVICE
		{
			get
			{
				return "window";
			}
		}
		public static global::java.lang.String LAYOUT_INFLATER_SERVICE
		{
			get
			{
				return "layout_inflater";
			}
		}
		public static global::java.lang.String ACCOUNT_SERVICE
		{
			get
			{
				return "account";
			}
		}
		public static global::java.lang.String ACTIVITY_SERVICE
		{
			get
			{
				return "activity";
			}
		}
		public static global::java.lang.String ALARM_SERVICE
		{
			get
			{
				return "alarm";
			}
		}
		public static global::java.lang.String NOTIFICATION_SERVICE
		{
			get
			{
				return "notification";
			}
		}
		public static global::java.lang.String ACCESSIBILITY_SERVICE
		{
			get
			{
				return "accessibility";
			}
		}
		public static global::java.lang.String KEYGUARD_SERVICE
		{
			get
			{
				return "keyguard";
			}
		}
		public static global::java.lang.String LOCATION_SERVICE
		{
			get
			{
				return "location";
			}
		}
		public static global::java.lang.String SEARCH_SERVICE
		{
			get
			{
				return "search";
			}
		}
		public static global::java.lang.String SENSOR_SERVICE
		{
			get
			{
				return "sensor";
			}
		}
		public static global::java.lang.String WALLPAPER_SERVICE
		{
			get
			{
				return "wallpaper";
			}
		}
		public static global::java.lang.String VIBRATOR_SERVICE
		{
			get
			{
				return "vibrator";
			}
		}
		public static global::java.lang.String CONNECTIVITY_SERVICE
		{
			get
			{
				return "connectivity";
			}
		}
		public static global::java.lang.String WIFI_SERVICE
		{
			get
			{
				return "wifi";
			}
		}
		public static global::java.lang.String AUDIO_SERVICE
		{
			get
			{
				return "audio";
			}
		}
		public static global::java.lang.String TELEPHONY_SERVICE
		{
			get
			{
				return "phone";
			}
		}
		public static global::java.lang.String CLIPBOARD_SERVICE
		{
			get
			{
				return "clipboard";
			}
		}
		public static global::java.lang.String INPUT_METHOD_SERVICE
		{
			get
			{
				return "input_method";
			}
		}
		public static global::java.lang.String DROPBOX_SERVICE
		{
			get
			{
				return "dropbox";
			}
		}
		public static global::java.lang.String DEVICE_POLICY_SERVICE
		{
			get
			{
				return "device_policy";
			}
		}
		public static global::java.lang.String UI_MODE_SERVICE
		{
			get
			{
				return "uimode";
			}
		}
		public static int CONTEXT_INCLUDE_CODE
		{
			get
			{
				return 1;
			}
		}
		public static int CONTEXT_IGNORE_SECURITY
		{
			get
			{
				return 2;
			}
		}
		public static int CONTEXT_RESTRICTED
		{
			get
			{
				return 4;
			}
		}
		static Context()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Context.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Context"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.Context))]
	internal sealed partial class Context_ : android.content.Context
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Context_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.ClassLoader getClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;", ref global::android.content.Context_._m0) as java.lang.ClassLoader;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int checkPermission(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkPermission", "(Ljava/lang/String;II)I", ref global::android.content.Context_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::android.content.res.Resources getResources()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getResources", "()Landroid/content/res/Resources;", ref global::android.content.Context_._m2) as android.content.res.Resources;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String getPackageName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Context_.staticClass, "getPackageName", "()Ljava/lang/String;", ref global::android.content.Context_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::android.content.res.AssetManager getAssets()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.AssetManager>(this, global::android.content.Context_.staticClass, "getAssets", "()Landroid/content/res/AssetManager;", ref global::android.content.Context_._m4) as android.content.res.AssetManager;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::android.content.pm.PackageManager getPackageManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;", ref global::android.content.Context_._m5) as android.content.pm.PackageManager;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::android.content.ContentResolver getContentResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;", ref global::android.content.Context_._m6) as android.content.ContentResolver;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::android.os.Looper getMainLooper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getMainLooper", "()Landroid/os/Looper;", ref global::android.content.Context_._m7) as android.os.Looper;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::android.content.Context getApplicationContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getApplicationContext", "()Landroid/content/Context;", ref global::android.content.Context_._m8) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void setTheme(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "setTheme", "(I)V", ref global::android.content.Context_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::android.content.res.Resources.Theme getTheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.Resources.Theme>(this, global::android.content.Context_.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;", ref global::android.content.Context_._m10) as android.content.res.Resources.Theme;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", ref global::android.content.Context_._m11) as android.content.pm.ApplicationInfo;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.lang.String getPackageResourcePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Context_.staticClass, "getPackageResourcePath", "()Ljava/lang/String;", ref global::android.content.Context_._m12) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::java.lang.String getPackageCodePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Context_.staticClass, "getPackageCodePath", "()Ljava/lang/String;", ref global::android.content.Context_._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences>(this, global::android.content.Context_.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", ref global::android.content.Context_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.SharedPreferences;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", ref global::android.content.Context_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.FileInputStream;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", ref global::android.content.Context_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.FileOutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override bool deleteFile(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context_.staticClass, "deleteFile", "(Ljava/lang/String;)Z", ref global::android.content.Context_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", ref global::android.content.Context_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override global::java.lang.String[] fileList()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.Context_.staticClass, "fileList", "()[Ljava/lang/String;", ref global::android.content.Context_._m19) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override global::java.io.File getFilesDir()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getFilesDir", "()Ljava/io/File;", ref global::android.content.Context_._m20) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override global::java.io.File getExternalFilesDir(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", ref global::android.content.Context_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override global::java.io.File getCacheDir()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getCacheDir", "()Ljava/io/File;", ref global::android.content.Context_._m22) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override global::java.io.File getExternalCacheDir()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getExternalCacheDir", "()Ljava/io/File;", ref global::android.content.Context_._m23) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override global::java.io.File getDir(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;", ref global::android.content.Context_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;", ref global::android.content.Context_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.database.sqlite.SQLiteDatabase;
		}
		public android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg2)
		{
			return openOrCreateDatabase(arg0, arg1, (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg2);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public override bool deleteDatabase(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context_.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z", ref global::android.content.Context_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public override global::java.io.File getDatabasePath(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", ref global::android.content.Context_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public override global::java.lang.String[] databaseList()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.Context_.staticClass, "databaseList", "()[Ljava/lang/String;", ref global::android.content.Context_._m28) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override global::android.graphics.drawable.Drawable getWallpaper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;", ref global::android.content.Context_._m29) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override global::android.graphics.drawable.Drawable peekWallpaper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;", ref global::android.content.Context_._m30) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override int getWallpaperDesiredMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "getWallpaperDesiredMinimumWidth", "()I", ref global::android.content.Context_._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public override int getWallpaperDesiredMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "getWallpaperDesiredMinimumHeight", "()I", ref global::android.content.Context_._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public override void setWallpaper(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V", ref global::android.content.Context_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public override void setWallpaper(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V", ref global::android.content.Context_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public override void clearWallpaper()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "clearWallpaper", "()V", ref global::android.content.Context_._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public override void startActivity(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "startActivity", "(Landroid/content/Intent;)V", ref global::android.content.Context_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", ref global::android.content.Context_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public override void sendBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V", ref global::android.content.Context_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public override void sendBroadcast(android.content.Intent arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", ref global::android.content.Context_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", ref global::android.content.Context_._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.content.Context_._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public override void sendStickyBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V", ref global::android.content.Context_._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public override void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.content.Context_._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public override void removeStickyBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V", ref global::android.content.Context_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;", ref global::android.content.Context_._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;", ref global::android.content.Context_._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public override void unregisterReceiver(android.content.BroadcastReceiver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", ref global::android.content.Context_._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public override global::android.content.ComponentName startService(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.content.Context_.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", ref global::android.content.Context_._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public override bool stopService(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context_.staticClass, "stopService", "(Landroid/content/Intent;)Z", ref global::android.content.Context_._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context_.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", ref global::android.content.Context_._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public override void unbindService(android.content.ServiceConnection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V", ref global::android.content.Context_._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public override bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context_.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", ref global::android.content.Context_._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public override global::java.lang.Object getSystemService(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::android.content.Context_._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public override int checkCallingPermission(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I", ref global::android.content.Context_._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public override int checkCallingOrSelfPermission(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I", ref global::android.content.Context_._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public override void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", ref global::android.content.Context_._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public override void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.Context_._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public override void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.Context_._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public override void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", ref global::android.content.Context_._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public override void revokeUriPermission(android.net.Uri arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V", ref global::android.content.Context_._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", ref global::android.content.Context_._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I", ref global::android.content.Context_._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public override int checkCallingUriPermission(android.net.Uri arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I", ref global::android.content.Context_._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public override int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", ref global::android.content.Context_._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public override void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", ref global::android.content.Context_._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public override void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", ref global::android.content.Context_._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public override void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", ref global::android.content.Context_._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public override void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", ref global::android.content.Context_._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public override global::android.content.Context createPackageContext(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", ref global::android.content.Context_._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Context;
		}
		static Context_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Context_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Context"));
		}
	}
}
