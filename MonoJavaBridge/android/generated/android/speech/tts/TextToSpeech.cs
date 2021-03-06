namespace android.speech.tts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextToSpeech : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TextToSpeech(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Engine : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Engine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public Engine(android.speech.tts.TextToSpeech arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.speech.tts.TextToSpeech.Engine._m0.native == global::System.IntPtr.Zero)
					global::android.speech.tts.TextToSpeech.Engine._m0 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.Engine.staticClass, "<init>", "(Landroid/speech/tts/TextToSpeech;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.speech.tts.TextToSpeech.Engine.staticClass, global::android.speech.tts.TextToSpeech.Engine._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			public static int DEFAULT_STREAM
			{
				get
				{
					return 3;
				}
			}
			public static int CHECK_VOICE_DATA_PASS
			{
				get
				{
					return 1;
				}
			}
			public static int CHECK_VOICE_DATA_FAIL
			{
				get
				{
					return 0;
				}
			}
			public static int CHECK_VOICE_DATA_BAD_DATA
			{
				get
				{
					return -1;
				}
			}
			public static int CHECK_VOICE_DATA_MISSING_DATA
			{
				get
				{
					return -2;
				}
			}
			public static int CHECK_VOICE_DATA_MISSING_VOLUME
			{
				get
				{
					return -3;
				}
			}
			public static global::java.lang.String ACTION_INSTALL_TTS_DATA
			{
				get
				{
					return "android.speech.tts.engine.INSTALL_TTS_DATA";
				}
			}
			public static global::java.lang.String ACTION_TTS_DATA_INSTALLED
			{
				get
				{
					return "android.speech.tts.engine.TTS_DATA_INSTALLED";
				}
			}
			public static global::java.lang.String ACTION_CHECK_TTS_DATA
			{
				get
				{
					return "android.speech.tts.engine.CHECK_TTS_DATA";
				}
			}
			public static global::java.lang.String EXTRA_VOICE_DATA_ROOT_DIRECTORY
			{
				get
				{
					return "dataRoot";
				}
			}
			public static global::java.lang.String EXTRA_VOICE_DATA_FILES
			{
				get
				{
					return "dataFiles";
				}
			}
			public static global::java.lang.String EXTRA_VOICE_DATA_FILES_INFO
			{
				get
				{
					return "dataFilesInfo";
				}
			}
			public static global::java.lang.String EXTRA_AVAILABLE_VOICES
			{
				get
				{
					return "availableVoices";
				}
			}
			public static global::java.lang.String EXTRA_UNAVAILABLE_VOICES
			{
				get
				{
					return "unavailableVoices";
				}
			}
			public static global::java.lang.String EXTRA_CHECK_VOICE_DATA_FOR
			{
				get
				{
					return "checkVoiceDataFor";
				}
			}
			public static global::java.lang.String EXTRA_TTS_DATA_INSTALLED
			{
				get
				{
					return "dataInstalled";
				}
			}
			public static global::java.lang.String KEY_PARAM_STREAM
			{
				get
				{
					return "streamType";
				}
			}
			public static global::java.lang.String KEY_PARAM_UTTERANCE_ID
			{
				get
				{
					return "utteranceId";
				}
			}
			static Engine()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.speech.tts.TextToSpeech.Engine.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/tts/TextToSpeech$Engine"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.speech.tts.TextToSpeech.OnInitListener_))]
		public partial interface OnInitListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onInit(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.speech.tts.TextToSpeech.OnInitListener))]
		internal sealed partial class OnInitListener_ : java.lang.Object, OnInitListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnInitListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.speech.tts.TextToSpeech.OnInitListener.onInit(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.tts.TextToSpeech.OnInitListener_.staticClass, "onInit", "(I)V", ref global::android.speech.tts.TextToSpeech.OnInitListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnInitListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.speech.tts.TextToSpeech.OnInitListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/tts/TextToSpeech$OnInitListener"));
			}
		}

		public delegate void OnInitListenerDelegate(int arg0);

		internal partial class OnInitListenerDelegateWrapper : java.lang.Object, OnInitListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnInitListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnInitListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.speech.tts.TextToSpeech.OnInitListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.speech.tts.TextToSpeech.OnInitListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.OnInitListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.speech.tts.TextToSpeech.OnInitListenerDelegateWrapper.staticClass, global::android.speech.tts.TextToSpeech.OnInitListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnInitListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.speech.tts.TextToSpeech.OnInitListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/tts/TextToSpeech_OnInitListenerDelegateWrapper"));
			}
		}
		internal partial class OnInitListenerDelegateWrapper
		{
			private OnInitListenerDelegate myDelegate;
			public void onInit(int arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnInitListenerDelegateWrapper(OnInitListenerDelegate d)
			{
				global::android.speech.tts.TextToSpeech.OnInitListenerDelegateWrapper ret = new global::android.speech.tts.TextToSpeech.OnInitListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener_))]
		public partial interface OnUtteranceCompletedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onUtteranceCompleted(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener))]
		internal sealed partial class OnUtteranceCompletedListener_ : java.lang.Object, OnUtteranceCompletedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnUtteranceCompletedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.speech.tts.TextToSpeech.OnUtteranceCompletedListener.onUtteranceCompleted(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener_.staticClass, "onUtteranceCompleted", "(Ljava/lang/String;)V", ref global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnUtteranceCompletedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/tts/TextToSpeech$OnUtteranceCompletedListener"));
			}
		}

		public delegate void OnUtteranceCompletedListenerDelegate(java.lang.String arg0);

		internal partial class OnUtteranceCompletedListenerDelegateWrapper : java.lang.Object, OnUtteranceCompletedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnUtteranceCompletedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnUtteranceCompletedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.speech.tts.TextToSpeech.OnUtteranceCompletedListenerDelegateWrapper.staticClass, global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnUtteranceCompletedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/tts/TextToSpeech_OnUtteranceCompletedListenerDelegateWrapper"));
			}
		}
		internal partial class OnUtteranceCompletedListenerDelegateWrapper
		{
			private OnUtteranceCompletedListenerDelegate myDelegate;
			public void onUtteranceCompleted(java.lang.String arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnUtteranceCompletedListenerDelegateWrapper(OnUtteranceCompletedListenerDelegate d)
			{
				global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListenerDelegateWrapper ret = new global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "shutdown", "()V", ref global::android.speech.tts.TextToSpeech._m0);
		}
		public new global::java.util.Locale Language
		{
			get
			{
				return getLanguage();
			}
			set
			{
				setLanguage(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.Locale getLanguage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::android.speech.tts.TextToSpeech.staticClass, "getLanguage", "()Ljava/util/Locale;", ref global::android.speech.tts.TextToSpeech._m1) as java.util.Locale;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int stop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "stop", "()I", ref global::android.speech.tts.TextToSpeech._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int addSpeech(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "addSpeech", "(Ljava/lang/String;Ljava/lang/String;I)I", ref global::android.speech.tts.TextToSpeech._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int addSpeech(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "addSpeech", "(Ljava/lang/String;Ljava/lang/String;)I", ref global::android.speech.tts.TextToSpeech._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int addEarcon(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "addEarcon", "(Ljava/lang/String;Ljava/lang/String;I)I", ref global::android.speech.tts.TextToSpeech._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int addEarcon(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "addEarcon", "(Ljava/lang/String;Ljava/lang/String;)I", ref global::android.speech.tts.TextToSpeech._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int speak(java.lang.String arg0, int arg1, java.util.HashMap arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "speak", "(Ljava/lang/String;ILjava/util/HashMap;)I", ref global::android.speech.tts.TextToSpeech._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int playEarcon(java.lang.String arg0, int arg1, java.util.HashMap arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "playEarcon", "(Ljava/lang/String;ILjava/util/HashMap;)I", ref global::android.speech.tts.TextToSpeech._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int playSilence(long arg0, int arg1, java.util.HashMap arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "playSilence", "(JILjava/util/HashMap;)I", ref global::android.speech.tts.TextToSpeech._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isSpeaking()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "isSpeaking", "()Z", ref global::android.speech.tts.TextToSpeech._m10);
		}
		public new float SpeechRate
		{
			set
			{
				setSpeechRate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int setSpeechRate(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "setSpeechRate", "(F)I", ref global::android.speech.tts.TextToSpeech._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Pitch
		{
			set
			{
				setPitch(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int setPitch(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "setPitch", "(F)I", ref global::android.speech.tts.TextToSpeech._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int setLanguage(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "setLanguage", "(Ljava/util/Locale;)I", ref global::android.speech.tts.TextToSpeech._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int isLanguageAvailable(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "isLanguageAvailable", "(Ljava/util/Locale;)I", ref global::android.speech.tts.TextToSpeech._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int synthesizeToFile(java.lang.String arg0, java.util.HashMap arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "synthesizeToFile", "(Ljava/lang/String;Ljava/util/HashMap;Ljava/lang/String;)I", ref global::android.speech.tts.TextToSpeech._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int setOnUtteranceCompletedListener(android.speech.tts.TextToSpeech.OnUtteranceCompletedListener arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "setOnUtteranceCompletedListener", "(Landroid/speech/tts/TextToSpeech$OnUtteranceCompletedListener;)I", ref global::android.speech.tts.TextToSpeech._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public int setOnUtteranceCompletedListener(global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListenerDelegate arg0)
		{
			return setOnUtteranceCompletedListener((global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListenerDelegateWrapper)arg0);
		}
		public new global::java.lang.String EngineByPackageName
		{
			set
			{
				setEngineByPackageName(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int setEngineByPackageName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "setEngineByPackageName", "(Ljava/lang/String;)I", ref global::android.speech.tts.TextToSpeech._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String DefaultEngine
		{
			get
			{
				return getDefaultEngine();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.String getDefaultEngine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.speech.tts.TextToSpeech.staticClass, "getDefaultEngine", "()Ljava/lang/String;", ref global::android.speech.tts.TextToSpeech._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool areDefaultsEnforced()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.speech.tts.TextToSpeech.staticClass, "areDefaultsEnforced", "()Z", ref global::android.speech.tts.TextToSpeech._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public TextToSpeech(android.content.Context arg0, android.speech.tts.TextToSpeech.OnInitListener arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.speech.tts.TextToSpeech._m20.native == global::System.IntPtr.Zero)
				global::android.speech.tts.TextToSpeech._m20 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "<init>", "(Landroid/content/Context;Landroid/speech/tts/TextToSpeech$OnInitListener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int SUCCESS
		{
			get
			{
				return 0;
			}
		}
		public static int ERROR
		{
			get
			{
				return -1;
			}
		}
		public static int QUEUE_FLUSH
		{
			get
			{
				return 0;
			}
		}
		public static int QUEUE_ADD
		{
			get
			{
				return 1;
			}
		}
		public static int LANG_COUNTRY_VAR_AVAILABLE
		{
			get
			{
				return 2;
			}
		}
		public static int LANG_COUNTRY_AVAILABLE
		{
			get
			{
				return 1;
			}
		}
		public static int LANG_AVAILABLE
		{
			get
			{
				return 0;
			}
		}
		public static int LANG_MISSING_DATA
		{
			get
			{
				return -1;
			}
		}
		public static int LANG_NOT_SUPPORTED
		{
			get
			{
				return -2;
			}
		}
		public static global::java.lang.String ACTION_TTS_QUEUE_PROCESSING_COMPLETED
		{
			get
			{
				return "android.speech.tts.TTS_QUEUE_PROCESSING_COMPLETED";
			}
		}
		static TextToSpeech()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.tts.TextToSpeech.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/tts/TextToSpeech"));
		}
	}
}
