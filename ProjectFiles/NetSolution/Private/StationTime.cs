using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "UAC", Guid = "de68e7e831c2f76de671ed3a7831972d")]
public class StationTime : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
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
    public string DripTime
    {
        get
        {
            return (string)Refs.GetVariable("DripTime").Value.Value;
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
    public string PendulumTime
    {
        get
        {
            return (string)Refs.GetVariable("PendulumTime").Value.Value;
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
#endregion
}
