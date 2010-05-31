namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PictureDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::java.lang.Class staticClass;
		static PictureDrawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.PictureDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.PictureDrawable(@__env);
			}
		}
		protected PictureDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3727;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable._draw3727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._draw3727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDither3728;
		public override void setDither(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable._setDither3728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setDither3728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap3729;
		public override void setFilterBitmap(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable._setFilterBitmap3729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setFilterBitmap3729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3730;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable._setAlpha3730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setAlpha3730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3731;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable._setColorFilter3731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setColorFilter3731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3732;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.PictureDrawable._getOpacity3732);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getOpacity3732);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3733;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.PictureDrawable._getIntrinsicWidth3733);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getIntrinsicWidth3733);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3734;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.PictureDrawable._getIntrinsicHeight3734);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getIntrinsicHeight3734);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPicture3735;
		public virtual global::android.graphics.Picture getPicture() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.PictureDrawable._getPicture3735));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getPicture3735));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPicture3736;
		public virtual void setPicture(android.graphics.Picture arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable._setPicture3736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setPicture3736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PictureDrawable3737;
		public PictureDrawable(android.graphics.Picture arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._PictureDrawable3737, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.PictureDrawable.staticClass = @__class;
			global::android.graphics.drawable.PictureDrawable._draw3727 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.PictureDrawable._setDither3728 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.PictureDrawable._setFilterBitmap3729 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.drawable.PictureDrawable._setAlpha3730 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.PictureDrawable._setColorFilter3731 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.PictureDrawable._getOpacity3732 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.PictureDrawable._getIntrinsicWidth3733 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.PictureDrawable._getIntrinsicHeight3734 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.PictureDrawable._getPicture3735 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "getPicture", "()Landroid/graphics/Picture;");
			global::android.graphics.drawable.PictureDrawable._setPicture3736 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "setPicture", "(Landroid/graphics/Picture;)V");
			global::android.graphics.drawable.PictureDrawable._PictureDrawable3737 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "<init>", "(Landroid/graphics/Picture;)V");
		}
	}
}