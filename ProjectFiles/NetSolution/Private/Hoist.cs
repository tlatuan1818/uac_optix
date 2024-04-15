using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "UAC", Guid = "287210e6d1c3e51bef1009b492a9297e")]
public class Hoist : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public int Start
    {
        get
        {
            return (int)Refs.GetVariable("Start").Value.Value;
        }
        set
        {
            Refs.GetVariable("Start").SetValue(value);
        }
    }
    public IUAVariable StartVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Start");
        }
    }
    public int Dest
    {
        get
        {
            return (int)Refs.GetVariable("Dest").Value.Value;
        }
        set
        {
            Refs.GetVariable("Dest").SetValue(value);
        }
    }
    public IUAVariable DestVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Dest");
        }
    }
    public string LiftLevelStatus
    {
        get
        {
            return (string)Refs.GetVariable("LiftLevelStatus").Value.Value;
        }
        set
        {
            Refs.GetVariable("LiftLevelStatus").SetValue(value);
        }
    }
    public IUAVariable LiftLevelStatusVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("LiftLevelStatus");
        }
    }
    public string LiftLevelDesired
    {
        get
        {
            return (string)Refs.GetVariable("LiftLevelDesired").Value.Value;
        }
        set
        {
            Refs.GetVariable("LiftLevelDesired").SetValue(value);
        }
    }
    public IUAVariable LiftLevelDesiredVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("LiftLevelDesired");
        }
    }
    public int Mode
    {
        get
        {
            return (int)Refs.GetVariable("Mode").Value.Value;
        }
        set
        {
            Refs.GetVariable("Mode").SetValue(value);
        }
    }
    public IUAVariable ModeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Mode");
        }
    }
    public int Increment
    {
        get
        {
            return (int)Refs.GetVariable("Increment").Value.Value;
        }
        set
        {
            Refs.GetVariable("Increment").SetValue(value);
        }
    }
    public IUAVariable IncrementVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Increment");
        }
    }
    public int Desired
    {
        get
        {
            return (int)Refs.GetVariable("Desired").Value.Value;
        }
        set
        {
            Refs.GetVariable("Desired").SetValue(value);
        }
    }
    public IUAVariable DesiredVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Desired");
        }
    }
    public int Reserved
    {
        get
        {
            return (int)Refs.GetVariable("Reserved").Value.Value;
        }
        set
        {
            Refs.GetVariable("Reserved").SetValue(value);
        }
    }
    public IUAVariable ReservedVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Reserved");
        }
    }
    public int Priority
    {
        get
        {
            return (int)Refs.GetVariable("Priority").Value.Value;
        }
        set
        {
            Refs.GetVariable("Priority").SetValue(value);
        }
    }
    public IUAVariable PriorityVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Priority");
        }
    }
    public string TravelStatus
    {
        get
        {
            return (string)Refs.GetVariable("TravelStatus").Value.Value;
        }
        set
        {
            Refs.GetVariable("TravelStatus").SetValue(value);
        }
    }
    public IUAVariable TravelStatusVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("TravelStatus");
        }
    }
    public int TravelInterlock
    {
        get
        {
            return (int)Refs.GetVariable("TravelInterlock").Value.Value;
        }
        set
        {
            Refs.GetVariable("TravelInterlock").SetValue(value);
        }
    }
    public IUAVariable TravelInterlockVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("TravelInterlock");
        }
    }
    public int ActualPosition
    {
        get
        {
            return (int)Refs.GetVariable("ActualPosition").Value.Value;
        }
        set
        {
            Refs.GetVariable("ActualPosition").SetValue(value);
        }
    }
    public IUAVariable ActualPositionVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ActualPosition");
        }
    }
    public int LiftStatus
    {
        get
        {
            return (int)Refs.GetVariable("LiftStatus").Value.Value;
        }
        set
        {
            Refs.GetVariable("LiftStatus").SetValue(value);
        }
    }
    public IUAVariable LiftStatusVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("LiftStatus");
        }
    }
    public int LiftInterlock
    {
        get
        {
            return (int)Refs.GetVariable("LiftInterlock").Value.Value;
        }
        set
        {
            Refs.GetVariable("LiftInterlock").SetValue(value);
        }
    }
    public IUAVariable LiftInterlockVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("LiftInterlock");
        }
    }
    public string TravelInterlockDescription
    {
        get
        {
            return (string)Refs.GetVariable("TravelInterlockDescription").Value.Value;
        }
        set
        {
            Refs.GetVariable("TravelInterlockDescription").SetValue(value);
        }
    }
    public IUAVariable TravelInterlockDescriptionVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("TravelInterlockDescription");
        }
    }
    public string LiftInterlockDescription
    {
        get
        {
            return (string)Refs.GetVariable("LiftInterlockDescription").Value.Value;
        }
        set
        {
            Refs.GetVariable("LiftInterlockDescription").SetValue(value);
        }
    }
    public IUAVariable LiftInterlockDescriptionVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("LiftInterlockDescription");
        }
    }
    public string TravelStatusPLC
    {
        get
        {
            return (string)Refs.GetVariable("TravelStatusPLC").Value.Value;
        }
        set
        {
            Refs.GetVariable("TravelStatusPLC").SetValue(value);
        }
    }
    public IUAVariable TravelStatusPLCVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("TravelStatusPLC");
        }
    }
#endregion
}
