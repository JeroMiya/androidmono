namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextKeyListener : android.text.method.BaseKeyListener, SpanWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TextKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Capitalize : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Capitalize(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.text.method.TextKeyListener.Capitalize[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.method.TextKeyListener.Capitalize._m0.native == global::System.IntPtr.Zero)
					global::android.text.method.TextKeyListener.Capitalize._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.Capitalize.staticClass, "values", "()[Landroid/text/method/TextKeyListener/Capitalize;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.method.TextKeyListener.Capitalize>(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.Capitalize.staticClass, global::android.text.method.TextKeyListener.Capitalize._m0)) as android.text.method.TextKeyListener.Capitalize[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.text.method.TextKeyListener.Capitalize valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.method.TextKeyListener.Capitalize._m1.native == global::System.IntPtr.Zero)
					global::android.text.method.TextKeyListener.Capitalize._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.Capitalize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/method/TextKeyListener$Capitalize;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.method.TextKeyListener.Capitalize>(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.Capitalize.staticClass, global::android.text.method.TextKeyListener.Capitalize._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.method.TextKeyListener.Capitalize;
			}
			internal static global::MonoJavaBridge.FieldId _CHARACTERS5354;
			public static global::android.text.method.TextKeyListener.Capitalize CHARACTERS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.method.TextKeyListener.Capitalize>(@__env.GetStaticObjectField(global::android.text.method.TextKeyListener.Capitalize.staticClass, _CHARACTERS5354)) as android.text.method.TextKeyListener.Capitalize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NONE5355;
			public static global::android.text.method.TextKeyListener.Capitalize NONE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.method.TextKeyListener.Capitalize>(@__env.GetStaticObjectField(global::android.text.method.TextKeyListener.Capitalize.staticClass, _NONE5355)) as android.text.method.TextKeyListener.Capitalize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SENTENCES5356;
			public static global::android.text.method.TextKeyListener.Capitalize SENTENCES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.method.TextKeyListener.Capitalize>(@__env.GetStaticObjectField(global::android.text.method.TextKeyListener.Capitalize.staticClass, _SENTENCES5356)) as android.text.method.TextKeyListener.Capitalize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WORDS5357;
			public static global::android.text.method.TextKeyListener.Capitalize WORDS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.method.TextKeyListener.Capitalize>(@__env.GetStaticObjectField(global::android.text.method.TextKeyListener.Capitalize.staticClass, _WORDS5357)) as android.text.method.TextKeyListener.Capitalize;
				}
			}
			static Capitalize()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.method.TextKeyListener.Capitalize.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/TextKeyListener$Capitalize"));
				global::android.text.method.TextKeyListener.Capitalize._CHARACTERS5354 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.TextKeyListener.Capitalize.staticClass, "CHARACTERS", "Landroid/text/method/TextKeyListener$Capitalize;");
				global::android.text.method.TextKeyListener.Capitalize._NONE5355 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.TextKeyListener.Capitalize.staticClass, "NONE", "Landroid/text/method/TextKeyListener$Capitalize;");
				global::android.text.method.TextKeyListener.Capitalize._SENTENCES5356 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.TextKeyListener.Capitalize.staticClass, "SENTENCES", "Landroid/text/method/TextKeyListener$Capitalize;");
				global::android.text.method.TextKeyListener.Capitalize._WORDS5357 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.TextKeyListener.Capitalize.staticClass, "WORDS", "Landroid/text/method/TextKeyListener$Capitalize;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void clear(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.TextKeyListener._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.TextKeyListener._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "clear", "(Landroid/text/Editable;)V");
			@__env.CallStaticVoidMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.text.method.TextKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.TextKeyListener._m1.native == global::System.IntPtr.Zero)
				global::android.text.method.TextKeyListener._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/TextKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.method.TextKeyListener;
		}
		public static global::android.text.method.TextKeyListener Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.text.method.TextKeyListener getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.TextKeyListener._m2.native == global::System.IntPtr.Zero)
				global::android.text.method.TextKeyListener._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "getInstance", "()Landroid/text/method/TextKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._m2)) as android.text.method.TextKeyListener;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.TextKeyListener.staticClass, "release", "()V", ref global::android.text.method.TextKeyListener._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.TextKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.TextKeyListener._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.TextKeyListener.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.TextKeyListener._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.TextKeyListener.staticClass, "getInputType", "()I", ref global::android.text.method.TextKeyListener._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.TextKeyListener.staticClass, "onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z", ref global::android.text.method.TextKeyListener._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.TextKeyListener.staticClass, "onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", ref global::android.text.method.TextKeyListener._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.TextKeyListener.staticClass, "onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", ref global::android.text.method.TextKeyListener._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.TextKeyListener.staticClass, "onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V", ref global::android.text.method.TextKeyListener._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static bool shouldCap(android.text.method.TextKeyListener.Capitalize arg0, java.lang.CharSequence arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.TextKeyListener._m11.native == global::System.IntPtr.Zero)
				global::android.text.method.TextKeyListener._m11 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "shouldCap", "(Landroid/text/method/TextKeyListener$Capitalize;Ljava/lang/CharSequence;I)Z");
			return @__env.CallStaticBooleanMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static bool shouldCap(android.text.method.TextKeyListener.Capitalize arg0, string arg1, int arg2)
		{
			return shouldCap(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public TextKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.TextKeyListener._m12.native == global::System.IntPtr.Zero)
				global::android.text.method.TextKeyListener._m12 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TextKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.TextKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/TextKeyListener"));
		}
	}
}
