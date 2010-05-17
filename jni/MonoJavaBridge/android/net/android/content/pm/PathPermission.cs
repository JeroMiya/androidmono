namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PathPermission : android.os.PatternMatcher
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PathPermission() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.PathPermission), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.pm.PathPermission(@__env); 
			} 
		} 
		protected PathPermission(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1738; 
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PathPermission)) 
				@__env.CallVoidMethod(this, _writeToParcel1738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.PathPermission.staticClass, _writeToParcel1738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReadPermission1739; 
		public virtual java.lang.String getReadPermission() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PathPermission)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getReadPermission1739)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.PathPermission.staticClass, _getReadPermission1739)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWritePermission1740; 
		public virtual java.lang.String getWritePermission() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PathPermission)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getWritePermission1740)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.PathPermission.staticClass, _getWritePermission1740)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PathPermission1741; 
		public PathPermission(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.PathPermission.staticClass, _PathPermission1741, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PathPermission1742; 
		public PathPermission(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.PathPermission.staticClass, _PathPermission1742, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1743; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.PathPermission.staticClass = @__class; 
			global::android.content.pm.PathPermission._writeToParcel1738 = @__env.GetMethodID(global::android.content.pm.PathPermission.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.PathPermission._getReadPermission1739 = @__env.GetMethodID(global::android.content.pm.PathPermission.staticClass, "getReadPermission", "()Ljava/lang/String;"); 
			global::android.content.pm.PathPermission._getWritePermission1740 = @__env.GetMethodID(global::android.content.pm.PathPermission.staticClass, "getWritePermission", "()Ljava/lang/String;"); 
			global::android.content.pm.PathPermission._PathPermission1741 = @__env.GetMethodID(global::android.content.pm.PathPermission.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.pm.PathPermission._PathPermission1742 = @__env.GetMethodID(global::android.content.pm.PathPermission.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 