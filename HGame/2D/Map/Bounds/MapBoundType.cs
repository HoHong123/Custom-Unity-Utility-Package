#if UNITY_EDITOR
/* =========================================================
 * @Jason - PKH
 * 2D ȯ�� '�� �ݰ� ����' Ÿ�� ������ �����Դϴ�.
 * 1. WorldBox : ���� BoxCollider2D�� �� �ݰ��� �����ϴ� �ε���
 * 2. BoundSource : 'IWorldBoundSource'�� ����Ͽ� �� �ݰ��� �����ϴ� �ε���
 * 3. Absolute : ������ǥ�� �� �ݰ��� �����ϴ� �ε���
 * =========================================================
 */
#endif

public enum MapBoundType {
    WorldBox,
    BoundSource,
    Absolute,
}
