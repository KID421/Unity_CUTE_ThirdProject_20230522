using UnityEngine;
using UnityEngine.Events;

namespace KID
{
    public class InteractionObject : MonoBehaviour
    {
        [SerializeField, Header("可以互動事件")]
        private UnityEvent onCanInteraction;
        [SerializeField, Header("不可以互動事件")]
        private UnityEvent onCantInteraction;
        [SerializeField, Header("需要的指定物件")]
        private GameObject objInteraction;

        public void CheckInteraction()
        {
            if (objInteraction == null) onCanInteraction?.Invoke();
            if (objInteraction != null && !objInteraction.activeInHierarchy) onCanInteraction?.Invoke();
            else onCantInteraction?.Invoke();
        }
    }
}
