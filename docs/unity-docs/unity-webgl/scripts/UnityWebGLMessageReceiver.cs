namespace ygg.common.webgl
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json.Linq;
    using UnityEngine;
    using UnityEngine.Events;
    using YGG.Common.Singletons;

    /// <summary>
    /// This class is use for receiving message from WebGL on browser and dispatch to other classes.
    /// </summary>
    public class UnityWebGLMessageReceiver : DontDestroyOnLoadBehaviorSingleton<UnityWebGLMessageReceiver>
    {
        #region Configurations

        private readonly ILogger _logger = Debug.unityLogger;
        private const string LOGTag = "WebGLManager";
        private bool _isDestroyed;

        #endregion

        #region Lifecycle

        private void OnDestroy()
        {
            _isDestroyed = true;
        }

        #endregion Lifecycle

        #region Accessors

        public event Action<string> MessageDispatcher;

        /// <summary>
        /// It could be portrait-primary, portrait-secondary, landscape-primary, landscape-secondary, portrait, and landscape
        /// </summary>
        public event Action<string> OnOrientationChanged;

        public event Action<string> OnAccessTokenChanged;

        public event Action OnSizeChanged;
        
        public event Action OnBrowserTabHide;
        public event Action OnBrowserTabShow;

        #endregion

        /// <summary>
        ///  Dispatch the message to the registered action. (Called from webGL, not from Unity itself)
        /// </summary>
        /// <param name="message"></param>

        // ReSharper disable once UnusedMember.Global
        public void CommonDispatchMessage(string message)
        {
            if (_isDestroyed)
            {
                return;
            }
            MessageDispatcher?.Invoke(message);
        }

        /// <summary>
        /// Called when the orientation of the webGL changed (Called from webGL, not from Unity itself)
        /// </summary>
        /// <param name="type"></param>

        // ReSharper disable once UnusedMember.Global
        public void OrientationChanged(string type)
        {
            if (_isDestroyed)
            {
                return;
            }
            OnOrientationChanged?.Invoke(type);
        }

        /// <summary>
        ///  Called when the size of the webGL changed (Called from webGL, not from Unity itself)
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public void SizeChanged()
        {
            if (_isDestroyed)
            {
                return;
            }
            OnSizeChanged?.Invoke();
        }

        /// <summary>
        /// Set the Jwt token from webGL. (Called from webGL, not from Unity itself)
        /// </summary>
        /// <param name="token"></param>

        // ReSharper disable once UnusedMember.Global
        public void SetAccessToken(string token)
        {
            if (_isDestroyed)
            {
                return;
            }
            OnAccessTokenChanged?.Invoke(token);
        }
        
        public void BrowserTabHide()
        {
            if (_isDestroyed)
            {
                return;
            }
            OnBrowserTabHide?.Invoke();
        }

        public void BrowserTabShow()
        {
            if (_isDestroyed)
            {
                return;
            }
            OnBrowserTabShow?.Invoke();
        }
    }
}
