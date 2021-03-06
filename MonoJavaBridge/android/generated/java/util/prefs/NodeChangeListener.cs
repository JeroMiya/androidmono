namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.prefs.NodeChangeListener_))]
	public partial interface NodeChangeListener : EventListener
	{
		void childAdded(java.util.prefs.NodeChangeEvent arg0);
		void childRemoved(java.util.prefs.NodeChangeEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.NodeChangeListener))]
	internal sealed partial class NodeChangeListener_ : java.lang.Object, NodeChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NodeChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.util.prefs.NodeChangeListener.childAdded(java.util.prefs.NodeChangeEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.NodeChangeListener_.staticClass, "childAdded", "(Ljava/util/prefs/NodeChangeEvent;)V", ref global::java.util.prefs.NodeChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.util.prefs.NodeChangeListener.childRemoved(java.util.prefs.NodeChangeEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.NodeChangeListener_.staticClass, "childRemoved", "(Ljava/util/prefs/NodeChangeEvent;)V", ref global::java.util.prefs.NodeChangeListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static NodeChangeListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.NodeChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/NodeChangeListener"));
		}
	}
}
