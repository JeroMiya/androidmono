namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CornerPathEffect : android.graphics.PathEffect
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CornerPathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public CornerPathEffect(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.CornerPathEffect._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.CornerPathEffect._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.CornerPathEffect.staticClass, "<init>", "(F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.CornerPathEffect.staticClass, global::android.graphics.CornerPathEffect._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CornerPathEffect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.CornerPathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/CornerPathEffect"));
		}
	}
}
