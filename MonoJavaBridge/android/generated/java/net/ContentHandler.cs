namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.ContentHandler_))]
	public abstract partial class ContentHandler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.Object getContent(java.net.URLConnection arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object getContent(java.net.URLConnection arg0, java.lang.Class[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ContentHandler.staticClass, "getContent", "(Ljava/net/URLConnection;[Ljava/lang/Class;)Ljava/lang/Object;", ref global::java.net.ContentHandler._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ContentHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ContentHandler._m2.native == global::System.IntPtr.Zero)
				global::java.net.ContentHandler._m2 = @__env.GetMethodIDNoThrow(global::java.net.ContentHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ContentHandler.staticClass, global::java.net.ContentHandler._m2);
			Init(@__env, handle);
		}
		static ContentHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ContentHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ContentHandler"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.ContentHandler))]
	internal sealed partial class ContentHandler_ : java.net.ContentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object getContent(java.net.URLConnection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ContentHandler_.staticClass, "getContent", "(Ljava/net/URLConnection;)Ljava/lang/Object;", ref global::java.net.ContentHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static ContentHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ContentHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ContentHandler"));
		}
	}
}
