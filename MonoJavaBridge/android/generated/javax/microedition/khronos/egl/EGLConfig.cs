namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.microedition.khronos.egl.EGLConfig_))]
	public abstract partial class EGLConfig : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EGLConfig(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public EGLConfig() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.egl.EGLConfig._m0.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.egl.EGLConfig._m0 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLConfig.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.microedition.khronos.egl.EGLConfig.staticClass, global::javax.microedition.khronos.egl.EGLConfig._m0);
			Init(@__env, handle);
		}
		static EGLConfig()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLConfig.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLConfig"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGLConfig))]
	internal sealed partial class EGLConfig_ : javax.microedition.khronos.egl.EGLConfig
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EGLConfig_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static EGLConfig_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLConfig_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLConfig"));
		}
	}
}
