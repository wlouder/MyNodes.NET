﻿/*  MyNetSensors 
    Copyright (C) 2015 Derwish <derwish.pro@gmail.com>
    License: http://www.gnu.org/licenses/gpl-3.0.txt  
*/

namespace MyNetSensors.Nodes
{
    public class LogicOrNode : Node
    {
        public LogicOrNode() : base("Logic", "OR", 2, 1)
        {
            Inputs[0].Type = DataType.Logical;
            Inputs[1].Type = DataType.Logical;
            Outputs[0].Type = DataType.Logical;

            options.ResetOutputsWhenAnyInputIsNull = true;
        }

        public override void OnInputChange(Input input)
        {
            var result = "1";

            if (Inputs[0].Value == "0" && Inputs[1].Value == "0")
                result = "0";

            Outputs[0].Value = result;
        }
    }
}