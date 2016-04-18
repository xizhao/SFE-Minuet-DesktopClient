namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    /// <summary>
    /// Implement this interface to handle events related to browser load status. The
    /// methods of this class will be called on the browser process UI thread or
    /// render process main thread (TID_RENDERER).
    /// </summary>
    public abstract unsafe partial class CefLoadHandler
    {
        private void on_loading_state_change(cef_load_handler_t* self, cef_browser_t* browser, int isLoading, int canGoBack, int canGoForward)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefLoadHandler.OnLoadingStateChange
        }
        
        /// <summary>
        /// Called when the loading state has changed. This callback will be executed
        /// twice -- once when loading is initiated either programmatically or by user
        /// action, and once when loading is terminated due to completion, cancellation
        /// of failure.
        /// </summary>
        // protected abstract void OnLoadingStateChange(cef_browser_t* browser, int isLoading, int canGoBack, int canGoForward);
        
        private void on_load_start(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefLoadHandler.OnLoadStart
        }
        
        /// <summary>
        /// Called when the browser begins loading a frame. The |frame| value will
        /// never be empty -- call the IsMain() method to check if this frame is the
        /// main frame. Multiple frames may be loading at the same time. Sub-frames may
        /// start or continue loading after the main frame load has ended. This method
        /// may not be called for a particular frame if the load request for that frame
        /// fails. For notification of overall browser load status use
        /// OnLoadingStateChange instead.
        /// </summary>
        // protected abstract void OnLoadStart(cef_browser_t* browser, cef_frame_t* frame);
        
        private void on_load_end(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, int httpStatusCode)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefLoadHandler.OnLoadEnd
        }
        
        /// <summary>
        /// Called when the browser is done loading a frame. The |frame| value will
        /// never be empty -- call the IsMain() method to check if this frame is the
        /// main frame. Multiple frames may be loading at the same time. Sub-frames may
        /// start or continue loading after the main frame load has ended. This method
        /// will always be called for all frames irrespective of whether the request
        /// completes successfully.
        /// </summary>
        // protected abstract void OnLoadEnd(cef_browser_t* browser, cef_frame_t* frame, int httpStatusCode);
        
        private void on_load_error(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, CefErrorCode errorCode, cef_string_t* errorText, cef_string_t* failedUrl)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefLoadHandler.OnLoadError
        }
        
        /// <summary>
        /// Called when the resource load for a navigation fails or is canceled.
        /// |errorCode| is the error code number, |errorText| is the error text and
        /// |failedUrl| is the URL that failed to load. See net\base\net_error_list.h
        /// for complete descriptions of the error codes.
        /// </summary>
        // protected abstract void OnLoadError(cef_browser_t* browser, cef_frame_t* frame, CefErrorCode errorCode, cef_string_t* errorText, cef_string_t* failedUrl);
        
    }
}