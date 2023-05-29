using UnityEngine;

[CreateAssetMenu(menuName ="Card/New Card", fileName ="New Card", order = 51 )]
public class Card : ScriptableObject
{
    public Sprite Icon;
    public GameObject Prefab;
    public int Cost;


}
