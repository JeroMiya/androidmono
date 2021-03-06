namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CountDownLatch : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CountDownLatch(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.CountDownLatch.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.CountDownLatch._m0) as java.lang.String;
		}
		public new long Count
		{
			get
			{
				return getCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual long getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.CountDownLatch.staticClass, "getCount", "()J", ref global::java.util.concurrent.CountDownLatch._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void await()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.CountDownLatch.staticClass, "await", "()V", ref global::java.util.concurrent.CountDownLatch._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool await(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CountDownLatch.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.CountDownLatch._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void countDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.CountDownLatch.staticClass, "countDown", "()V", ref global::java.util.concurrent.CountDownLatch._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public CountDownLatch(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CountDownLatch._m5.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CountDownLatch._m5 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CountDownLatch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CountDownLatch.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CountDownLatch"));
		}
	}
}
