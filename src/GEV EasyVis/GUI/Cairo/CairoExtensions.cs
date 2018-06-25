using GEV.EasyVis.DeviceHandlers;
using GEV.Layouts.Extended.Cairo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.EasyVis.GUI.Cairo
{
    public class CairoExtensions
    {
        public static void Setup()
        {
            GEV.Layouts.Extended.Cairo.Formula.FormulaExtension.CustomFunctions["insight"] = new Func<Cell, object[], object>(InsightFormula);
            GEV.Layouts.Extended.Cairo.Formula.FormulaExtension.CustomFunctions["INSIGHT"] = new Func<Cell, object[], object>(InsightFormula);
        }


        public static object InsightFormula(Cell cell, object[] args)
        {
            if (args.Length >= 2)
            {
                InsightSensor iss = VisionSystem.Project.Devices.FirstOrDefault(device => device.Name == args[0].ToString()) as InsightSensor;
                if (iss != null)
                {
                    try
                    {
                        string arg = args[1].ToString();
                        switch (iss.GetCellType(arg))
                        {
                            case InsightSensor.CellType.Numeric:
                                return iss.GetFloatCell(arg);
                            case InsightSensor.CellType.String:
                            case InsightSensor.CellType.Other:
                                return iss.GetStringCell(arg);
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }

            }
            return null;

        }

    }
}
