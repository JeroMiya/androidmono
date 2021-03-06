namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Runnable_))]
	public partial interface Runnable  : global::MonoJavaBridge.IJavaObject 
	{
		void run();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Runnable))]
	internal sealed partial class Runnable_ : java.lang.Object, Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Runnable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.lang.Runnable.run()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runnable_.staticClass, "run", "()V", ref global::java.lang.Runnable_._m0);
		}
		static Runnable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Runnable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Runnable"));
		}
	}

	public delegate void RunnableDelegate();

	internal partial class RunnableDelegateWrapper : java.lang.Object, Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RunnableDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public RunnableDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.RunnableDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::java.lang.RunnableDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::java.lang.RunnableDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RunnableDelegateWrapper.staticClass, global::java.lang.RunnableDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static RunnableDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.RunnableDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("internal/java/lang/RunnableDelegateWrapper"));
		}
	}
	internal partial class RunnableDelegateWrapper
	{
		private RunnableDelegate myDelegate;
		public void run()
		{
			myDelegate();
		}
		public static implicit operator RunnableDelegateWrapper(RunnableDelegate d)
		{
			global::java.lang.RunnableDelegateWrapper ret = new global::java.lang.RunnableDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
