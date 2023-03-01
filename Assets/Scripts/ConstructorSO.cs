using UnityEngine;


[CreateAssetMenu()]
public class ConstructorSO : ScriptableObject
{
    public string constructorName;
    public float constructorPrice;
    public Sprite carSprite; 
    public Sprite teamLogoSprite;
    public Color backgroundColor = new Color();
}
