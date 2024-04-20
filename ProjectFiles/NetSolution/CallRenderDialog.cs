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
using System.Linq;
#endregion

public class CallRenderDialog : BaseNetLogic
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
    public void DynamicRender(NodeId nodeId)
    {
        var spinbox = InformationModel.Get<SpinBox>(nodeId);
      

        var ListStation = Project.Current.Get<Folder>("Model/Stations");
        var result = ListStation.Children;
        foreach ( var child in result )
        {
            int childrenResult =(int)child.Children.GetVariable("Number").Value.Value;
            if ( childrenResult == (int)spinbox.Value) {
               
                var stationDialog = Project.Current.Get<Folder>("Model").GetObject("StationDialog");
               
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

                var lbllTitleNodeId = Owner.Get("Rectangle1/Rectangle1/HorizontalLayout1/Label1");
                var txtWorkbarNumberNodeId = Owner.Get("Rectangle1/Rectangle2/VerticalLayout1/Rectangle1/HorizontalLayout1/VerticalLayout2/HorizontalLayout1/TextBox1");
                var optionButton1NodeId = Owner.Get("Rectangle1/Rectangle2/VerticalLayout1/Rectangle1/HorizontalLayout1/VerticalLayout3/Rectangle1/OptionButton1");
                var optionButton2NodeId = Owner.Get("Rectangle1/Rectangle2/VerticalLayout1/Rectangle1/HorizontalLayout1/VerticalLayout3/Rectangle1/OptionButton2");  
              
                var titleDialog = InformationModel.Get<Label>(lbllTitleNodeId.NodeId);
                var txtWorkbarNumber = InformationModel.Get<TextBox>(txtWorkbarNumberNodeId.NodeId);
                var optionButton1 = InformationModel.Get<RadioButton>(optionButton1NodeId.NodeId);
                var optionButton2 = InformationModel.Get<RadioButton>(optionButton2NodeId.NodeId);
               

                titleDialog.Text = child.Children.GetVariable("Name").Value.Value.ToString();
                txtWorkbarNumber.Text = child.Children.GetVariable("WorkbarNo").Value.Value.ToString();
                if ((bool)child.Children.GetVariable("Locked").Value.Value == true)
                {
                    optionButton1.Checked = false;
                    optionButton2.Checked = true;
                }
                else
                {
                    optionButton1.Checked = true;
                    optionButton2.Checked = false;
                }
               

            }
           
        }
    }
}
