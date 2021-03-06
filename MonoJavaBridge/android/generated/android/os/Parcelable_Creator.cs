namespace android.os
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.Parcelable_Creator_))]
	public partial interface Parcelable_Creator  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object[] newArray(int arg0);
		global::java.lang.Object createFromParcel(android.os.Parcel arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.Parcelable_Creator))]
	internal sealed partial class Parcelable_Creator_ : java.lang.Object, Parcelable_Creator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Parcelable_Creator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object[] android.os.Parcelable_Creator.newArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::android.os.Parcelable_Creator_.staticClass, "newArray", "(I)[Ljava/lang/Object;", ref global::android.os.Parcelable_Creator_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object android.os.Parcelable_Creator.createFromParcel(android.os.Parcel arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Parcelable_Creator_.staticClass, "createFromParcel", "(Landroid/os/Parcel;)Ljava/lang/Object;", ref global::android.os.Parcelable_Creator_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static Parcelable_Creator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Parcelable_Creator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Parcelable$Creator"));
		}
	}
}
