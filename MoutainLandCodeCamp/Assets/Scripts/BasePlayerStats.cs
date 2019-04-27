using UnityEngine;
using static CharacterStat;

public class BasePlayerStats : MonoBehaviour
{
    public CharacterStat Strength;
    public CharacterStat Agility;
    public CharacterStat Vitality;
    
    // Add a correct modifier for each weapon when eqipted in Inventory
    // Add Player Leveling system
    public void WoodenButterKnife()
    {
        Strength.AddModifier(new StatModifier(10, StatModType.Flat));
    }
}
