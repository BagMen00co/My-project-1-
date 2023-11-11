using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.TextCore.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class valuePool
{
    public StatValue maxValue;
    public int currentValue;
    public valuePool(StatValue maxValue)
    {
        this.maxValue = maxValue;
        this.currentValue = maxValue.value;
    }
}
public enum Statistic
{
    Hp,
    Damage,
    Armor
}
[Serializable]
public class StatValue
{
    public Statistic statisticType;
    public int value;
    public StatValue(Statistic type,int value)
    {
        this.statisticType = type;
        this.value = 10*value;
    }
}
[Serializable]
public class StatGroup
{
    public List<StatValue> stats;
    public StatGroup()
    {
        Init();
    }

    public void Init()
    {
        stats = new List<StatValue>();
        stats.Add(new StatValue(Statistic.Hp, 100));
        stats.Add(new StatValue(Statistic.Damage, 40));
        stats.Add(new StatValue(Statistic.Armor, 30));
    }

    internal StatValue Get(Statistic statToGet)
    {
        return stats[(int) statToGet];
    }
}
public enum Attribute
{
    Strength,
    Dexterity,
    Intelligent
}
[Serializable]
public class AttributeValue
{
    public Attribute attributeType;
    public int value;
    public AttributeValue(Attribute attribute, int value)
    {
        this.attributeType = attribute;
        this.value = value;
    }
}
[Serializable]
public class AttributeGroup
{
    public List<AttributeValue> attributes;
    public AttributeGroup()
    {
        Init();

    }

    public void Init()
    {
        attributes = new List<AttributeValue>();
        attributes.Add(new AttributeValue(Attribute.Strength, 0));
        attributes.Add(new AttributeValue(Attribute.Dexterity, 0));
        attributes.Add(new AttributeValue(Attribute.Intelligent, 0));
    }
}
public class Character : MonoBehaviour
{
    [SerializeField] AttributeGroup attributes;
    [SerializeField] StatGroup stats;
    [SerializeField] valuePool enemyHealth;

    // Start is called before the first frame update
    private void Start()
    {
        attributes = new AttributeGroup();
        attributes.Init();
        stats = new StatGroup();
        stats.Init();
        enemyHealth = new valuePool(stats.Get(Statistic.Hp));
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        damage = ApplyDefend(damage);
        enemyHealth.currentValue -= damage;
        Debug.Log("FUCK YOU, I have only " + enemyHealth.currentValue);
        CheckDeath();
    }

    private int ApplyDefend(int damage)
    {
        damage -= stats.Get(Statistic.Armor).value;
        if(damage <= 0)
        {
            damage = 1;
        }
        return damage;
    }

    private void CheckDeath()
    {
        if(enemyHealth.currentValue <=0)
        {
            Debug.Log("FUCKKKKKKKKK IM DEADDDDDD");
        }
    }

    public StatValue GetStatValue(Statistic statToGet)
    {
        return stats.Get(statToGet);
    }
}
