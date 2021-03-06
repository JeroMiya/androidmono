namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RuntimeException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RuntimeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public RuntimeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.RuntimeException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.RuntimeException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public RuntimeException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.RuntimeException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.RuntimeException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public RuntimeException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.RuntimeException._m2.native == global::System.IntPtr.Zero)
				global::java.lang.RuntimeException._m2 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public RuntimeException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.RuntimeException._m3.native == global::System.IntPtr.Zero)
				global::java.lang.RuntimeException._m3 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RuntimeException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.RuntimeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/RuntimeException"));
		}
	}
}
