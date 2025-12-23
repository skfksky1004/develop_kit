using UnityEngine;

namespace skfksky1004.DevKit.UI
{
    public abstract class UIBasePanel : MonoBehaviour
    {
        private CanvasGroup canvasGroup;

        protected RectTransform RectTransform => (RectTransform)transform;

        private void Start()
        {
            if (canvasGroup is null)
                canvasGroup = GetComponent<CanvasGroup>();
        }

        protected void SetPanelAlpha(float value)
        {
            if (canvasGroup != null)
                canvasGroup.alpha = value;
        }

        public void SetActive(bool bActive, GameObject targetGo = null)
        {
            if (targetGo == null)
                targetGo = this.gameObject;

            targetGo?.SetActive(bActive);
        }

        /// <summary>
        /// 패널 생성후 Initialize
        /// </summary>
        public abstract void CreatedPanel();

        /// <summary>
        /// 패널 열때
        /// </summary>
        public abstract void ShowPanel();

        /// <summary>
        /// 패널 닫을때
        /// </summary>
        public abstract void HidePanel();

        /// <summary>
        /// esc 반응
        /// </summary>
        /// <returns></returns>
        public abstract bool IsProcessEscape();

        /// <summary>
        /// 패널 네임
        /// </summary>
        /// <returns></returns>
        public abstract string GetPanelName();

        // /// <summary>
        // /// 
        // /// </summary>
        // /// <returns></returns>
        // public abstract UIType GetPanelType();
    }
}