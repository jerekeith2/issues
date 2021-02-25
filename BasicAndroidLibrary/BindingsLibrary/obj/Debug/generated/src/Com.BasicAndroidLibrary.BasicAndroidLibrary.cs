using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.BasicAndroidLibrary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.BasicAndroidLibrary']/class[@name='BasicAndroidLibrary']"
	[global::Android.Runtime.Register ("com/BasicAndroidLibrary/BasicAndroidLibrary", DoNotGenerateAcw=true)]
	public partial class BasicAndroidLibrary : global::Android.App.Activity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/BasicAndroidLibrary/BasicAndroidLibrary", typeof (BasicAndroidLibrary));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected BasicAndroidLibrary (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.BasicAndroidLibrary']/class[@name='BasicAndroidLibrary']/constructor[@name='BasicAndroidLibrary' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BasicAndroidLibrary ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.BasicAndroidLibrary.BasicAndroidLibrary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var savedInstanceState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (savedInstanceState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.BasicAndroidLibrary']/class[@name='BasicAndroidLibrary']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle savedInstanceState)
		{
			const string __id = "onCreate.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((savedInstanceState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) savedInstanceState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (savedInstanceState);
			}
		}

	}
}
