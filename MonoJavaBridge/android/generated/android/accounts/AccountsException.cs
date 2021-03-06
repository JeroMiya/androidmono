namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccountsException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccountsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public AccountsException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AccountsException._m0.native == global::System.IntPtr.Zero)
				global::android.accounts.AccountsException._m0 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountsException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountsException.staticClass, global::android.accounts.AccountsException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AccountsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AccountsException._m1.native == global::System.IntPtr.Zero)
				global::android.accounts.AccountsException._m1 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountsException.staticClass, global::android.accounts.AccountsException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public AccountsException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AccountsException._m2.native == global::System.IntPtr.Zero)
				global::android.accounts.AccountsException._m2 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountsException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountsException.staticClass, global::android.accounts.AccountsException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public AccountsException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AccountsException._m3.native == global::System.IntPtr.Zero)
				global::android.accounts.AccountsException._m3 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountsException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountsException.staticClass, global::android.accounts.AccountsException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AccountsException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountsException"));
		}
	}
}
