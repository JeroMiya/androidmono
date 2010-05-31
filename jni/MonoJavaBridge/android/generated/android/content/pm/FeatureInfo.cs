namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class FeatureInfo : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static FeatureInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.FeatureInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.FeatureInfo(@__env);
			}
		}
		protected FeatureInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1636;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.FeatureInfo._toString1636));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._toString1636));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1637;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.FeatureInfo._writeToParcel1637, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._writeToParcel1637, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1638;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.FeatureInfo._describeContents1638);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._describeContents1638);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlEsVersion1639;
		public virtual global::java.lang.String getGlEsVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.FeatureInfo._getGlEsVersion1639));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._getGlEsVersion1639));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FeatureInfo1640;
		public FeatureInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._FeatureInfo1640, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _FeatureInfo1641;
		public FeatureInfo(android.content.pm.FeatureInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._FeatureInfo1641, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _name1642;
		public global::java.lang.String name
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		public static int GL_ES_VERSION_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _reqGlEsVersion1643;
		public int reqGlEsVersion
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int FLAG_REQUIRED
		{
			get
			{
				return 1;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _flags1644;
		public int flags
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1645;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.FeatureInfo.staticClass = @__class;
			global::android.content.pm.FeatureInfo._toString1636 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.FeatureInfo._writeToParcel1637 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.FeatureInfo._describeContents1638 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.FeatureInfo._getGlEsVersion1639 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;");
			global::android.content.pm.FeatureInfo._FeatureInfo1640 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "<init>", "()V");
			global::android.content.pm.FeatureInfo._FeatureInfo1641 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "<init>", "(Landroid/content/pm/FeatureInfo;)V");
		}
	}
}
