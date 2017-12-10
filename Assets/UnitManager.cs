using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public  class UnitManager : MonoBehaviour {

    private string UnitName;
    private string UnitDescription;

    //stats
    private string UnitClass;
    private string Nation;
    private string UnitModel;
    private int UnitLevel;
    private int HP;
    private int FirePower;
    private int Armor;
    private int Actual;
    private int Avoidance;
    private int AA;
    private int Scout;

    private int FireRange;
    private int Movement;
    private int Moral;
    private int Fuel;
    private int Ammo;

    public string UnitNameValue
    {
        get { return UnitName; }
        set { UnitNameValue = value; }
    }

    public string UnitDescriptionValue
    {
        get { return UnitDescription; }
        set { UnitDescriptionValue = value; }
    }

    public string UnitClassValue
    {
        get { return UnitClass; }
        set { UnitClassValue = value; }
    }

    public string NationValue
    {
        get { return Nation; }
        set { NationValue = value; }
    }

    public string UnitModelValue
    {
        get { return UnitModel; }
        set { UnitModelValue = value; }
    }

    public int UnitLevelValue
    {
        get { return UnitLevel; }
        set { UnitLevelValue = value; }
    }

    public int HPValue
    {
        get { return HP; }
        set { HPValue = value; }
    }

    public int FirePowerValue
    {
        get { return FirePower; }
        set { FirePowerValue = value; }
    }

    public int ArmorValue
    {
        get { return Armor; }
        set { ArmorValue = value; }
    }

    public int ActualValue
    {
        get { return Actual; }
        set { ActualValue = value; }
    }

    public int AvoidanceValue
    {
        get { return Avoidance; }
        set { AvoidanceValue = value; }
    }

    public int AAValue
    {
        get { return AA; }
        set { AAValue = value; }
    }

    public int ScoutValue
    {
        get { return Scout; }
        set { ScoutValue = value; }
    }

    public int FireRangeValue
    {
        get { return FireRange; }
        set { FireRangeValue = value; }
    }

    public int MovementValue
    {
        get { return Movement; }
        set { MovementValue = value; }
    }

    public int MoralValue
    {
        get { return Moral; }
        set { MoralValue = value; }
    }

    public int FuelValue
    {
        get { return Fuel; }
        set { FuelValue = value; }
    }

    public int AmmoValue
    {
        get { return Ammo; }
        set { AmmoValue = value; }
    }
}
