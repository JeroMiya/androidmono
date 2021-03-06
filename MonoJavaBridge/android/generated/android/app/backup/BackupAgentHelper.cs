namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackupAgentHelper : android.app.backup.BackupAgent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BackupAgentHelper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupAgentHelper.staticClass, "onBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V", ref global::android.app.backup.BackupAgentHelper._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void onRestore(android.app.backup.BackupDataInput arg0, int arg1, android.os.ParcelFileDescriptor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupAgentHelper.staticClass, "onRestore", "(Landroid/app/backup/BackupDataInput;ILandroid/os/ParcelFileDescriptor;)V", ref global::android.app.backup.BackupAgentHelper._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void addHelper(java.lang.String arg0, android.app.backup.BackupHelper arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupAgentHelper.staticClass, "addHelper", "(Ljava/lang/String;Landroid/app/backup/BackupHelper;)V", ref global::android.app.backup.BackupAgentHelper._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public BackupAgentHelper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.backup.BackupAgentHelper._m3.native == global::System.IntPtr.Zero)
				global::android.app.backup.BackupAgentHelper._m3 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgentHelper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.backup.BackupAgentHelper.staticClass, global::android.app.backup.BackupAgentHelper._m3);
			Init(@__env, handle);
		}
		static BackupAgentHelper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupAgentHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupAgentHelper"));
		}
	}
}
