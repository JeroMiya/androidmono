namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnnotationTypeMismatchException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AnnotationTypeMismatchException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.reflect.Method element()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Method>(this, global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, "element", "()Ljava/lang/reflect/Method;", ref global::java.lang.annotation.AnnotationTypeMismatchException._m0) as java.lang.reflect.Method;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String foundType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, "foundType", "()Ljava/lang/String;", ref global::java.lang.annotation.AnnotationTypeMismatchException._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public AnnotationTypeMismatchException(java.lang.reflect.Method arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.AnnotationTypeMismatchException._m2.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.AnnotationTypeMismatchException._m2 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.annotation.AnnotationTypeMismatchException.staticClass, global::java.lang.annotation.AnnotationTypeMismatchException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AnnotationTypeMismatchException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.AnnotationTypeMismatchException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/AnnotationTypeMismatchException"));
		}
	}
}
