namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ForegroundColorSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ForegroundColorSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.ForegroundColorSpan._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, "describeContents", "()I", ref global::android.text.style.ForegroundColorSpan._m1);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.ForegroundColorSpan._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.ForegroundColorSpan._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ForegroundColor
		{
			get
			{
				return getForegroundColor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getForegroundColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, "getForegroundColor", "()I", ref global::android.text.style.ForegroundColorSpan._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ForegroundColorSpan(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ForegroundColorSpan._m5.native == global::System.IntPtr.Zero)
				global::android.text.style.ForegroundColorSpan._m5 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ForegroundColorSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ForegroundColorSpan._m6.native == global::System.IntPtr.Zero)
				global::android.text.style.ForegroundColorSpan._m6 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ForegroundColorSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ForegroundColorSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ForegroundColorSpan"));
		}
	}
}
