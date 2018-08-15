package md55d8f4c170033acd94059368a74c86995;


public class TweetListWrapper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TesterApp.TweetListWrapper, TesterApp", TweetListWrapper.class, __md_methods);
	}


	public TweetListWrapper ()
	{
		super ();
		if (getClass () == TweetListWrapper.class)
			mono.android.TypeManager.Activate ("TesterApp.TweetListWrapper, TesterApp", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
