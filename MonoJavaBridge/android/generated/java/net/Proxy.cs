namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Proxy : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Proxy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Type : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Type(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.net.Proxy.Type[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.net.Proxy.Type._m0.native == global::System.IntPtr.Zero)
					global::java.net.Proxy.Type._m0 = @__env.GetStaticMethodIDNoThrow(global::java.net.Proxy.Type.staticClass, "values", "()[Ljava/net/Proxy/Type;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.Proxy.Type>(@__env.CallStaticObjectMethod(java.net.Proxy.Type.staticClass, global::java.net.Proxy.Type._m0)) as java.net.Proxy.Type[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::java.net.Proxy.Type valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.net.Proxy.Type._m1.native == global::System.IntPtr.Zero)
					global::java.net.Proxy.Type._m1 = @__env.GetStaticMethodIDNoThrow(global::java.net.Proxy.Type.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/net/Proxy$Type;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.CallStaticObjectMethod(java.net.Proxy.Type.staticClass, global::java.net.Proxy.Type._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.Proxy.Type;
			}
			internal static global::MonoJavaBridge.FieldId _DIRECT6489;
			public static global::java.net.Proxy.Type DIRECT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.GetStaticObjectField(global::java.net.Proxy.Type.staticClass, _DIRECT6489)) as java.net.Proxy.Type;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HTTP6490;
			public static global::java.net.Proxy.Type HTTP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.GetStaticObjectField(global::java.net.Proxy.Type.staticClass, _HTTP6490)) as java.net.Proxy.Type;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SOCKS6491;
			public static global::java.net.Proxy.Type SOCKS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.GetStaticObjectField(global::java.net.Proxy.Type.staticClass, _SOCKS6491)) as java.net.Proxy.Type;
				}
			}
			static Type()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.net.Proxy.Type.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Proxy$Type"));
				global::java.net.Proxy.Type._DIRECT6489 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.Type.staticClass, "DIRECT", "Ljava/net/Proxy$Type;");
				global::java.net.Proxy.Type._HTTP6490 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.Type.staticClass, "HTTP", "Ljava/net/Proxy$Type;");
				global::java.net.Proxy.Type._SOCKS6491 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.Type.staticClass, "SOCKS", "Ljava/net/Proxy$Type;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.net.Proxy.Type type()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.Proxy.Type>(this, global::java.net.Proxy.staticClass, "type", "()Ljava/net/Proxy$Type;", ref global::java.net.Proxy._m0) as java.net.Proxy.Type;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Proxy.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.net.Proxy._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Proxy.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.Proxy._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Proxy.staticClass, "hashCode", "()I", ref global::java.net.Proxy._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.net.SocketAddress address()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.Proxy.staticClass, "address", "()Ljava/net/SocketAddress;", ref global::java.net.Proxy._m4) as java.net.SocketAddress;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public Proxy(java.net.Proxy.Type arg0, java.net.SocketAddress arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Proxy._m5.native == global::System.IntPtr.Zero)
				global::java.net.Proxy._m5 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "<init>", "(Ljava/net/Proxy$Type;Ljava/net/SocketAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Proxy.staticClass, global::java.net.Proxy._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _NO_PROXY6492;
		public static global::java.net.Proxy NO_PROXY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.net.Proxy.staticClass, _NO_PROXY6492)) as java.net.Proxy;
			}
		}
		static Proxy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Proxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Proxy"));
			global::java.net.Proxy._NO_PROXY6492 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.staticClass, "NO_PROXY", "Ljava/net/Proxy;");
		}
	}
}
