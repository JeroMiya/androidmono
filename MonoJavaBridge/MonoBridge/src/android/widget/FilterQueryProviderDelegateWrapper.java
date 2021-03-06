package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class FilterQueryProviderDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.FilterQueryProvider
{
	static
	{
		MonoBridge.link(FilterQueryProviderDelegateWrapper.class, "runQuery", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", "java.lang.CharSequence");

	}

	public native android.database.Cursor runQuery(java.lang.CharSequence arg0);



}
