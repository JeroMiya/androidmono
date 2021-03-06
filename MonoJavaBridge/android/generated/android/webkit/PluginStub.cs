namespace android.webkit
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.PluginStub_))]
	public partial interface PluginStub  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.view.View getEmbeddedView(int arg0, android.content.Context arg1);
		global::android.view.View getFullScreenView(int arg0, android.content.Context arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.PluginStub))]
	internal sealed partial class PluginStub_ : java.lang.Object, PluginStub
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PluginStub_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::android.view.View android.webkit.PluginStub.getEmbeddedView(int arg0, android.content.Context arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.PluginStub_.staticClass, "getEmbeddedView", "(ILandroid/content/Context;)Landroid/view/View;", ref global::android.webkit.PluginStub_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::android.view.View android.webkit.PluginStub.getFullScreenView(int arg0, android.content.Context arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.PluginStub_.staticClass, "getFullScreenView", "(ILandroid/content/Context;)Landroid/view/View;", ref global::android.webkit.PluginStub_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		static PluginStub_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.PluginStub_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/PluginStub"));
		}
	}
}
