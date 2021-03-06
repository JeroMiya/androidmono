namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedCharsetException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnsupportedCharsetException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String CharsetName
		{
			get
			{
				return getCharsetName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getCharsetName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.UnsupportedCharsetException.staticClass, "getCharsetName", "()Ljava/lang/String;", ref global::java.nio.charset.UnsupportedCharsetException._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public UnsupportedCharsetException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.UnsupportedCharsetException._m1.native == global::System.IntPtr.Zero)
				global::java.nio.charset.UnsupportedCharsetException._m1 = @__env.GetMethodIDNoThrow(global::java.nio.charset.UnsupportedCharsetException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.UnsupportedCharsetException.staticClass, global::java.nio.charset.UnsupportedCharsetException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnsupportedCharsetException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.UnsupportedCharsetException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/UnsupportedCharsetException"));
		}
	}
}
