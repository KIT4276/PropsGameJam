using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField, Range(0, 20)] private float _hp;
    [SerializeField] private float _maxhp;
    [SerializeField] private float _minhp;
}
