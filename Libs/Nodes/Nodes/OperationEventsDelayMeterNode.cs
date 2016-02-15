﻿//planer-pro copyright 2015 GPL - license.

using System;

namespace MyNetSensors.Nodes
{
    public class OperationEventsDelayMeterNode : Node
    {
        private DateTime lasTime;

        public OperationEventsDelayMeterNode() : base("Operation", "Events Delay Meter", 1, 1)
        {
            Outputs[0].Name = "Delay (ms)";

            Inputs[0].Type = DataType.Text;
            Outputs[0].Type = DataType.Number;

            lasTime = DateTime.Now;
        }


        public override void OnInputChange(Input input)
        {
            var delay = (DateTime.Now - lasTime).TotalMilliseconds;
            lasTime = DateTime.Now;

            Outputs[0].Value = delay.ToString();
        }
    }
}