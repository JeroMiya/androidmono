namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Inet4Address : java.net.InetAddress
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Inet4Address(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.net.Inet4Address._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Inet4Address.staticClass, "hashCode", "()I", ref global::java.net.Inet4Address._m1);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override byte[] getAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.net.Inet4Address.staticClass, "getAddress", "()[B", ref global::java.net.Inet4Address._m2) as byte[];
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override global::java.lang.String getHostAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Inet4Address.staticClass, "getHostAddress", "()Ljava/lang/String;", ref global::java.net.Inet4Address._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override bool isAnyLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isAnyLocalAddress", "()Z", ref global::java.net.Inet4Address._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public sealed override bool isMulticastAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMulticastAddress", "()Z", ref global::java.net.Inet4Address._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public sealed override bool isLoopbackAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isLoopbackAddress", "()Z", ref global::java.net.Inet4Address._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public sealed override bool isLinkLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isLinkLocalAddress", "()Z", ref global::java.net.Inet4Address._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public sealed override bool isSiteLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isSiteLocalAddress", "()Z", ref global::java.net.Inet4Address._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public sealed override bool isMCGlobal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMCGlobal", "()Z", ref global::java.net.Inet4Address._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public sealed override bool isMCNodeLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMCNodeLocal", "()Z", ref global::java.net.Inet4Address._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public sealed override bool isMCLinkLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMCLinkLocal", "()Z", ref global::java.net.Inet4Address._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public sealed override bool isMCSiteLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMCSiteLocal", "()Z", ref global::java.net.Inet4Address._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public sealed override bool isMCOrgLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMCOrgLocal", "()Z", ref global::java.net.Inet4Address._m13);
		}
		static Inet4Address()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Inet4Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Inet4Address"));
		}
	}
}
