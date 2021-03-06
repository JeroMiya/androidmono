namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.ComponentCallbacks_))]
	public partial interface ComponentCallbacks  : global::MonoJavaBridge.IJavaObject 
	{
		void onConfigurationChanged(android.content.res.Configuration arg0);
		void onLowMemory();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.ComponentCallbacks))]
	internal sealed partial class ComponentCallbacks_ : java.lang.Object, ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ComponentCallbacks_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.content.ComponentCallbacks.onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ComponentCallbacks_.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.content.ComponentCallbacks_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.content.ComponentCallbacks.onLowMemory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ComponentCallbacks_.staticClass, "onLowMemory", "()V", ref global::android.content.ComponentCallbacks_._m1);
		}
		static ComponentCallbacks_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ComponentCallbacks_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ComponentCallbacks"));
		}
	}
}
