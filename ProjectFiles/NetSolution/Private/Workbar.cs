using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "UAC", Guid = "9db25e310e87da8644fdd50f6d27c270")]
public class Workbar : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
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
    public int State
    {
        get
        {
            return (int)Refs.GetVariable("State").Value.Value;
        }
        set
        {
            Refs.GetVariable("State").SetValue(value);
        }
    }
    public IUAVariable StateVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("State");
        }
    }
    public int Release
    {
        get
        {
            return (int)Refs.GetVariable("Release").Value.Value;
        }
        set
        {
            Refs.GetVariable("Release").SetValue(value);
        }
    }
    public IUAVariable ReleaseVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Release");
        }
    }
    public int Time
    {
        get
        {
            return (int)Refs.GetVariable("Time").Value.Value;
        }
        set
        {
            Refs.GetVariable("Time").SetValue(value);
        }
    }
    public IUAVariable TimeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Time");
        }
    }
    public string StateDescription
    {
        get
        {
            return (string)Refs.GetVariable("StateDescription").Value.Value;
        }
        set
        {
            Refs.GetVariable("StateDescription").SetValue(value);
        }
    }
    public IUAVariable StateDescriptionVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StateDescription");
        }
    }
#endregion
}
