using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "UAC", Guid = "31060e9afdf78ae8c21f5ec505cca49f")]
public class Fault : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public string Entry
    {
        get
        {
            return (string)Refs.GetVariable("Entry").Value.Value;
        }
        set
        {
            Refs.GetVariable("Entry").SetValue(value);
        }
    }
    public IUAVariable EntryVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Entry");
        }
    }
    public string Confirmed
    {
        get
        {
            return (string)Refs.GetVariable("Confirmed").Value.Value;
        }
        set
        {
            Refs.GetVariable("Confirmed").SetValue(value);
        }
    }
    public IUAVariable ConfirmedVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Confirmed");
        }
    }
    public string Ok
    {
        get
        {
            return (string)Refs.GetVariable("Ok").Value.Value;
        }
        set
        {
            Refs.GetVariable("Ok").SetValue(value);
        }
    }
    public IUAVariable OkVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Ok");
        }
    }
    public string Position
    {
        get
        {
            return (string)Refs.GetVariable("Position").Value.Value;
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
    public string Symbol
    {
        get
        {
            return (string)Refs.GetVariable("Symbol").Value.Value;
        }
        set
        {
            Refs.GetVariable("Symbol").SetValue(value);
        }
    }
    public IUAVariable SymbolVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Symbol");
        }
    }
    public string User
    {
        get
        {
            return (string)Refs.GetVariable("User").Value.Value;
        }
        set
        {
            Refs.GetVariable("User").SetValue(value);
        }
    }
    public IUAVariable UserVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("User");
        }
    }
    public string Description
    {
        get
        {
            return (string)Refs.GetVariable("Description").Value.Value;
        }
        set
        {
            Refs.GetVariable("Description").SetValue(value);
        }
    }
    public IUAVariable DescriptionVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Description");
        }
    }
    public string FaultID
    {
        get
        {
            return (string)Refs.GetVariable("FaultID").Value.Value;
        }
        set
        {
            Refs.GetVariable("FaultID").SetValue(value);
        }
    }
    public IUAVariable FaultIDVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("FaultID");
        }
    }
#endregion
}
