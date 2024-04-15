using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "UAC", Guid = "f913487af487cf6e935d5eac068be0cb")]
public class Station : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public int Number
    {
        get
        {
            return (int)Refs.GetVariable("Number").Value.Value;
        }
        set
        {
            Refs.GetVariable("Number").SetValue(value);
        }
    }
    public IUAVariable NumberVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Number");
        }
    }
    public string Name
    {
        get
        {
            return (string)Refs.GetVariable("Name").Value.Value;
        }
        set
        {
            Refs.GetVariable("Name").SetValue(value);
        }
    }
    public IUAVariable NameVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Name");
        }
    }
    public int ID
    {
        get
        {
            return (int)Refs.GetVariable("ID").Value.Value;
        }
        set
        {
            Refs.GetVariable("ID").SetValue(value);
        }
    }
    public IUAVariable IDVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ID");
        }
    }
    public int WorkbarNo
    {
        get
        {
            return (int)Refs.GetVariable("WorkbarNo").Value.Value;
        }
        set
        {
            Refs.GetVariable("WorkbarNo").SetValue(value);
        }
    }
    public IUAVariable WorkbarNoVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("WorkbarNo");
        }
    }
    public int DripTime
    {
        get
        {
            return (int)Refs.GetVariable("DripTime").Value.Value;
        }
        set
        {
            Refs.GetVariable("DripTime").SetValue(value);
        }
    }
    public IUAVariable DripTimeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("DripTime");
        }
    }
    public int PendulumTime
    {
        get
        {
            return (int)Refs.GetVariable("PendulumTime").Value.Value;
        }
        set
        {
            Refs.GetVariable("PendulumTime").SetValue(value);
        }
    }
    public IUAVariable PendulumTimeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("PendulumTime");
        }
    }
    public bool Locked
    {
        get
        {
            return (bool)Refs.GetVariable("Locked").Value.Value;
        }
        set
        {
            Refs.GetVariable("Locked").SetValue(value);
        }
    }
    public IUAVariable LockedVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Locked");
        }
    }
    public int Characteristic
    {
        get
        {
            return (int)Refs.GetVariable("Characteristic").Value.Value;
        }
        set
        {
            Refs.GetVariable("Characteristic").SetValue(value);
        }
    }
    public IUAVariable CharacteristicVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Characteristic");
        }
    }
    public int Position
    {
        get
        {
            return (int)Refs.GetVariable("Position").Value.Value;
        }
        set
        {
            Refs.GetVariable("Position").SetValue(value);
        }
    }
    public IUAVariable PositionVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Position");
        }
    }
    public string WorkbarData
    {
        get
        {
            return (string)Refs.GetVariable("WorkbarData").Value.Value;
        }
        set
        {
            Refs.GetVariable("WorkbarData").SetValue(value);
        }
    }
    public IUAVariable WorkbarDataVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("WorkbarData");
        }
    }
#endregion
}
