using UnityEngine;
using UnityEngine.Events;

namespace KID
{
    public class TriggerArea : MonoBehaviour
    {
        [Header("觸發目標的標籤"), SerializeField]
        private string tagTarget = "Player";
        [Header("觸發事件"), SerializeField]
        private UnityEvent onTrigger;
        [Header("是否觸發一次"), SerializeField]
        private bool onceTrigger = true;

        private bool isTrigger;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(tagTarget)) Trigger();
        }

        private void Trigger()
        {
            if (onceTrigger)
            {
                if (isTrigger) return;
                isTrigger = true;
            }

            onTrigger?.Invoke();
        }
    }
}
