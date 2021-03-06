namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PKIXCertPathBuilderResult : java.security.cert.PKIXCertPathValidatorResult, CertPathBuilderResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PKIXCertPathBuilderResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.PKIXCertPathBuilderResult.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.PKIXCertPathBuilderResult._m0) as java.lang.String;
		}
		public new global::java.security.cert.CertPath CertPath
		{
			get
			{
				return getCertPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.security.cert.CertPath getCertPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PKIXCertPathBuilderResult.staticClass, "getCertPath", "()Ljava/security/cert/CertPath;", ref global::java.security.cert.PKIXCertPathBuilderResult._m1) as java.security.cert.CertPath;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public PKIXCertPathBuilderResult(java.security.cert.CertPath arg0, java.security.cert.TrustAnchor arg1, java.security.cert.PolicyNode arg2, java.security.PublicKey arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXCertPathBuilderResult._m2.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXCertPathBuilderResult._m2 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathBuilderResult.staticClass, "<init>", "(Ljava/security/cert/CertPath;Ljava/security/cert/TrustAnchor;Ljava/security/cert/PolicyNode;Ljava/security/PublicKey;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXCertPathBuilderResult.staticClass, global::java.security.cert.PKIXCertPathBuilderResult._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static PKIXCertPathBuilderResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXCertPathBuilderResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXCertPathBuilderResult"));
		}
	}
}
