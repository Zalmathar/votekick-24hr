using UnityEngine;
using CharacterStats;

public class Character : MonoBehavior
{
    public CharacterStat Strength = 10;

    public CharacterStat Dexterity = 10;

    public CharacterStat Vitality = 10;

    public int PlayerLevel = 1;



    public void WoodenButterKnife()
    {
        Strength.AddModifier(new StatModifier(10, StatModType));

      

       
    }
}