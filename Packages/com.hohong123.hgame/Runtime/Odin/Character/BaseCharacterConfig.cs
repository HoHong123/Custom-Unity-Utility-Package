#if UNITY_EDITOR
/* =========================================================
 * @Jason - PKH
 * ���� ĳ���Ϳ� ���� ���� �⺻�̵Ǵ� ĳ���� ������ ��� SO �����Դϴ�.
 * =========================================================
 */
#endif

using UnityEngine;
using Sirenix.OdinInspector;

namespace HGame.Game.Character {
    public class BaseCharacterConfig : ScriptableObject {
        [Title("Meta")]
        [SerializeField]
        protected int uid;
        [SerializeField]
        protected string charName;

        public int UID => uid;
        public string Name => charName;
    }
}