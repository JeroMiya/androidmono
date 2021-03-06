namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CertPathBuilderSpi_))]
	public abstract partial class CertPathBuilderSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertPathBuilderSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.security.cert.CertPathBuilderResult engineBuild(java.security.cert.CertPathParameters arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public CertPathBuilderSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathBuilderSpi._m1.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathBuilderSpi._m1 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilderSpi.staticClass, global::java.security.cert.CertPathBuilderSpi._m1);
			Init(@__env, handle);
		}
		static CertPathBuilderSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathBuilderSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathBuilderSpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPathBuilderSpi))]
	internal sealed partial class CertPathBuilderSpi_ : java.security.cert.CertPathBuilderSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertPathBuilderSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.security.cert.CertPathBuilderResult engineBuild(java.security.cert.CertPathParameters arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.cert.CertPathBuilderResult>(this, global::java.security.cert.CertPathBuilderSpi_.staticClass, "engineBuild", "(Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathBuilderResult;", ref global::java.security.cert.CertPathBuilderSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.CertPathBuilderResult;
		}
		static CertPathBuilderSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathBuilderSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathBuilderSpi"));
		}
	}
}
