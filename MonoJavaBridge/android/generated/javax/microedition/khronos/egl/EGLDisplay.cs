namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.microedition.khronos.egl.EGLDisplay_))]
	public abstract partial class EGLDisplay : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EGLDisplay(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public EGLDisplay() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.egl.EGLDisplay._m0.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.egl.EGLDisplay._m0 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLDisplay.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.microedition.khronos.egl.EGLDisplay.staticClass, global::javax.microedition.khronos.egl.EGLDisplay._m0);
			Init(@__env, handle);
		}
		static EGLDisplay()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLDisplay.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLDisplay"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGLDisplay))]
	internal sealed partial class EGLDisplay_ : javax.microedition.khronos.egl.EGLDisplay
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EGLDisplay_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static EGLDisplay_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLDisplay_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLDisplay"));
		}
	}
}
