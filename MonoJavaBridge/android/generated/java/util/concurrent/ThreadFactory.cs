namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ThreadFactory_))]
	public partial interface ThreadFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Thread newThread(java.lang.Runnable arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.ThreadFactory))]
	internal sealed partial class ThreadFactory_ : java.lang.Object, ThreadFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ThreadFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Thread java.util.concurrent.ThreadFactory.newThread(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ThreadFactory_.staticClass, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", ref global::java.util.concurrent.ThreadFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Thread;
		}
		static ThreadFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ThreadFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadFactory"));
		}
	}
}
