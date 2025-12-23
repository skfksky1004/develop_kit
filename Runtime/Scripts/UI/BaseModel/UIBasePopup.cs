using UnityEngine;
using UnityEngine.UI;

namespace skfksky1004.DevKit.UI
{
    public abstract class UIBasePopup : MonoBehaviour
    {
        [SerializeField] protected Image imgBackground;
        [SerializeField] protected GameObject goPopup;

        protected RectTransform RectTransform => (RectTransform)transform;


        public abstract void ShowPopup();
        public abstract void HidePopup();

        public void SetActive(bool isActive)
        {
            gameObject.SetActive(isActive);
        }
    }
}
