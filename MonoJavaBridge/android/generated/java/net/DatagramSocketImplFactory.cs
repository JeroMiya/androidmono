namespace java.net
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.net.DatagramSocketImplFactory_))]
	public partial interface DatagramSocketImplFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.net.DatagramSocketImpl createDatagramSocketImpl();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.DatagramSocketImplFactory))]
	internal sealed partial class DatagramSocketImplFactory_ : java.lang.Object, DatagramSocketImplFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DatagramSocketImplFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.net.DatagramSocketImpl java.net.DatagramSocketImplFactory.createDatagramSocketImpl()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocketImplFactory_.staticClass, "createDatagramSocketImpl", "()Ljava/net/DatagramSocketImpl;", ref global::java.net.DatagramSocketImplFactory_._m0) as java.net.DatagramSocketImpl;
		}
		static DatagramSocketImplFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImplFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImplFactory"));
		}
	}
}
