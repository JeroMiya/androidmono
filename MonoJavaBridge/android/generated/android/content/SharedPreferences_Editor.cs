namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.SharedPreferences_Editor_))]
	public partial interface SharedPreferences_Editor  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.content.SharedPreferences_Editor putBoolean(java.lang.String arg0, bool arg1);
		global::android.content.SharedPreferences_Editor putInt(java.lang.String arg0, int arg1);
		global::android.content.SharedPreferences_Editor putLong(java.lang.String arg0, long arg1);
		global::android.content.SharedPreferences_Editor putFloat(java.lang.String arg0, float arg1);
		global::android.content.SharedPreferences_Editor clear();
		global::android.content.SharedPreferences_Editor remove(java.lang.String arg0);
		global::android.content.SharedPreferences_Editor putString(java.lang.String arg0, java.lang.String arg1);
		bool commit();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.SharedPreferences_Editor))]
	internal sealed partial class SharedPreferences_Editor_ : java.lang.Object, SharedPreferences_Editor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SharedPreferences_Editor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putBoolean(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences_Editor>(this, global::android.content.SharedPreferences_Editor_.staticClass, "putBoolean", "(Ljava/lang/String;Z)Landroid/content/SharedPreferences$Editor;", ref global::android.content.SharedPreferences_Editor_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.SharedPreferences_Editor;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences_Editor>(this, global::android.content.SharedPreferences_Editor_.staticClass, "putInt", "(Ljava/lang/String;I)Landroid/content/SharedPreferences$Editor;", ref global::android.content.SharedPreferences_Editor_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.SharedPreferences_Editor;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putLong(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences_Editor>(this, global::android.content.SharedPreferences_Editor_.staticClass, "putLong", "(Ljava/lang/String;J)Landroid/content/SharedPreferences$Editor;", ref global::android.content.SharedPreferences_Editor_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.SharedPreferences_Editor;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putFloat(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences_Editor>(this, global::android.content.SharedPreferences_Editor_.staticClass, "putFloat", "(Ljava/lang/String;F)Landroid/content/SharedPreferences$Editor;", ref global::android.content.SharedPreferences_Editor_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.SharedPreferences_Editor;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.clear()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences_Editor>(this, global::android.content.SharedPreferences_Editor_.staticClass, "clear", "()Landroid/content/SharedPreferences$Editor;", ref global::android.content.SharedPreferences_Editor_._m4) as android.content.SharedPreferences_Editor;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.remove(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences_Editor>(this, global::android.content.SharedPreferences_Editor_.staticClass, "remove", "(Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;", ref global::android.content.SharedPreferences_Editor_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.SharedPreferences_Editor;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putString(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences_Editor>(this, global::android.content.SharedPreferences_Editor_.staticClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;", ref global::android.content.SharedPreferences_Editor_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.SharedPreferences_Editor;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool android.content.SharedPreferences_Editor.commit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SharedPreferences_Editor_.staticClass, "commit", "()Z", ref global::android.content.SharedPreferences_Editor_._m7);
		}
		static SharedPreferences_Editor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SharedPreferences_Editor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SharedPreferences$Editor"));
		}
	}
}
