//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_waitable_event_t
    {
        internal cef_base_t _base;
        internal IntPtr _reset;
        internal IntPtr _signal;
        internal IntPtr _is_signaled;
        internal IntPtr _wait;
        internal IntPtr _timed_wait;
        
        // CreateWaitableEvent
        [DllImport(libcef.DllName, EntryPoint = "cef_waitable_event_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_waitable_event_t* create(int automatic_reset, int initially_signaled);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_waitable_event_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_waitable_event_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_waitable_event_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void reset_delegate(cef_waitable_event_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void signal_delegate(cef_waitable_event_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_signaled_delegate(cef_waitable_event_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void wait_delegate(cef_waitable_event_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int timed_wait_delegate(cef_waitable_event_t* self, long max_ms);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_waitable_event_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_waitable_event_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // HasOneRef
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static int has_one_ref(cef_waitable_event_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // Reset
        private static IntPtr _p3;
        private static reset_delegate _d3;
        
        public static void reset(cef_waitable_event_t* self)
        {
            reset_delegate d;
            var p = self->_reset;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (reset_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(reset_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            d(self);
        }
        
        // Signal
        private static IntPtr _p4;
        private static signal_delegate _d4;
        
        public static void signal(cef_waitable_event_t* self)
        {
            signal_delegate d;
            var p = self->_signal;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (signal_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(signal_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            d(self);
        }
        
        // IsSignaled
        private static IntPtr _p5;
        private static is_signaled_delegate _d5;
        
        public static int is_signaled(cef_waitable_event_t* self)
        {
            is_signaled_delegate d;
            var p = self->_is_signaled;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (is_signaled_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_signaled_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // Wait
        private static IntPtr _p6;
        private static wait_delegate _d6;
        
        public static void wait(cef_waitable_event_t* self)
        {
            wait_delegate d;
            var p = self->_wait;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (wait_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(wait_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            d(self);
        }
        
        // TimedWait
        private static IntPtr _p7;
        private static timed_wait_delegate _d7;
        
        public static int timed_wait(cef_waitable_event_t* self, long max_ms)
        {
            timed_wait_delegate d;
            var p = self->_timed_wait;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (timed_wait_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(timed_wait_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self, max_ms);
        }
        
    }
}
