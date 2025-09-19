#if UNITY_EDITOR
/* =========================================================
 * @Jason - PKH
 * ���� ������Ʈ�� ���� ���� Ǯ���ý��� �Ŵ�����Ʈ �ý����� �����ϴ� ������Ʈ ��ũ��Ʈ�Դϴ�.
 * =========================================================
 */
#endif

using System.Collections.Generic;
using UnityEngine;
using Util.OdinCompat;

namespace Util.Pooling {
    public class UnityPoolConnector : MonoBehaviour {
        [HeaderToTitle("Entities")]
        [Tooltip("Must use 'IPoolable' prefab")]
        [SerializeField]
        List<UnityPoolEntity> poolEntity = new();


        private void Awake() {
            foreach (var entity in poolEntity) {
                UnityPoolMaster.Register(entity);
            }
        }

        private void OnDestroy() {
            foreach (var entity in poolEntity) {
                UnityPoolMaster.Remove(entity);
            }
        }
    }
}

#if UNITY_EDITOR
/* @Jason
 * Created at May. 29. 2025
 * 1. Create for example.
 */
#endif