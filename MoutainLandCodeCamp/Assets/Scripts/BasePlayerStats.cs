using UnityEngine;
using static CharacterStat;

public class BasePlayerStats : MonoBehaviour
{
    public CharacterStat Strength;
    public CharacterStat Agility;
    public CharacterStat Vitality;
    

    public void WoodenButterKnife()
    {
        Strength.AddModifier(new StatModifier(10, StatModType.Flat));
    }
}
