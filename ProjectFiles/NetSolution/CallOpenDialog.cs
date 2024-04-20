#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.WebUI;
#endregion

public class CallOpenDialog : BaseNetLogic
{
   

    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
    [ExportMethod]
    public void OpenDialog(int StationNumber)
    {

        DialogSession dialogSession = DialogSession.GetInstance();

        if (!dialogSession.IsOpen)
        {

            var myDialogType = (DialogType)Project.Current.Get("UI/Dialog/DialogBox1");
            var ListStation = Project.Current.Get<Folder>("Model/Stations");
            var result = ListStation.Children;
            foreach (var child in result)
            {
                int childrenResult = (int)child.Children.GetVariable("Number").Value.Value;
                if (childrenResult == StationNumber)
                {
                    var stationDialog = Project.Current.Get<Folder>("Model").GetObject("StationDialog");
                    stationDialog.GetVariable("dialogTitle").Value = child.Children.GetVariable("Name").Value.Value.ToString();
                    stationDialog.GetVariable("dialogStationNumber").Value = StationNumber;
                    stationDialog.GetVariable("dialogWorkbarNumber").Value = (int)child.Children.GetVariable("WorkbarNo").Value.Value;
                    stationDialog.GetVariable("dialogStationLock").Value = (bool)child.Children.GetVariable("Locked").Value.Value;
                    stationDialog.GetVariable("dialogStationPathTime").Value = child.Children.GetVariable("StationPathTime").Value.Value.ToString();
                    stationDialog.GetVariable("dialogStationPathDevice").Value = child.Children.GetVariable("StationPathDevice").Value.Value.ToString();
                    stationDialog.GetVariable("dialogStationPathAnalog").Value = child.Children.GetVariable("StationPathAnalog").Value.Value.ToString();
                    stationDialog.GetVariable("dialogStationPathParameter").Value = child.Children.GetVariable("StationPathParameter").Value.Value.ToString();
                    stationDialog.GetVariable("dialogStationPathFault").Value = child.Children.GetVariable("StationPathFault").Value.Value.ToString();
                    stationDialog.GetVariable("dialogStationTimesTabVisible").Value = (bool)child.Children.GetVariable("StationTimesTabVisible").Value.Value;
                    stationDialog.GetVariable("dialogStationDevicesTabVisible").Value = (bool)child.Children.GetVariable("StationDevicesTabVisible").Value.Value;
                    stationDialog.GetVariable("dialogStationAnalogValuesTabVisible").Value = (bool)child.Children.GetVariable("StationAnalogValuesTabVisible").Value.Value;
                    stationDialog.GetVariable("dialogStationParametersTabVisible").Value = (bool)child.Children.GetVariable("StationParametersTabVisible").Value.Value;
                    stationDialog.GetVariable("dialogStationFaultTabVisible").Value = (bool)child.Children.GetVariable("StationFaultsTabVisible").Value.Value;

                }

            }
            var parentPanel = (FTOptix.UI.Panel)Owner;
            UICommands.OpenDialog(parentPanel, myDialogType);
            dialogSession.IsOpen = true;
        }
       
    }
}


public class DialogSession
{
    private static DialogSession _instance;

    public bool IsOpen { get; set; }

    public static DialogSession GetInstance()
    {

        if(_instance == null)
        {
            _instance = new DialogSession();
        }

        return _instance;
    }
}
