namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EmptyStackException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EmptyStackException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public EmptyStackException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EmptyStackException._m0.native == global::System.IntPtr.Zero)
				global::java.util.EmptyStackException._m0 = @__env.GetMethodIDNoThrow(global::java.util.EmptyStackException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EmptyStackException.staticClass, global::java.util.EmptyStackException._m0);
			Init(@__env, handle);
		}
		static EmptyStackException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EmptyStackException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EmptyStackException"));
		}
	}
}
