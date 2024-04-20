#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using System.Reflection.PortableExecutable;
using FTOptix.WebUI;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
#endregion

public class QVDataGridLogic : BaseNetLogic
{
    private IUANode _header;
    private IUANode _body;
    private IReadOnlyList<IUANode> result;
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        _header = Owner.Get("ScrollView/VerticalLayout/Header");
        _body = Owner.Get("ScrollView/VerticalLayout/Body");


        var dataPath = Owner.GetVariable("Data Path").Value;
        var dataItems = Project.Current.Get(dataPath.Value.ToString()).GetOwnedNodes();
        if (dataItems != null)
        {
            if (dataPath.ToString().Contains("AnalogsValues"))
            {
                result = dataItems.Where(x => x.GetVariable("Name").Value != "").ToList();
            }



            if (_header.Children.Count > 0)
            {
                _header.Children.Clear();
            }

            if (_body.Children.Count > 0)
            {
                _body.Children.Clear();
            }

            var uaObjectType = InformationModel.Get(Owner.GetVariable("TItem").Value);

            // get type of uaObjectType
            if (uaObjectType.GetType() == typeof(UAObjectType))
            {

            }


            // Render Header Row
            var columns = Owner.Get<UAObject>("Columns").Children;



            for (var j = 0; j < columns.Count; j++)
            {

                var column = columns[j];
                var prop = column.GetVariable("Property").Value;

                var checkExistedColumnFieldWithItemType = uaObjectType.GetVariable(column.GetVariable("Property").Value) != null;

                if (!checkExistedColumnFieldWithItemType) continue;
                var hCell = InformationModel.Make<TbCellHeader>($"header-{column.BrowseName}");
                var labelHeaderText = (Label)hCell.GetObject("Text");
                labelHeaderText.Text = column.GetVariable("Title").Value;
                if (j > 0)
                {
                    hCell.LeftMargin = -2;
                    hCell.Width = (float)column.GetVariable("Width").Value;
                }
                if (dataPath.ToString().Contains("AnalogsValues") && result.Count == 0 && prop.Value.ToString().StartsWith("Name") == true) { continue; }
                else
                {
                    _header.Children.Add(hCell);
                }

            }
            for (var i = 0; i < dataItems.Count; i++)
            {

                // Render Body Rows
                var dr = InformationModel.Make<RowLayout>($"row-{i}");
                for (var j = 0; j < columns.Count; j++)
                {

                    var column = columns[j];
                    var prop = column.GetVariable("Property").Value;

                    var checkExistedColumnFieldWithItemType = uaObjectType.GetVariable(prop) != null;

                    if (!checkExistedColumnFieldWithItemType) continue;

                    var cellType = InformationModel.Get(column.GetVariable("CellType").Value);

                    if (cellType.BrowseName == "TbCellItemText")
                    {
                        var hCell = InformationModel.Make<TbCellItemText>($"item-{column.BrowseName}");
                        var dtValue = hCell.GetObject("Text").GetOrCreateVariable("Text");
                        dtValue.SetDynamicLink(dataItems[i].GetVariable(prop), DynamicLinkMode.ReadWrite);
                        if (j > 0)
                        {
                            hCell.LeftMargin = -2;
                            hCell.Width = (float)column.GetVariable("Width").Value;
                            var textHorizontal = (Label)hCell.GetObject("Text");
                            switch ((int)column.GetVariable("Texthorizontalalignment").Value.Value)
                            {
                                case 0:
                                    textHorizontal.TextHorizontalAlignment = TextHorizontalAlignment.Left; break;
                                case 1:
                                    textHorizontal.TextHorizontalAlignment = TextHorizontalAlignment.Center; break;
                                case 2:
                                    textHorizontal.TextHorizontalAlignment = TextHorizontalAlignment.Right; break;
                            }

                            // textHorizontal.TextHorizontalAlignment =  column.GetVariable("Texthorizontalalignment");

                        }
                        if (dataPath.ToString().Contains("AnalogsValues") && result.Count == 0 && prop.Value.ToString().StartsWith("Name") == true) { continue; }
                        else
                        {
                            dr.Children.Add(hCell);
                        }
                    }
                    else if (cellType.BrowseName == "TbCellItemEditText")
                    {
                        var hCell = InformationModel.Make<TbCellItemEditText>($"item-{column.BrowseName}");
                        var dtValue = hCell.GetObject("EditableLabel1").GetOrCreateVariable("Text");
                        dtValue.SetDynamicLink(dataItems[i].GetVariable(prop), DynamicLinkMode.ReadWrite);
                        if (j > 0)
                        {
                            hCell.LeftMargin = -2;
                            hCell.Width = (float)column.GetVariable("Width").Value;
                        }
                        if (dataPath.ToString().Contains("AnalogsValues") && result.Count == 0 && prop.Value.ToString().StartsWith("Name") == true) { continue; }
                        else
                        {
                            dr.Children.Add(hCell);
                        }
                    }
                    else if (cellType.BrowseName == "TbCellItemCheckBox")
                    {
                        var hCell = InformationModel.Make<TbCellItemCheckBox>($"item-{column.BrowseName}");
                        var dtValue = hCell.GetObject("Checkbox").GetOrCreateVariable("Checked");
                        dtValue.SetDynamicLink(dataItems[i].GetVariable(prop), DynamicLinkMode.ReadWrite);
                        if (j > 0)
                        {
                            hCell.LeftMargin = -2;
                        }

                        if (dataPath.ToString().Contains("AnalogsValues") && result.Count == 0 && prop.Value.ToString().StartsWith("Name") == true) { continue; }
                        else
                        {
                            dr.Children.Add(hCell);
                        }
                    }
                    else if (cellType.BrowseName == "TbCellItemButton")
                    {
                        var hCell = InformationModel.Make<TbCellItemButton>($"item-{column.BrowseName}");
                        var dtValue = hCell.GetObject("Button").GetOrCreateVariable("Text");
                        if (dataItems[i].GetVariable(prop).Value == 1)
                        {

                            switch (hCell.BrowseName)
                            {
                                case "item-Select":
                                    dtValue.Value = "OFF"; break;
                                case "item-Status":
                                    dtValue.Value = "PAS"; break;
                                case "item-Fault":
                                    dtValue.Value = ""; break;
                                case "item-Base":
                                    dtValue.Value = ""; break;

                            }
                            var bgButton = (Button)hCell.GetObject("Button");
                            bgButton.BackgroundColor = Colors.Gray;
                        }
                        else if (dataItems[i].GetVariable(prop).Value == 2)
                        {
                            switch (hCell.BrowseName)
                            {
                                case "item-Select":
                                    dtValue.Value = "ON"; break;
                                case "item-Status":
                                    dtValue.Value = "ACT"; break;
                                case "item-Fault":
                                    dtValue.Value = ""; break;
                                case "item-Base":
                                    dtValue.Value = ""; break;
                            }
                            var bgButton = (Button)hCell.GetObject("Button");
                            bgButton.BackgroundColor = Colors.Green;
                        }
                        else
                        {

                            var bgButton = (Button)hCell.GetObject("Button");
                            bgButton.Visible = false;
                        }
                        //dtValue.SetDynamicLink(dataItems[i].GetVariable(prop), DynamicLinkMode.ReadWrite);
                        if (j > 0)
                        {

                            hCell.LeftMargin = -2;
                            hCell.Width = (float)column.GetVariable("Width").Value;
                        }
                        if (dataPath.ToString().Contains("AnalogsValues") && result.Count == 0 && prop.Value.ToString().StartsWith("Name") == true) { continue; }
                        else
                        {
                            dr.Children.Add(hCell);
                        }
                    }
                    else if (cellType.BrowseName == "TbCellItemCombobox")
                    {
                        var hCell = InformationModel.Make<TbCellItemCombobox>($"item-{column.BrowseName}");
                        // var dtValue = hCell.GetObject("Combobox").GetOrCreateVariable("Text");
                        var dtValue = (ComboBox)hCell.GetObject("Combobox");



                        if (j > 0)
                        {

                            hCell.LeftMargin = -2;
                            hCell.Width = (float)column.GetVariable("Width").Value;
                        }
                        if (dataPath.ToString().Contains("AnalogsValues") && result.Count == 0 && prop.Value.ToString().StartsWith("Name") == true) { continue; }
                        else
                        {
                            dr.Children.Add(hCell);
                        }
                    }
                    else if (cellType.BrowseName == "TbCellItemButtonNotText")
                    {
                        var hCell = InformationModel.Make<TbCellItemButtonNotText>($"item-{column.BrowseName}");
                        if (dataItems[i].GetVariable(prop).Value == 1)
                        {
                            var bgButton = (Button)hCell.GetObject("Button");
                            bgButton.BackgroundColor = Colors.Gray;
                        }
                        else if (dataItems[i].GetVariable(prop).Value == 2)
                        {

                            var bgButton = (Button)hCell.GetObject("Button");
                            bgButton.BackgroundColor = Colors.Green;
                        }
                        else
                        {
                            var bgButton = (Button)hCell.GetObject("Button");
                            bgButton.Visible = false;
                        }
                        if (j > 0)
                        {
                            hCell.LeftMargin = -2;
                            hCell.Width = (float)column.GetVariable("Width").Value;
                        }
                        if (dataPath.ToString().Contains("AnalogsValues") && result.Count == 0 && prop.Value.ToString().StartsWith("Name") == true) { continue; }
                        else
                        {
                            dr.Children.Add(hCell);
                        }
                    }
                    else if (cellType.BrowseName == "TbCellItem")
                    {
                        var hCell = InformationModel.Make<TbCellItem>($"item-{column.BrowseName}");
                        if (j > 0)
                        {
                            hCell.LeftMargin = -2;
                            hCell.Width = (float)column.GetVariable("Width").Value;
                        }
                        if (dataPath.ToString().Contains("AnalogsValues") && result.Count == 0 && prop.Value.ToString().StartsWith("Name") == true) { continue; }
                        else
                        {
                            dr.Children.Add(hCell);
                        }

                    }
                    else if (cellType.BrowseName == "TbCellItemProgressbar")
                    {
                        var hCell = InformationModel.Make<TbCellItemProgressbar>($"item-{column.BrowseName}");
                        var columnLayout = (ColumnLayout)hCell.GetObject("VerticalLayout1");
                        var actualProgressbar = (Rectangle)columnLayout.GetObject("Rectangle1");
                        var setpointProgressbar = (Rectangle)columnLayout.GetObject("Rectangle2");

                        actualProgressbar.Width = (float)dataItems[i].GetVariable("Act").Value;

                        setpointProgressbar.Width = (float)dataItems[i].GetVariable("Actual_Target").Value;
                        setpointProgressbar.FillColor = Colors.Gray;
                        setpointProgressbar.BorderColor = Colors.Gray;
                        if (((float)dataItems[i].GetVariable("Actual_Target").Value + (float)dataItems[i].GetVariable("Actual_Fitplus").Value) > (float)dataItems[i].GetVariable("Act").Value
                           && ((float)dataItems[i].GetVariable("Actual_Target").Value - (float)dataItems[i].GetVariable("Actual_Fitsubtract").Value) < (float)dataItems[i].GetVariable("Act").Value)
                        {

                            actualProgressbar.FillColor = Colors.Green;
                            actualProgressbar.BorderColor = Colors.Green;

                        }
                        else
                        {
                            actualProgressbar.FillColor = Colors.Red;
                            actualProgressbar.BorderColor = Colors.Red;
                        }

                        if (j > 0)
                        {
                            hCell.LeftMargin = -2;
                            hCell.Width = (float)column.GetVariable("Width").Value;
                        }
                        if (dataPath.ToString().Contains("AnalogsValues") && result.Count == 0 && prop.Value.ToString().StartsWith("Name") == true) { continue; }
                        else
                        {
                            dr.Children.Add(hCell);
                        }

                    }

                }
                _body.Children.Add(dr);
            }


        }
        
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
